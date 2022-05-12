using System;

namespace Lab_2_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Bike bike1 = new Bike(10.2, "green");
            bike1.Move();
            bike1.TurnRudder(30);
            bike1.ChangeSpeed(14.1);
            bike1.ChangeTires(Wheel.TYPE_S);
            bike1.ChangeColor("blue", "white");

            Bike bike2 = new Bike(10.2, "green");

            if (bike1.Equals(bike2))
            {
                Console.WriteLine("Similar!");
            }
            else
            {
                Console.WriteLine("Different!");
            }
            Console.WriteLine("----------------------------------");

            Console.WriteLine(bike1.GetHashCode());
            Console.WriteLine(bike2.GetHashCode());
            Console.WriteLine("----------------------------------");
            Console.WriteLine(bike1.ToString());

            

            
            
            

        }
    }
}
