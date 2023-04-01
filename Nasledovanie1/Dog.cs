using System;

namespace Farm
{
    class Dog
    {
        public string name { get; set; }
        public int hunger { get; set; }
        Eat eat = new Eat("meal", 15);
        public Dog(string name, int hunger)
        {
            this.name = name;
            this.hunger = hunger;
        }
        public void Bark()
        {
            Console.WriteLine("awawawaw!");
        }
        public void Niam(Eat eat, Dog dog)
        {

            Console.WriteLine($"{name} eats {eat.Type}. {eat.satiety} hp.");
            hunger = hunger + eat.satiety;
        }
        public void Play()
        {
            hunger = hunger - 5;
            Console.WriteLine("Dog is playing...  Hunger is " + hunger);
        }
        public void Run()
        {
            hunger = hunger - 10;
            Console.WriteLine("Dog is runing... Hunger is " + hunger);
        }
        public void Sleep()
        {
            Random rnd = new Random();
            hunger = hunger - rnd.Next(2, 4);


        }
        public void Print()
        {
            Console.WriteLine($"Собака по имени {name} и его сытость {hunger}");
        }
    }
}