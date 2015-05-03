@extends('layouts.master')

@section('title', 'Welcome')

@section('content')
        <h1>Umfrage</h1>
        @if ($user->answered)
            <p>Danke, dass Sie sich Zeit genommen haben.</p>
        @endif
        <form action="/save" method="post">
        @foreach ($questions as $key => $question)
        	<div class="row">
        		<div class="col s7">{{ $question->text }}</div>
                <div class="col s5">
            		<input type="hidden" value="{{ $question->id }}" name="q[{{ $key }}][question_id]">
            		<input type="radio" value="0" id="a0{{ $key }}" name="q[{{ $key }}][value]" required {{ $question->answer == 0 && $user->answered ? 'checked' : '' }} >
                    <label for="a0{{ $key }}">0</label>

            		<input type="radio" value="25" id="a25{{ $key }}" name="q[{{ $key }}][value]" required {{ $user->answered ? 'disabled' : '' }} {{ $question->answer == 25 ? 'checked' : '' }} >
                     <label for="a25{{ $key }}">25</label>

            		<input type="radio" value="75" id="a75{{ $key }}" name="q[{{ $key }}][value]" required {{ $user->answered ? 'disabled' : '' }} {{ $question->answer == 75 ? 'checked' : '' }} >
                    <label for="a75{{ $key }}">75</label>

            		<input type="radio" value="100" id="a100{{ $key }}" name="q[{{ $key}}][value]" required {{ $user->answered ? 'disabled' : '' }} {{ $question->answer == 100 ? 'checked' : '' }} >
                    <label for="a100{{ $key }}">100</label>
            		
                    <input type="radio" value="50" id="a50{{ $key }}" name="q[{{ $key }}][value]" required {{ $user->answered ? 'disabled' : '' }} {{ $question->answer == 50 ? 'checked' : '' }} >
                    <label for="a50{{ $key }}">50</label>
                </div>
        	</div>
        @endforeach
        @if (!$user->answered)
        	<button class="btn-floating btn-large waves-effect waves-light red"><i class="mdi-content-send"></i></button>
        @endif
        </form>
@stop
