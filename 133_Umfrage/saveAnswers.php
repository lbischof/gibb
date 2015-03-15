<?php
$json = file_get_contents('php://input');
$answers = fopen("answers.json", "w") or die("Unable to open file!");
fwrite($answers, $json);
fclose($answers);
