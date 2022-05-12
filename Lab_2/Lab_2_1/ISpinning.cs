using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_2_1
{
    interface ISpinning
    {
        string Name { get; set; }
        double Speed { get; set; }

        public void ChangeSpeed(double newSpeed)
        {
            Speed = newSpeed;
            Console.WriteLine(Name + "'s speed was changed to " + Speed + "km/h");
        }

        public void Spin()
        {
            Console.WriteLine(Name + " spin with the speed of " + Speed + "km/h");
        }

    }
}
