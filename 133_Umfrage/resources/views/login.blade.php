@extends('layouts.master')

@section('title', 'Login')

@section('content')
    <div class="card-panel login">
        @if ($message)
            <div class="card-panel red white-text">        
                {{ $message }}
            </div>
        @endif
        <h1>Login</h1>
        <form data-domain="true" data-persist="garlic" data-destroy="false" action="/login" method="post">
            <div class="input-field">
              <input id="email" name="email" type="email" autofocus required>
              <label class="active" for="email">Email</label>
            </div>
            <div class="input-field">
              <input id="password" name="password" type="password" required>
              <label for="password">Passwort</label>
            </div>
            <button class="waves-effect waves-light btn">Login</button>
        </form>
        <a href="/register">Noch kein Konto?</a>
    </div>
@stop
