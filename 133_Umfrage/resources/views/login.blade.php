@extends('layouts.master')

@section('title', 'Login')

@section('content')
    <div class="card-panel">
        @if ($message)
            <div class="card-panel red white-text">        
                {{ $message }}
            </div>
        @endif
        <h1>Login</h1>
        <form action="/login" method="post">
            <div class="input-field">
              <input id="email" name="email" type="email" class="validate" value="{{ $email }}" {{ $email ? '' : 'autofocus' }} required>
              <label for="email">Email</label>
            </div>
            <div class="input-field">
              <input id="password" name="password" type="password" class="validate" {{ $email ? 'autofocus' : '' }} required>
              <label for="password">Passwort</label>
            </div>
            <button class="waves-effect waves-light btn">Login</button>
        </form>
    </div>
@stop
