<?php namespace App\Http\Controllers;

use App\Models\Question;

class QuestionsController extends Controller {

    public function getQuestions() {
        $user = \Auth::user();
       	$questions = Question::all();
        return view('survey', ['questions' => $questions, 'user' => $user ]);
    }

}
