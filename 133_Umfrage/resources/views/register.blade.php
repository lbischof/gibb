<!doctype html>
<html>
    <head>
        <title>Welcome!</title>
    </head>
    <body>
        @if ($errors)
        <div class="alert alert-danger">
            @foreach ($errors->all() as $error)
                {{ $error }}<br>        
            @endforeach
        </div>
        @endif
        <h1>Register</h1>
        <form action="/register" method="post">
        	<input type="email" name="email" autofocus/>
        	<input type="password" name="password" />
            <input type="password" name="password_confirm" />
        	<button>submit</button>
       	</form>
    </body>
</html>