<?php namespace App\Http\Controllers;

use App\Models\User;

class AnswersController extends Controller {

    /*public function getAnswers() {
        $questions = Question::all();
        return view('survey', ['questions' => $questions]);
    }*/

    public function postAnswers() {
    	$answers = \Request::input('q');
        $hash_user_id = bcrypt(\Auth::user()->id);
        $score = 0;
        foreach($answers as $key => $answer) {
            $answers[$key]['user_id'] = $hash_user_id;
            $score += $answer['value'];
        }
    	\DB::table('answers')->insert($answers);

        $user = User::find(\Auth::user()->id);
    	$user->answered = true;
        $user->score = $score;
    	$user->save();
    	return redirect('/results');
    }
    public function getResults() {
        $current_user_score = \Auth::user()->score;
        //$max_score
        $users = \DB::select('select * from users order by abs(score - ?)', [$current_user_score]);
        $questions_count = \DB::select('select count(*) as count from questions');

        $total_score = $questions_count[0]->count * 100;
        var_dump($total_score);
        foreach ($users as $key => $user) {
            $users[$key]->percent = 100 * $user->score / $total_score;       
        }
        //$current_user_percent = 100 * $current_user_score / $total_score;
        
        print_r($users);
        //$users = User::whereNotNull('score')->get();
        /*$total_score = 500;
        foreach($users as $key => $user) {
            $users[$key] = $total_score / $user->score * 100;            
        } */
        //print_r($users);
        return view('results', ['users' => $users ]);
    }
}
