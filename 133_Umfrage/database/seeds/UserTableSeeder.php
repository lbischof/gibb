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
             'password' => '$2y$10$YBVd1.1Nveb6EQKxjr6jQe6R29jWbJCk7.m4L.O6a9ybCmvRQBj4O',
             'score' => 150
         ]);
        User::create([
            'name' => 'Taylor Otwell',
            'email' => 'taylorotwell1@gmail.com',
            'password' => 'greatsecret',
            'score' => 400
        ]);
        User::create([
            'name' => 'Some Name',
            'email' => 'taylorotwell2@gmail.com',
            'password' => 'greatsecret',
            'score' => 200
        ]);
        User::create([
            'name' => 'Max Fritz',
            'email' => 'taylorotwell3@gmail.com',
            'password' => 'greatsecret',
            'score' => 50
        ]);
    }
}
