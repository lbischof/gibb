<!doctype html>
<html>
    <head>
        <title>Welcome!</title>
    </head>
    <body>
        <h1>Hello</h1>
        <form action="/save" method="post">
        @foreach ($questions as $key => $question)
        	<div>
        		<p>{{ $question->text }}</p>
        		<input type="hidden" value="{{ $question->id }}" name="q[{{ $key }}][question_id]">
        		<input type="hidden" value="{{ $user->id }}" name="q[{{ $key }}][user_id]">
        		<input type="radio" value="0" name="q[{{ $key }}][value]" required {{ $user->answered ? 'disabled' : '' }} {{ $question->answer == 0 && $user->answered ? 'checked' : '' }} >
        		<input type="radio" value="25" name="q[{{ $key }}][value]" required {{ $user->answered ? 'disabled' : '' }} {{ $question->answer == 25 ? 'checked' : '' }} >
        		<input type="radio" value="75" name="q[{{ $key }}][value]" required {{ $user->answered ? 'disabled' : '' }} {{ $question->answer == 75 ? 'checked' : '' }} >
        		<input type="radio" value="100" name="q[{{ $key}}][value]" required {{ $user->answered ? 'disabled' : '' }} {{ $question->answer == 100 ? 'checked' : '' }} >
        		<input type="radio" value="50" name="q[{{ $key }}][value]" required {{ $user->answered ? 'disabled' : '' }} {{ $question->answer == 50 ? 'checked' : '' }} >
        	</div>
        @endforeach
        @if (!$user->answered)
        	<button>submit</button>
        @endif
        </form>
    </body>
</html>
