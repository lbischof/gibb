@extends('layouts.master')

@section('title', 'Register')

@section('content')
        <div class="card-panel register">
            @if ($errors)
            <div class="card-panel red white-text">
                @foreach ($errors->all() as $error)
                    <div class="error">
                        {{ $error }}   
                    </div> 
                @endforeach
            </div>
            @endif
            <h1>Register</h1>
            <form data-domain="true" data-persist="garlic" data-destroy="false" action="/register" method="post">
                <div class="input-field">
                  <input id="email" name="email" type="email" required autofocus>
                  <label class="active" for="email">Email</label>
                </div>
                <div class="input-field">
                  <input id="password" name="password" type="password" required>
                  <label for="password">Passwort</label>
                </div>
            	<div class="input-field">
                  <input id="password_confirm" name="password_confirm" type="password" required>
                  <label for="password_confirm">Passwort bestätigen</label>
                </div>
                <div class="input-field">
                    <input id="name" name="name" type="text" data-storage="false" required>
                    <label for="name">Name</label>
                </div>
            	<button class="waves-effect waves-light btn">Register</button>
           	</form>
            <a href="/login">Schon registriert?</a>
        </div>
@stop
