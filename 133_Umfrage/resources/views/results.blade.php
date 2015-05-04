@extends('layouts.master')

@section('title', 'Resultate')

@section('content')
    <div class="card-panel resultate">
        <h1>Auswertung</h1>

        <div class="row">
                <div class="col s6">
                    <a href="/" class="showAnswers">Eigene Antworten anzeigen</a>
                </div>
                <div class="col s6">
                    Übereinstimmung
                </div>
            </div>
        @foreach ($users as $user)
        	<div class="row">
        		<div class="col s6">
                    {{ $user->id }} {{ $user->name }} {{ $user->email }}                   
                </div>
                <div class="col s6 percentage">
                <span style="width: {{ $user->percent }}%">{{ $user->percent }}%</span>
                </div>
        	</div>
        @endforeach
        <a href="/" class="showAnswers">Eigene Antworten anzeigen</a>
    </div>
@stop
