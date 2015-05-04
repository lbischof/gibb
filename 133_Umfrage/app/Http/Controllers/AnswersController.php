<?php namespace App\Http\Controllers;

use App\Models\User;
use App\Models\Question;

class AnswersController extends BaseController {

    public function postAnswers() {
        if (\Auth::user()->answered) // The user shouldn't be able to submit after answering. This would be a bug or clientside spoofing.
            return redirect('/');
    	$answers = \Request::input('q');
        $user_hash = bcrypt(\Auth::user()->id); // Hash the userid for anonymity
        $score = 0;
        foreach($answers as $key => $answer) {
            $answers[$key]['user_hash'] = $user_hash; // We add this to each answer so we can save it in the database.
            $score += $answer['value']; // Increment the score so we can find out the total score of the user and save it in the database
        }
    	\DB::table('answers')->insert($answers);
        $user = User::find(\Auth::user()->id);
    	$user->answered = true;
        $user->score = $score;
    	$user->save();
    	return redirect('/');
    }

    public function getResults() {
        if (!\Auth::user()->answered) // The user didn't answer the survey yet.
            return redirect('/');
        $current_user_score = \Auth::user()->score;
        $total_score = Question::count() * 100;
        $users = \DB::select('select id, name, email, score, abs(score - ?) as distance from users where score not null order by distance', [$current_user_score]); // get the distance/difference of all users score to the current user.
        foreach ($users as $key => $user) {
            $users[$key]->percent = abs((100 * $user->distance / $total_score) - 100); // Calculate the percentage from the difference in score
        } 
        return view('results', ['users' => $users ]);
    }
}
