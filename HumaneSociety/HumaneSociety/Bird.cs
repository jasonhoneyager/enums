using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumaneSociety
{
    class Bird
    {
        public string name;
        public int age;
        public string breed;
        enum Birds { Angry=1, Loud=2, Smelly=3, Talkative=4 };

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
            Console.WriteLine("1-{0}, 2-{1}, 3-{2}, 4-{3}", Birds.Angry, Birds.Loud, Birds.Smelly, Birds.Talkative);
            int input = Convert.ToInt32(Console.ReadLine());
            string[] type = Enum.GetNames(typeof(Birds));
            breed = type[input - 1];
        }
    }
}
