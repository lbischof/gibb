<!-- Stored in resources/views/layouts/master.blade.php -->

<html>
    <head>
        <title>Umfrage - @yield('title')</title>
        <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/materialize/0.96.1/css/materialize.min.css">
    </head>
    <body>
        <div class="container">
            @yield('content')
        </div>
        <script type="text/javascript" src="https://code.jquery.com/jquery-2.1.1.min.js"></script>
        <script src="https://cdnjs.cloudflare.com/ajax/libs/materialize/0.96.1/js/materialize.min.js"></script>

    </body>
</html>
