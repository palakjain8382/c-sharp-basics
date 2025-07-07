using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace learning
{
    public class Delegates
    {
        public delegate void GreetDelegate(string name);

        public static void SayHello(string name)
        {
            Console.WriteLine($"Hello, {name}!");
        }

        //public static void Main()
        //{
        //    GreetDelegate greet = SayHello;
        //    greet("Palak");
        //}
    }

    //delegate ArrayWithOffset Retunr type

    public delegate int Operation(int a, int b);
    public class Calculator
    {
        public static int Add(int x, int y) => x + y;
        public static int Multiply(int x, int y) => x * y;

        public static void Main()
        {
            Operation op1 = Add;
            Operation op2 = Multiply;

            Console.WriteLine(op1(2, 3) + " " + op2(2, 3));
        }
    }
}
