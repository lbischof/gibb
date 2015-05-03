<?php namespace App\Http\Controllers;

class UsersController extends Controller {

    public function getLogin() {
        $message = \Session::get('message');
		$email = \Session::get('email');
		return view('login', ['message' => $message, 'email' => $email]);
    }
    
    public function postLogin() {
    	$email = \Request::input('email');
		$password = \Request::input('password');
	    if (\Auth::attempt(['email' => $email, 'password' => $password])) {
	        return redirect('/');
	    } else {
	    	return redirect('login')->with('message', 'Login failed')->with('email', $email);
	    }
    }

    public function getRegister() {
    	return view('register');
    }

    public function postRegister() {
        $rules = array(
            
        );

        $validator = \Validator::make(\Request::all(), $rules);
        error_log($validator->fails());

    	/*$user = new User(\Request::all());
    	$user->password = bcrypt($user->password);
    	$user->save();*/
    }

    public function getLogout() {
    	\Auth::logout();
		return redirect('login');
    }

}