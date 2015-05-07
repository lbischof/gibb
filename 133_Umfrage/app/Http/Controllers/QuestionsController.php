<?php namespace App\Http\Controllers;

use App\Models\Question;
use App\Models\Answer;

class QuestionsController extends Controller {

    public function getQuestions() {
        $user = \Auth::user();
       	$questions = Question::all();
       	$averages = array();
       	if ($user->answered)
       		$averages = \DB::select('select cast(round(avg(value) / 25) * 25 as int) as avg from answers group by question_id');
        return view('survey', ['questions' => $questions, 'user' => $user, 'answers' => $averages]);
    }

    

}
