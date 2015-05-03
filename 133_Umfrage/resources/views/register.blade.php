@extends('layouts.master')

@section('title', 'Register')

@section('content')
        <div class="card-panel">
            @if ($errors)
            <div class="card-panel red white-text">
                @foreach ($errors->all() as $error)
                    {{ $error }}<br>        
                @endforeach
            </div>
            @endif
            <h1>Register</h1>
            <form action="/register" method="post">
                <div class="input-field">
                  <input id="email" type="text" class="validate">
                  <label for="email">Email</label>
                </div>
                <div class="input-field">
                  <input id="password" type="text" class="validate">
                  <label for="password">Passwort</label>
                </div>
            	<div class="input-field">
                  <input id="password_confirm" type="text" class="validate">
                  <label for="password_confirm">Passwort</label>
                </div>
                <div class="input-field">
                    <input id="name" type="text" class="validate">
                    <label for="name">Name</label>
                </div>
            	<button class="waves-effect waves-light btn">Register</button>
           	</form>
        </div>
@stop
