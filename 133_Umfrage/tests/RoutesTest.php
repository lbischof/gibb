<?php

class RoutesTest extends TestCase {

    public function __construct() {
        $this->user = Mockery::mock('Eloquent', 'App\Models\User');
        $this->user->shouldReceive('getAttribute')->with('score')->andReturn(600); 
    }

    public function test_Login_Page() {
        $response = $this->call('GET', '/login');

        $this->assertResponseOk();
    }    

    public function test_Register_Page() {
        $response = $this->call('GET', '/register');

        $this->assertResponseOk();
    }

    public function test_Index_Page() {
        $response = $this->call('GET', '/');

        $this->assertResponseStatus(302); // Not logged in
        $this->assertRedirectedTo('login');
    }

    public function test_Results_Page() {
        $response = $this->call('GET', '/results');

        $this->assertResponseStatus(302); // Not logged in
        $this->assertRedirectedTo('login');
    }   

    public function test_Index_Page_Logged_In() {
        Auth::shouldReceive('check')->andReturn(true); // Logged in
        Auth::shouldReceive('user')->once()->andReturn($this->user);
        $this->user->shouldReceive('getAttribute')->with('answered')->andReturn(false); 
        $response = $this->call('GET', '/');

        $this->assertResponseOk();
        $this->assertViewHas('user', $this->user);
        $this->assertViewHas('questions');
    }

    public function test_Results_Page_Logged_In_Answered_False() {
        Auth::shouldReceive('check')->andReturn(true); // Logged in
        Auth::shouldReceive('user')->once()->andReturn($this->user);
        $this->user->shouldReceive('getAttribute')->with('answered')->andReturn(false); 
        $response = $this->call('GET', '/results');

        $this->assertResponseStatus(302); // Redirect to survey if user hasn't answered
        $this->assertRedirectedTo('/');
    }

    public function test_Results_Page_Logged_In_Answered() {
        Auth::shouldReceive('check')->andReturn(true); // Logged in
        Auth::shouldReceive('user')->once()->andReturn($this->user);
        $this->user->shouldReceive('getAttribute')->with('answered')->andReturn(true);
        $response = $this->call('GET', '/results');

        $this->assertResponseOk();
        $this->assertViewHas('users');
    }
}
