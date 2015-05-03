<?php namespace App\Http\Controllers;

use App\Models\User;
use App\Models\Question;

class AnswersController extends Controller {

    /*public function getAnswers() {
        $questions = Question::all();
        return view('survey', ['questions' => $questions]);
    }*/

    public function postAnswers() {
    	$answers = \Request::input('q');
        $hashed_user_id = bcrypt(\Auth::user()->id);
        $score = 0;
        foreach($answers as $key => $answer) {
            $answers[$key]['user_hash'] = $hashed_user_id;
            $answers[$key]['question_id'] = $key;
            $score += $answer['value'];
        }
    	\DB::table('answers')->insert($answers);

        $user = User::find(\Auth::user()->id);
    	$user->answered = true;
        $user->score = $score;
    	$user->save();

        \Session::put('user_hash', $hashed_user_id); //save users hash so we can show him his own answers

    	return redirect('/');
    }
    public function getResults() {
        $user_hash = \Session::get('user_hash'); //Try and get the user_hash. If it's empty we can't show the "Antworten anzeigen" link.
        $current_user_score = \Auth::user()->score;
        $total_score = Question::count() * 100;
        $users = \DB::select('select email, score, abs(score - ?) as distance from users where score not null order by distance', [$current_user_score]);
        foreach ($users as $key => $user) {
            $users[$key]->percent = abs((100 * $user->distance / $total_score) - 100);  
        }
                
        return view('results', ['users' => $users, 'user_hash' => $user_hash ]);
    }
}
