using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumaneSociety
{
    class Rabbit
    {
        public string name;
        public int age;
        public string breed;
        enum Rabbits { Easter, Wascally, White, Cadburry };

        public void GenerateNewAnimal()
        {
            NameAnimal();
            InputAge();
            DetermineBreed();
        }

        private void NameAnimal()
        {
            Console.WriteLine("What is the animal's name?");
            name = Console.ReadLine();
        }

        private void InputAge()
        {
            Console.WriteLine("What is the animal's age?");
            age = Convert.ToInt32(Console.ReadLine());
        }
        private void DetermineBreed()
        {
            Console.WriteLine("What is the animal's breed?");
            Console.WriteLine("1-{0}, 2-{1}, 3-{2}, 4-{3}", Rabbits.Easter, Rabbits.Wascally, Rabbits.White, Rabbits.Cadburry);
            int input = Convert.ToInt32(Console.ReadLine());
            string[] type = Enum.GetNames(typeof(Rabbits));
            breed = type[input - 1];
        }
    }
}
