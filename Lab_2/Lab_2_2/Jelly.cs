using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_2_2
{
    class Jelly : ICandy
    {
        public int SugarPercentage { get; set; }
        public double Weight { get; set; }
        public string Name { get; set; }

        public Jelly()
        {
            Name = "Jelly candy";
            Weight = 3.5;
            SugarPercentage = 64;
        }
    }
}
