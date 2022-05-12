using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_2_2
{
    class Caramel : ICandy
    {
        public int SugarPercentage { get; set; }
        public double Weight { get; set; }
        public string Name { get; set; }

        public Caramel()
        {
            Name = "Caramel candy";
            Weight = 4.2;
            SugarPercentage = 55;
        }
    }
}
