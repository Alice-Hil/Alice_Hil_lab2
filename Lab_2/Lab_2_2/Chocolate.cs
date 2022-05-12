using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_2_2
{
    class Chocolate : ICandy
    {
        public int SugarPercentage { get; set; }
        public double Weight { get; set; }
        public string Name { get; set; }

        public Chocolate()
        {
            Name = "Chocolate candy";
            Weight = 8.6;
            SugarPercentage = 86;
        }
    }
}
