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
     public function run() {
        $questions = [
            // Essen
            [ 'text' => 'Haben Sie manchmal Mühe beim Spaghetti essen?'],
            [ 'text' => 'Haben Sie das Steak gerne rare?'],
            [ 'text' => 'Brauchen Sie ein gemütliches Frühstück?'],
            [ 'text' => 'Trinken Sie in jeder Pause einen Kaffee?'],
            // Gesundheit
            [ 'text' => 'Machen Sie oft Sport?'],
            [ 'text' => 'Arbeiten Sie im Büro?'],
            [ 'text' => 'Besaufen Sie sich gerne regelmässig?'],
            [ 'text' => 'Rauchen Sie?'],
            // Digital
            [ 'text' => 'Schauen Sie darauf, dass Daten nicht nach Amerika gelangen?'],
            [ 'text' => 'Kennen Sie Linux?'],
            [ 'text' => 'Benutzen Sie Internet Explorer?'],
            [ 'text' => 'Könnten Sie eine eigene Website erstellen?'],
            [ 'text' => 'Benutzen Sie oft ein Navigationsgerät?'],
            // Kinder
            [ 'text' => 'Haben Sie Kinder gerne?'],
            [ 'text' => 'Einen Nachmittag für die Kinder freinehmen?'],
            [ 'text' => 'Schauen Sie Kinderfernsehen?'],
            // Sport
            [ 'text' => 'Spielen Sie in einer Sportmannschaft?'],
            [ 'text' => 'Schauen Sie Sport im Fernsehen?'],
            [ 'text' => 'Ist Sport ein wichtiger Bestandteil Ihres Lebens?'],
            [ 'text' => 'Fahren Sie oft mit dem Fahrrad?']
        ];
        Question::insert($questions);
    }
}