<?php namespace App\Http\Controllers;

use App\Models\User;

class UsersController extends Controller {

    public function getLogin() {
        $message = \Session::get('message');
		return view('login', ['message' => $message]);
    }
    
    public function postLogin() {
    	$email = \Request::input('email');
		$password = \Request::input('password');
	    if (\Auth::attempt(['email' => $email, 'password' => $password])) {
	        return redirect('/');
	    } else {
	    	return redirect('login')->with('message', 'Login failed');
	    }
    }

    public function getRegister() {
        $errors = \Session::get('errors');
    	return view('register', [ 'errors' => $errors ]);
    }

    public function postRegister(\Illuminate\Http\Request $request) {
        $rules = [
            'email'             => 'required|email|unique:users',
            'password'          => 'required|min:8|regex:/^(?=.*\d)(?=.*[a-z])(?=.*[A-Z]).$/',
            'password_confirm'  => 'required|same:password'
        ];
        $messages = [
            'regex'             => 'Das Passwort muss Grossbuchstaben, Kleinbuchstaben und Zahlen enthalten.',
            'min'               => 'Das Passwort muss mindestens :min Zeichen lang sein.',
            'same'              => 'Die beiden Passwörter stimmen nicht überein.',
            'unique'            => 'Sie haben schon ein Konto'
        ];
        $this->validate($request, $rules, $messages);
        $user = new User(\Request::all());
        $user->password = bcrypt($user->password);
        $user->save();
        return redirect('login');
    }

    public function getLogout() {
    	\Auth::logout();
		return view('logout');
    }

}
