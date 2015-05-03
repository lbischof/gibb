@extends('layouts.master')

@section('title', 'Resultate')

@section('content')
        <h1>Resultate</h1>
        @foreach ($users as $user)
        	<div class="row">
        		<div class="col s7">
                    {{ $user->email }}                   
                </div>
                <div class="col s5">
                    {{ $user->score }}
                </div>
        	</div>
        @endforeach
@stop
