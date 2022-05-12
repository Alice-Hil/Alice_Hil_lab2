using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_2_1
{
    class Rudder : IColored
    {
        public string Color { get; set; }
        public string Name { get; set; }
        public int Direction { get; set; }

        public Rudder(int direction, string color)
        {
            Direction = direction;
            Color = color;
            Name = "Rudder";
        }

        public void Turn(int newDirection)
        {
            Direction = newDirection;
            Console.WriteLine(Name + " changed the direction to " + Direction + "deg");
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;
            Rudder m = obj as Rudder;
            if (m as Rudder == null)
                return false;
            return m.Color == this.Color && m.Direction == this.Direction;
        }
        public bool Equals(Rudder obj)
        {
            if (obj == null)
                return false;
            return obj.Color == this.Color && obj.Direction== this.Direction;
        }

        public override int GetHashCode()
        {
            int uniCode;
            int uni = Direction * 100;

            switch (Color)
            {
                case "black":
                    uniCode = 11;
                    break;
                case "white":
                    uniCode = 12;
                    break;
                default:
                    uniCode = 20;
                    break;
            }

            return 40000 + uniCode + uni;
        }

        public override string ToString()
        {
            return Name + ": " + Color + ", " + Direction + " deg";
        }
    }
}
