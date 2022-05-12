using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_2_1 
{
    class Pedals : ISpinning
    {
        public double Speed { get; set; }
        public string Name { get; set; }

        public Pedals(double speed)
        {
            Speed = speed;
            Name = "Pedals";
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;
            Pedals m = obj as Pedals;
            if (m as Pedals == null)
                return false;
            return m.Speed == this.Speed;
        }
        public bool Equals(Pedals obj) 
        {
            if (obj == null)
                return false;
            return obj.Speed == this.Speed;
        }

        public override int GetHashCode()
        {
            int uniCode = (int)Speed;

            return 2000 + uniCode;
        }

        public override string ToString()
        {
            return Name + ": " + Speed + "km/h";
        }
    }
}
