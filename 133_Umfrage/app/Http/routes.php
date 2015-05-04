<?php

/*
|--------------------------------------------------------------------------
| Application Routes
|--------------------------------------------------------------------------
|
| Here is where you can register all of the routes for an application.
| It's a breeze. Simply tell Laravel the URIs it should respond to
| and give it the controller to call when that URI is requested.
|
*/
$namespace = 'App\Http\Controllers'; // We don't want to specify the full namespace by each route.
$app->group(['middleware' => 'auth', 'namespace' => $namespace], function() use ($app) { //All the routes in this group run through the "auth" middleware.
	$app->get('/', 'QuestionsController@getQuestions');
	$app->post('/save', 'AnswersController@postAnswers');
    $app->get('/results', 'AnswersController@getResults');
});

$app->group(['namespace' => $namespace], function() use ($app) {
	$app->get('/login', 'UsersController@getLogin');
	$app->post('/login', 'UsersController@postLogin');
	$app->get('/logout', 'UsersController@getLogout');
	$app->get('/register', 'UsersController@getRegister');
	$app->post('/register', 'UsersController@postRegister');
});
