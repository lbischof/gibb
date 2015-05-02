<?php namespace App\Http\Controllers;

use App\Http\Controllers\Controller;
use App\Models\Question;
use App\Models\Answer;


class QuestionsController extends Controller {

    public function getQuestions() {
        $user = \Auth::user();
        if ($user->answered) {
        	$questions = \DB::select('select *, value as answer from questions join answers on question_id = questions.id where user_id = ?', [$user->id]);
        } else {
        	$questions = Question::all();
        }
        return view('survey', ['questions' => $questions, 'user' => $user]);
    }

}