using System;

namespace Farm
{
    class Controller
    {
        public static void Game()
        {
            Console.WriteLine("Здравствуй! Выбери животное,которое хочешь выбрать? \n1)Кот \n2)Пёс \n3)Лошадь");
            int choice = int.Parse(Console.ReadLine());
            while (true)
            {
                switch (choice)
                {
                    case 1:
                        Eat eat = new Eat("kitekat", 15);
                        Cat cat = new Cat("", 35);

                        Console.WriteLine("Введи имя кота: ");
                        cat.name = Console.ReadLine();
                        Console.WriteLine($"Кота зовут {cat.name} и его сытость {cat.hunger}\n");
                        while (true)
                        {
                            Console.WriteLine("Что хотите сделать \n1)Голос \n2)Кушать \n3)Спать \n4)Информация \n5)Выход");
                            int a = int.Parse(Console.ReadLine());
                            if (a == 1)
                            {
                                cat.Meow();
                            }
                            if (a == 2)
                            {
                                cat.Niam(eat, cat);
                            }
                            if (a == 3)
                            {
                                cat.Sleep();
                                if (cat.hunger < 5)
                                {
                                    Console.WriteLine("Кот умер =((((((");
                                    break;

                                }
                            }
                            if (a == 4)
                            {
                                cat.Print();
                            }
                            if (a == 5)
                            {
                                break;
                            }
                            continue;
                        }
                        break;
                    case 2:
                        Eat eat1 = new Eat("Chappi", 20);
                        Dog dog = new Dog("", 45);

                        Console.WriteLine("Введи имя пса: ");
                        dog.name = Console.ReadLine();
                        Console.WriteLine($"Собаку зовут {dog.name} и его сытость {dog.hunger}\n");
                        while (true)
                        {
                            Console.WriteLine("Что хотите сделать \n1)Голос \n2)Кушать \n3)Спать \n4)Информация \n5)Выход");
                            int a = int.Parse(Console.ReadLine());
                            if (a == 1)
                            {
                                dog.Bark();
                            }
                            if (a == 2)
                            {
                                dog.Niam(eat1, dog);
                            }
                            if (a == 3)
                            {
                                dog.Sleep();
                                if (dog.hunger < 5)
                                {
                                    Console.WriteLine("Пес откинулся =((((((");
                                    break;

                                }
                            }
                            if (a == 4)
                            {
                                dog.Print();
                            }
                            if (a == 5)
                            {
                                break;
                            }
                            continue;
                        }
                        break;
                    case 3:
                        Eat eat2 = new Eat("Seno", 20);
                        Horse horse = new Horse("", 55);

                        Console.WriteLine("Введи имя лошади: ");
                        horse.name = Console.ReadLine();
                        Console.WriteLine($"Лошадь зовут {horse.name} и его сытость {horse.hunger}\n");
                        while (true)
                        {
                            Console.WriteLine("Что хотите сделать \n1)Голос \n2)Кушать \n3)Спать \n4)Информация \n5)Выход");
                            int a = int.Parse(Console.ReadLine());
                            if (a == 1)
                            {
                                horse.Sound();
                            }
                            if (a == 2)
                            {
                                horse.Niam(eat2, horse);
                            }
                            if (a == 3)
                            {
                                horse.Play();
                                if (horse.hunger < 5)
                                {
                                    Console.WriteLine("Horse died =((((((");
                                    break;

                                }
                            }
                            if (a == 4)
                            {
                                horse.Run();
                                if (horse.hunger < 5)
                                {
                                    Console.WriteLine("Horse died =((((((");
                                    break;

                                }
                            }
                            if (a == 5)
                            {
                                horse.Sleep();
                                if (horse.hunger < 5)
                                {
                                    Console.WriteLine("Horse died =((((((");
                                    break;

                                }
                            }
                            if (a == 6)
                            {
                                horse.Print();
                            }
                            if (a == 7)
                            {
                                break;
                            }
                            continue;
                        }
                        break;



                    default:
                        break;
                }
                break;
            }
        }
    }
}