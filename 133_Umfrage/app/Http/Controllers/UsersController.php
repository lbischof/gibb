<?php namespace App\Http\Controllers;

use App\Models\User;

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
            'email'             => 'required|email|unique:users',
            'password'          => 'required|min:6',
            'password_confirm'  => 'required|same:password'
        );

        $validator = \Validator::make(\Request::all(), $rules);
        if ($validator->fails()) {
            return redirect('register');
        } else {
            $user = new User(\Request::all());
            $user->password = bcrypt($user->password);
            $user->save();
            return redirect('login')->with('email', \Request::input('email'));
        }

    }

    public function getLogout() {
    	\Auth::logout();
		return redirect('login');
    }

}