using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_2_1
{
    public interface IColored
    {
        string Color { get; set; }
        string Name { get; set; }

        public void ChangeColor(string newColor)
        {
            Color = newColor;
            Console.WriteLine(Name + "'s color was changed into " + Color);
        }

        public void GetCurrentColor()
        {
            Console.WriteLine(Name + "'s current color is " + Color);
        }
    }
}
