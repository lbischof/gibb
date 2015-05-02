<?php namespace App\Http\Controllers;

use App\Http\Controllers\Controller;
use App\Models\Answer;
use App\Models\User;

class AnswersController extends Controller {

    /*public function getAnswers() {
        $questions = Question::all();
        return view('survey', ['questions' => $questions]);
    }*/

    public function postAnswers() {
    	$user = User::find(\Auth::user()->id);
    	$user->answered = true;
    	$user->save();

    	$answers = \Request::input('q');
    	\DB::table('answers')->insert($answers);
    	return redirect('/');
    }
}