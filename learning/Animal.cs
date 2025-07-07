using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace learning
{
    public abstract class Animal
    {
        public abstract void Speak();
    }

    public class Dogesh : Animal
    {
        public override void Speak()
        {
            Console.WriteLine("bhow! bhow!");
        }
    }

    public class Meownja : Animal
    {
        public override void Speak()
        {
            Console.WriteLine("meow! meow!");
        }
    }

    public class MainClass
    {
        //public static void Main()
        //{
        //    Dogesh d = new Dogesh();
        //    Meownja m = new Meownja();
        //    Animal a = new Dogesh();
        //    Animal b = new Meownja();

        //    a.Speak();
        //    d.Speak();
        //    m.Speak();
        //    b.Speak();
        //}
    }
}
