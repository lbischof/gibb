<?php namespace App\Http\Controllers;

use App\Models\Question;

class QuestionsController extends Controller {

    public function getQuestions() {
        $user = \Auth::user();
        if ($user->answered) 
            return redirect('results');	
        //$questions = \DB::select('select *, value as answer from questions join answers on question_id = questions.id where user_id = ?', [$user->id]);
        
        $questions = Question::all();
        return view('survey', ['questions' => $questions, 'user' => $user]);
    }

}
