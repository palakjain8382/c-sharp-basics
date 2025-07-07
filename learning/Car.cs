using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace learning
{
    //OOPs
    public class Car
    {
        private int speed;

        public Car()
        {
            speed = 120;
        }

        public Car(int speed)
        {
            SetSpeed(speed);
        }

        public void SetSpeed(int value)
        {
            if(value < 0 || value > 300)
            {
                Console.WriteLine("Invalid Speed");
            }
            else
            {
                speed = value;
            }
        }

        public virtual void Drive()
        {
            Console.WriteLine("Driving a regular car... Wroom! Wroom!");
        }
    }

    public class ElectricCar : Car { 
        public override void Drive()
        {
            Console.WriteLine("Driving electric car... .. ..");
        }

        //public static void Main()
        //{
        //    Car car = new Car(100);
        //    Car car2 = new ElectricCar();

        //    car.Drive();
        //    car2.Drive();
        //}
    }
}
