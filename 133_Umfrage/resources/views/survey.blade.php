@extends('layouts.master')

@section('title', 'Welcome')

@section('content')
        <h1>Umfrage</h1>
        @if ($user->answered)
            <p>Danke, dass Sie sich Zeit genommen haben.</p>
        @endif
        <form action="/save" method="post">
        @foreach ($questions as $i => $question)
        	<div class="row">
        		<div class="col s7">{{ $question->text }}</div>
                <div class="col s5">
            		<input type="radio" value="0" id="0{{ $i }}" name="q[{{ $question->id }}][value]" required {{ $user->answered ? 'disabled' : '' }} {{ $question->answer == 0 && $user->answered ? 'checked' : '' }} >
                    <label for="0{{ $i }}">0</label>

            		<input type="radio" value="25" id="25{{ $i }}" name="q[{{ $question->id }}][value]" required {{ $user->answered ? 'disabled' : '' }} {{ $question->answer == 25 ? 'checked' : '' }} >
                     <label for="25{{ $i }}">25</label>

            		<input type="radio" value="75" id="75{{ $i }}" name="q[{{ $question->id }}][value]" required {{ $user->answered ? 'disabled' : '' }} {{ $question->answer == 75 ? 'checked' : '' }} >
                    <label for="75{{ $i }}">75</label>

            		<input type="radio" value="100" id="100{{ $i }}" name="q[{{ $question->id }}][value]" required {{ $user->answered ? 'disabled' : '' }} {{ $question->answer == 100 ? 'checked' : '' }} >
                    <label for="100{{ $i }}">100</label>
            		
                    <input type="radio" value="50" id="50{{ $i }}" name="q[{{ $question->id }}][value]" required {{ $user->answered ? 'disabled' : '' }} {{ $question->answer == 50 ? 'checked' : '' }} >
                    <label for="50{{ $i }}">50</label>
                </div>
        	</div>
        @endforeach
        @if (!$user->answered)
        	<button class="btn-floating btn-large waves-effect waves-light red"><i class="mdi-content-send"></i></button>
        @else
            <a href="/results">Resultate anzeigen</a>
        @endif
        </form>
@stop
