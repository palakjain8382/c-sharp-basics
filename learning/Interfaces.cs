using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace learning
{
    public class Interfaces
    {
        //public static void Main()
        //{
        //    IAnimal dog = new Dog();
        //    dog.Speak();
        //    IAnimal goat = new Goat();
        //    goat.Speak();
        //}
    }

    public interface IAnimal
    {
        void Speak();
    }

    public class Dog : IAnimal { 

        public Dog()
        {
            Console.WriteLine("Hello I am Dogesh Bhai!");
        }

        public void Speak()
        {
            Console.WriteLine("Bhow!");
        }
    }

    public class Goat : IAnimal
    {
        public Goat()
        {
            Console.WriteLine("Hello this is a goated animal!");
        }

        public void Speak()
        {
            Console.WriteLine("mehhh!");
        }
    }
}
