@extends('layouts.master')

@section('header') 
        <script>
            window.localStorage.clear();
			window.location = "/login"; 
        </script>
@stop