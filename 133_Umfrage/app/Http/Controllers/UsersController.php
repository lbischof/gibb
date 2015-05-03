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
        $errors = \Session::get('errors');
    	return view('register', [ 'errors' => $errors ]);
    }

    public function postRegister(\Illuminate\Http\Request $request) {
        $rules = array(
            'email'             => 'required|email|unique:users',
            'password'          => 'required|min:6',
            'password_confirm'  => 'required|same:password'
        );
        $this->validate($request, $rules);
        
        $user = new User(\Request::all());
        $user->password = bcrypt($user->password);
        $user->save();
        return redirect('login')->with('email', \Request::input('email'));
    }

    public function getLogout() {
        \Session::forget('user_hash');
    	\Auth::logout();
		return redirect('login');
    }

}
