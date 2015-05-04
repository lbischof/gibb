@extends('layouts.master')

@section('title', 'Resultate')

@section('content')
    <div class="card-panel resultate">
        <h1>Resultate</h1>

        <div class="row">
                <div class="col s7">
                    @if ($user_hash)
                        <a href="/">Eigene Antworten anzeigen</a>
                    @endif               
                </div>
                <div class="col s5">
                    Übereinstimmung
                </div>
            </div>
        @foreach ($users as $user)
        	<div class="row">
        		<div class="col s7">
                    {{ $user->id }} {{ $user->name }} {{ $user->email }}                   
                </div>
                <div class="col s5 percentage">
                <span style="width: {{ $user->percent }}%">{{ $user->percent }}%</span>
                </div>
        	</div>
        @endforeach
        @if ($user_hash)
            <a href="/">Eigene Antworten anzeigen</a>
        @endif
    </div>
@stop
