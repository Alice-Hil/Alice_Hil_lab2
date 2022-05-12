using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_2_1
{
    class Frame : IColored
    {
        public string Color { get; set; }
        public string Name { get; set; }

        public Frame(string color)
        {
            Color = color;
            Name = "Frame";
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;
            Frame m = obj as Frame;
            if (m as Frame == null)
                return false;
            return m.Color == this.Color;
        }
        public bool Equals(Frame obj) 
        {
            if (obj == null)
                return false;
            return obj.Color == this.Color;
        }
        public override int GetHashCode()
        {
            int uniCode;
            switch (Color)
            {
                case "blue":
                    uniCode = 11;
                    break;
                case "green":
                    uniCode = 12;
                    break;
                case "red":
                    uniCode = 13;
                    break;
                default:
                    uniCode = 20;
                    break;
            }

            return 1000 + uniCode;
        }
        public override string ToString()
        {
            return Name + ": " + Color;
        }

    }
}
