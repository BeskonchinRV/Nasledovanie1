using System;
using System.Collections.Generic;
using System.Text;

namespace Farm
{
    class Horse
    {
        public string name { get; set; }
        public int hunger { get; set; }
        Eat eat = new Eat("apple", 13);
        public Horse(string name, int hunger)
        {
            this.name = name;
            this.hunger = hunger;

        }
        public void Sound()
        {
            Console.WriteLine("brrrr!");
        }
        public void Niam(Eat eat, Horse horse)
        {

            Console.WriteLine($"{name} eats {eat.Type}. {eat.satiety} hp.");
            hunger = hunger + eat.satiety;
        }
        public void Play()
        {
            hunger = hunger - 5;
            Console.WriteLine("Horse is playing...  Hunger is " + hunger);
        }
        public void Run()
        {
            hunger = hunger - 10;
            Console.WriteLine("Horse is runing... Hunger is " + hunger);
        }
        public void Sleep()
        {
            Random rnd = new Random();
            hunger = hunger - rnd.Next(2, 4);

        }
        public void Print()
        {
            Console.WriteLine($"Лошадь по имени {name} и его сытость {hunger}");
        }
    }
}
