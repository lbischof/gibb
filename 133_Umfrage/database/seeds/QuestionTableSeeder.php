<?php
use Illuminate\Database\Seeder;
use Illuminate\Database\Eloquent\Model;
use App\Models\Question;
class QuestionTableSeeder extends Seeder {
    /**
     * Run the database seeds.
     *
     * @return void
     */
     public function run()
     {
        Question::create([
            'text' => 'How do you feel about sample questions?'
        ]);
        Question::create([
            'text' => 'Just a test?'
        ]);
    }
}