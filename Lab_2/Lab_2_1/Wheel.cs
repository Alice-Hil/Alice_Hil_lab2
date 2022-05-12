using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_2_1
{
    class Wheel : ISpinning
    {
        public const string TYPE_T = "thin";
        public const string TYPE_S = "studded";
        public const string TYPE_W = "wide";

        public const string POS_F = "Front";
        public const string POS_R = "Rear";

        public string Name { get; set; }
        public double Speed { get; set; }
        public string TiresType { get; set; }
        public string Position { get; set; }

        public Wheel(double speed, string position, string tiresType)
        {
            Speed = speed;
            Position = position;
            TiresType = tiresType;
            Name = Position + " wheel";
        }

        public void ChangeTire(string newTiresType)
        {
            TiresType = newTiresType;
            Console.WriteLine(Name + "'s tire was changed to " + TiresType + " tire");
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;
            Wheel m = obj as Wheel;
            if (m as Wheel == null)
                return false;
            return m.Speed == this.Speed && m.TiresType == this.TiresType && m.Position == this.Position;
        }
        public bool Equals(Wheel obj)
        {
            if (obj == null)
                return false;
            return obj.Speed == this.Speed && obj.TiresType == this.TiresType && obj.Position == this.Position;
        }

        public override int GetHashCode()
        {
            int uniCode;
            int uniType;
            int uni = (int)Speed * 1000;

            switch (Position)
            {
                case POS_F:
                    uniType = 100;
                    break;
                default:
                    uniType = 200;
                    break;
            }

            switch (TiresType)
            {
                case TYPE_S:
                    uniCode = 11;
                    break;
                case TYPE_T:
                    uniCode = 12;
                    break;
                case TYPE_W:
                    uniCode = 13;
                    break;
                default:
                    uniCode = 20;
                    break;
            }
            return 30000 + uniCode + uniType + uni;
        }

        public override string ToString()
        {
            return Name + ": " + Position + " pos., " + Speed + "km/h, " + TiresType + " tires";
        }
    }
}
