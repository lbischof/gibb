<!doctype html>
<html>
    <head>
        <title>Welcome!</title>
    </head>
    <body>
        {{ $message }}
        <h1>Login</h1>
        <form action="/login" method="post">
        	<input type="text" name="email" value="{{ $email }}" {{ $email ? '' : 'autofocus' }} />
        	<input type="password" name="password" {{ $email ? 'autofocus' : '' }} />
        	<button>submit</button>
       	</form>
    </body>
</html>
