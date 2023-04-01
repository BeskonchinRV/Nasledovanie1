using System;
using System.Collections.Generic;
using System.Text;

namespace Farm
{


    public class Cat
    {
        public string name { get; set; }
        public int hunger { get; set; }


        public Cat(string name, int hunger)
        {
            this.name = name;
            this.hunger = hunger;
        }

        public void Meow()
        {
            Console.WriteLine("meow meow!");
        }
        public void Niam(Eat eat, Cat cat)
        {

            Console.WriteLine($"{name} eats {eat.Type}. {eat.satiety} hunger.");
            hunger = hunger + eat.satiety;
        }
        public void Play()
        {
            hunger = hunger - 5;
            Console.WriteLine("Cat is playing...  Hunger is " + hunger);
        }
        public void Run()
        {
            hunger = hunger - 10;
            Console.WriteLine("Cat is runing... Hunger is " + hunger);
        }
        public void Sleep()
        {
            Random rnd = new Random();
            hunger = hunger - rnd.Next(1, 5);
            Console.WriteLine("Cat is sleeping... Hunger is " + hunger);


        }
        public void Print()
        {
            Console.WriteLine($"Котик по имени {name} и его сытость {hunger}");
        }


    }
}
