using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_2_1
{
    class Bike
    {
        public string FrameColor { get; set; }
        public string RudderColor { get; set; }
        public double Speed { get; set; }
        public int Direction { get; set; }
        public string TiresType { get; set; }

        private readonly IColored frame;
        private readonly IColored rudder;
        private readonly ISpinning pedals;
        private readonly ISpinning frontWheel;
        private readonly ISpinning rearWheel;

        public Bike(double speed, string frameColor, string rudderColor = "black", int direction = 90, string tiresType = Wheel.TYPE_W)
        {
            Console.WriteLine("New bike created");
            Console.WriteLine("----------------------------------");

            Speed = speed;
            FrameColor = frameColor;
            RudderColor = rudderColor;
            Direction = direction;
            TiresType = tiresType;

            frame = new Frame(FrameColor);
            rudder = new Rudder(Direction, RudderColor);
            pedals = new Pedals(Speed);
            frontWheel = new Wheel(Speed, Wheel.POS_F, TiresType);
            rearWheel = new Wheel(Speed, Wheel.POS_R, TiresType);
        }
        
        public void TurnRudder(int newDirection)
        {
            ((Rudder)rudder).Turn(newDirection);
            Console.WriteLine("----------------------------------");
        }

        public void Move()
        {
            pedals.Spin();
            frontWheel.Spin();
            rearWheel.Spin();
            Console.WriteLine("Bike is moving in direction of " + Direction + " deg");
            Console.WriteLine("----------------------------------");
        }

        public void ChangeSpeed(double newSpeed)
        {
            Speed = newSpeed;
            pedals.ChangeSpeed(newSpeed);
            frontWheel.ChangeSpeed(newSpeed);
            rearWheel.ChangeSpeed(newSpeed);
            Console.WriteLine("----------------------------------");
        }

        public void ChangeTires(string newTiresType)
        {
            TiresType = newTiresType;
            ((Wheel)frontWheel).ChangeTire(newTiresType);
            ((Wheel)rearWheel).ChangeTire(newTiresType);
            Console.WriteLine("----------------------------------");
        }

        public void ChangeColor(string newFrameColor, string newRudderColor = "black")
        {
            FrameColor = newFrameColor;
            RudderColor = newRudderColor;
            frame.ChangeColor(FrameColor);
            rudder.ChangeColor(RudderColor);
            Console.WriteLine("----------------------------------");
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;
            Bike m = obj as Bike;
            if (m as Bike == null)
                return false;
            return m.frame.Equals(this.frame);
        }
        public bool Equals(Bike obj) // аргумент типа Money
        {
            if (obj == null)
                return false;
            return obj.frame.Equals(this.frame) &&
                obj.rudder.Equals(this.rudder) &&
                obj.rearWheel.Equals(this.rearWheel) &&
                obj.frontWheel.Equals(this.frontWheel) &&
                obj.pedals.Equals(this.pedals);
        }

        public override int GetHashCode()
        {
            return frame.GetHashCode() + rudder.GetHashCode()
                + rearWheel.GetHashCode() + frontWheel.GetHashCode() + pedals.GetHashCode();
        }

        public override string ToString()
        {
            string result = "Bike:\n" + frame.ToString() + "\n" + rudder.ToString() + "\n"
                + frontWheel.ToString() + "\n" + rearWheel.ToString() + "\n" + pedals.ToString();
            return result;
        }
    }
}
