using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumaneSociety
{
    class Shelter
    {
        int type;
        bool animaladd = true;
        List<Dog> listdogs = new List<Dog>();
        List<Cat> listcats = new List<Cat>();
        List<Rabbit> listrabbits = new List<Rabbit>();
        List<Bird> listbirds = new List<Bird>();


        private ConsoleKey ObtainNewAnimal()
        {
            Console.WriteLine("What type of animal is this?");
            Console.WriteLine("1-Dog, 2-Cat, 3-Rabbit, 4-Bird, ESC-Exit");
            ConsoleKey key = Console.ReadKey(true).Key;
            if (key == ConsoleKey.Escape)
            {
                Environment.Exit(0);
            }
            return key;
        }

        private void ConvertKeyType(ConsoleKey key)
        {
            if (key == ConsoleKey.D1 || key == ConsoleKey.NumPad1)
            {
                type = 1;
                Dog dogs = new Dog();
                dogs.GenerateNewAnimal();
                listdogs.Add(dogs);
                animaladd = true;
            }
            else if (key == ConsoleKey.D2 || key == ConsoleKey.NumPad2)
            {
                type = 2;
                Cat cats = new Cat();
                cats.GenerateNewAnimal();
                listcats.Add(cats);
                animaladd = true;
            }
            else if (key == ConsoleKey.D3 || key == ConsoleKey.NumPad3)
            {
                type = 3;
                Rabbit rabbits = new Rabbit();
                rabbits.GenerateNewAnimal();
                listrabbits.Add(rabbits);
                animaladd = true;
            }
            else if (key == ConsoleKey.D4 || key == ConsoleKey.NumPad4)
            {
                type = 4;
                Bird birds = new Bird();
                birds.GenerateNewAnimal();
                listbirds.Add(birds);
                animaladd = true;
            }
            else
            {
                Console.WriteLine("Invalid Entry\n");
                animaladd = false;
            }
        } 


        public void RunProgram()
        {
            while (animaladd == true)
            {
                ConsoleKey key = ObtainNewAnimal();
                ConvertKeyType(key);
                foreach (Dog animal in listdogs)
                {
                    Console.WriteLine("Name: {0}  Age: {1}  Breed: {2}", animal.name, animal.age, animal.breed);
                }
                foreach (var animal in listcats)
                {
                    Console.WriteLine("Name: {0}  Age: {1}  Breed: {2}", animal.name, animal.age, animal.breed);
                }
                foreach (var animal in listrabbits)
                {
                    Console.WriteLine("Name: {0}  Age: {1}  Breed: {2}", animal.name, animal.age, animal.breed);
                }
                foreach (var animal in listbirds)
                {
                    Console.WriteLine("Name: {0}  Age: {1}  Breed: {2}", animal.name, animal.age, animal.breed);
                }

            }
            
        }
    }
}
