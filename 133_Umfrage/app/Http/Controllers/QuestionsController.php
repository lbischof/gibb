<?php namespace App\Http\Controllers;

use App\Models\Question;

class QuestionsController extends Controller {

    public function getQuestions() {
        $user = \Auth::user();
        $user_hash = \Session::get('user_hash');
        if ($user->answered && !$user_hash) 
            return redirect('results');	

        if ($user->answered && $user_hash)
        	$questions = \DB::select('select *, value as answer from questions join answers on question_id = questions.id where user_hash = ?', [$user_hash]);
        else 
        	$questions = Question::all();

        return view('survey', ['questions' => $questions, 'user' => $user ]);
    }

}
