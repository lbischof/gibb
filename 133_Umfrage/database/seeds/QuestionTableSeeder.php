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
            [ 'text' => 'Benutzen Sie manchmal Internet Explorer?'],
            [ 'text' => 'Könnten Sie eine eigene Website erstellen?'],
            [ 'text' => 'Benutzen Sie oft ein Navigationsgerät?'],
            // Kinder
            [ 'text' => 'Würden Sie gerne Kinder haben?'],
            [ 'text' => 'Einen Nachmittag für die Kinder freinehmen?'],
            [ 'text' => ''],
            [ 'text' => ' '],
            [ 'text' => ' '],
            [ 'text' => ' '],
            [ 'text' => ' '],
            [ 'text' => ' '],
            [ 'text' => ' '],
            [ 'text' => ' '],
            [ 'text' => ' '],
        ];
        Question::insert($questions);
    }
}