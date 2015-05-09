<!-- Stored in resources/views/layouts/master.blade.php -->

<html>
    <head>
        <title>Umfrage - @yield('title')</title>
        <meta charset="UTF-8">
        @yield('header')
        <meta name="viewport" content="width=device-width, initial-scale=1">
        <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/materialize/0.96.1/css/materialize.min.css">
        <link rel="stylesheet" href="styles.css">
    </head>
    <body>
        {!! Auth::check() ? '<a href="/logout">Logout</a>' : '' !!}
        <div class="container">
            @yield('content')
        </div>
        <script type="text/javascript" src="https://code.jquery.com/jquery-2.1.1.min.js"></script>
        <script src="https://cdnjs.cloudflare.com/ajax/libs/materialize/0.96.1/js/materialize.min.js"></script>
        <script src="https://cdnjs.cloudflare.com/ajax/libs/garlic.js/1.2.2/garlic.min.js"></script>
        <script src="script.js"></script>
    </body>
</html>
