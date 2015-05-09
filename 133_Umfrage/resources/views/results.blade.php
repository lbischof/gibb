@extends('layouts.master')

@section('title', 'Resultate')

@section('content')
    <div class="card-panel resultate">
        <h1>Auswertung</h1>
        <div class="table">

        <div class="row">
                <div>
                    <a href="/">Fragen anzeigen</a>
                </div>
                <div>
                    Übereinstimmung
                </div>
            </div>
        @foreach ($users as $user)
        	<div class="row">
        		<div>
                    {{ $user->id }} {{ $user->name }} {{ $user->email }}                   
                </div>
                <div class="percentage">
                <span style="width: {{ $user->percent }}%">{{ $user->percent }}%</span>
                </div>
        	</div>
        @endforeach
        </div>
    </div>
@stop
