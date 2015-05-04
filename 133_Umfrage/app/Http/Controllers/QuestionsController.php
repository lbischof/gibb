<?php namespace App\Http\Controllers;

use App\Models\Question;

class QuestionsController extends BaseController {

    public function getQuestions() {
        $user = \Auth::user();
       	$questions = Question::all();
        return view('survey', ['questions' => $questions, 'user' => $user ]);
    }

}
