<?php
use Illuminate\Database\Seeder;
use Illuminate\Database\Eloquent\Model;
use App\Models\User;
class UserTableSeeder extends Seeder {
    /**
     * Run the database seeds.
     *
     * @return void
     */
     public function run()
     {
         User::create([
             'name' => 'Lorenz Bischof',
             'email' => 'lorenzbischof@gmail.com',
             'password' => '$2y$10$YBVd1.1Nveb6EQKxjr6jQe6R29jWbJCk7.m4L.O6a9ybCmvRQBj4O', //123secret 
             'score' => 150
         ]);
        User::create([
            'name' => 'Art Venere',
            'email' => 'art@venere.org',
            'password' => '$2y$10$YBVd1.1Nveb6EQKxjr6jQe6R29jWbJCk7.m4L.O6a9ybCmvRQBj4O', //123secret
            'score' => 200
        ]);
        User::create([
            'name' => 'Mattie Poquette',
            'email' => 'mattie@aol.com',
            'password' => '$2y$10$YBVd1.1Nveb6EQKxjr6jQe6R29jWbJCk7.m4L.O6a9ybCmvRQBj4O', //123secret
            'score' => 50
        ]);
        User::create([
            'name' => 'Willow Kusko',
            'email' => 'wkusko@yahoo.com',
            'password' => '$2y$10$YBVd1.1Nveb6EQKxjr6jQe6R29jWbJCk7.m4L.O6a9ybCmvRQBj4O', //123secret
            'score' => 75
        ]);
        User::create([
            'name' => 'Alishia Sergi',
            'email' => 'asergi@gmail.com',
            'password' => '$2y$10$YBVd1.1Nveb6EQKxjr6jQe6R29jWbJCk7.m4L.O6a9ybCmvRQBj4O', //123secret
            'score' => 175
        ]);
        User::create([
            'name' => 'Jose Stockholm',
            'email' => 'jose@yahoo.com',
            'password' => '$2y$10$YBVd1.1Nveb6EQKxjr6jQe6R29jWbJCk7.m4L.O6a9ybCmvRQBj4O', //123secret
            'score' => 25
        ]);
        User::create([
            'name' => 'Valentine Gillian',
            'email' => 'valentine_gillian@gmail.com',
            'password' => '$2y$10$YBVd1.1Nveb6EQKxjr6jQe6R29jWbJCk7.m4L.O6a9ybCmvRQBj4O' //123secret
        ]);
    }
}
