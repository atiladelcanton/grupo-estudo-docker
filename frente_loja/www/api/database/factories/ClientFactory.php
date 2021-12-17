<?php

namespace Database\Factories;

use Illuminate\Database\Eloquent\Factories\Factory;
use Illuminate\Support\Str;

class ClientFactory extends Factory
{
    public function withFaker(): \Faker\Generator
    {
        return \Faker\Factory::create('pt_BR');
    }
    /**
     * Define the model's default state.
     *
     * @return array
     */
    public function definition()
    {
        return [
            'name' => $this->faker->name(),
            'city' => $this->faker->unique()->safeEmail(),
            'street' => $this->faker->address(),
            'district' => 'Vila Nogueira'
        ];
    }


}
