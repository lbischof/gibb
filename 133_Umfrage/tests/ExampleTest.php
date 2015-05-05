<?php

class ExampleTest extends TestCase {

    public function testGetHomepage() {
        $response = $this->call('GET', '/');

        $this->assertResponseStatus(302);
        //$this->assertRedirectedToAction('QuestionsController@getQuestions');

        $this->assertRedirectedTo('login');
    }
    public function testGetResults() {
        $response = $this->call('GET', '/results');

        $this->assertResponseStatus(302);
        //$this->assertRedirectedTo('login');
    }   
    //public function testControllerHomepage
     

}
