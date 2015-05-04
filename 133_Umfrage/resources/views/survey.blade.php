@extends('layouts.master')

@section('title', 'Welcome')

@section('header') 
    @if ($user->answered)
        <script>
            if (!window.localStorage.getItem('garlic:'+window.location.hostname+window.location.pathname+'>form>input.q[0][value]'))
                window.location = "/results"; // If the answers aren't in localstorage anymore.
        </script>
    @endif
@stop

@section('content')
    <div class="card-panel">
        <h1>{{ $user->answered ? 'Vielen Dank' : 'Umfrage' }}</h1>
        
        <form data-persist="garlic" data-destroy="false" id="survey" action="/save" method="post">
            <div class="row">
                <div class="col l6">
                    @if ($user->answered)
                        <a href="/results">Auswertung anzeigen</a>
                    @endif
                    <span class="hidden">Offset</span>
                </div>
                <div class="col m12 l6 header">
                    <span>nein</span>
                    <span>eher nein</span>
                    <span>eher ja</span>
                    <span>ja</span>
                    <span>keine Meinung</span>
                </div>
            </div>
        @foreach ($questions as $i => $question)
        	<div class="row">
        		<div class="col m12 l6">{{ $question->text }}</div>
                <input type="hidden" value="{{ $question->id }}" name="q[{{ $i }}][question_id]">
                <div class="col m12 l6 answer">
            		<input type="radio" value="0" id="0{{ $i }}" name="q[{{ $i }}][value]" {{ $user->answered ? 'disabled' : '' }} >
                    <label for="0{{ $i }}"></label>

            		<input type="radio" value="25" id="25{{ $i }}" name="q[{{ $i }}][value]" {{ $user->answered ? 'disabled' : '' }} >
                     <label for="25{{ $i }}"></label>

            		<input type="radio" value="75" id="75{{ $i }}" name="q[{{ $i }}][value]" {{ $user->answered ? 'disabled' : '' }} >
                    <label for="75{{ $i }}"></label>

            		<input type="radio" value="100" id="100{{ $i }}" name="q[{{ $i }}][value]" {{ $user->answered ? 'disabled' : '' }} >
                    <label for="100{{ $i }}"></label>
            		
                    <input type="radio" value="50" id="50{{ $i }}" name="q[{{ $i }}][value]" {{ $user->answered ? 'disabled' : '' }} >
                    <label for="50{{ $i }}"></label>
                </div>
        	</div>
        @endforeach
        @if (!$user->answered)
        	<button class="btn-floating btn-large waves-effect waves-light teal"><i class="mdi-content-send"></i></button>
        @else
            <a href="/results">Auswertung anzeigen</a>
        @endif
        </form>
    </div>
@stop
