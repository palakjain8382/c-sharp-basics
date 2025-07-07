using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace learning
{
    class Person
    {
        public string name;
        public int age;

        public Person()
        {
            Console.WriteLine("Default constructor called");
            name = "Jerry";
            age = 23;
        }

        public Person(string n, int a)
        {
            Console.WriteLine("Parameterised contructor called");
            name = n; age = a;
        }

        public void Introduce()
        {
            Console.WriteLine($"Hi, I'm {name} & my age is {age}.");
        }
    }

    class Program
    {
        //static void Main()
        //{
        //    Person p1 = new Person();
        //    p1.name = "Palak";
        //    p1.age = 30;
        //    p1.Introduce();

        //    Person p2 = new Person();
        //    p2.name = "Jain";
        //    p2.age = 22;
        //    p2.Introduce();

        //    Person p3 = new Person();
        //    p3.Introduce();

        //    Person p4 = new Person("Pam", 44);
        //    p4.Introduce();
        //}
    }
}
