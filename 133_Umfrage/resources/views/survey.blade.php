@extends('layouts.master')

@section('title', 'Welcome')

@section('content')
    <div class="card-panel">
    	<div class="table">
        <h1>{{ $user->answered ? 'Vielen Dank' : 'Umfrage' }}</h1>
        
        <form data-persist="garlic" data-destroy="false" id="survey" action="/save" method="post">
            <div class="row">
                <div>
                    @if ($user->answered)
                        <a href="/results">Auswertung anzeigen</a>
                    @endif
                </div>
                <div>nein</div>
                <div>eher nein</div>
                <div>eher ja</div>
                <div>ja</div>
                <div>keine Meinung</div>
            </div>
        	@foreach ($questions as $i => $question)
	            <input type="hidden" value="{{ $question->id }}" name="q[{{ $i }}][question_id]">
	        	<div class="row avg{{ $answers[$i]->avg or ''}}">
	        		<div>{{ $question->text }}</div>
	                <div>
	            		<input type="radio" value="0" id="0{{ $i }}" name="q[{{ $i }}][value]" {{ $user->answered ? 'disabled' : '' }} >
	                    <label for="0{{ $i }}"></label>
	                </div>
	                <div>
	            		<input type="radio" value="25" id="25{{ $i }}" name="q[{{ $i }}][value]" {{ $user->answered ? 'disabled' : '' }} >
	                    <label for="25{{ $i }}"></label>
	                </div>
	                <div>
	            		<input type="radio" value="75" id="75{{ $i }}" name="q[{{ $i }}][value]" {{ $user->answered ? 'disabled' : '' }} >
	                    <label for="75{{ $i }}"></label>
	                </div>
	                <div>
	            		<input type="radio" value="100" id="100{{ $i }}" name="q[{{ $i }}][value]" {{ $user->answered ? 'disabled' : '' }} >
	                    <label for="100{{ $i }}"></label>
	            	</div>
	            	<div>
	                    <input type="radio" value="50" id="50{{ $i }}" name="q[{{ $i }}][value]" {{ $user->answered ? 'disabled' : '' }} >
	                    <label for="50{{ $i }}"></label>
	                </div>

	        	</div>
        	@endforeach
	        @if (!$user->answered)
	        	<button class="btn-floating btn-large waves-effect waves-light teal"><i class="mdi-content-send"></i></button>
	        @endif
        </form>
        </div>
    </div>
@stop
