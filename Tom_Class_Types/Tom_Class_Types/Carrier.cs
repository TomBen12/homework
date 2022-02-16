using System;
namespace Tom_Class_Types
{// Question 9 d.
    public class Carrier
    {
        VehicleBase[] Vehicles { get; set; }

        public Carrier(VehicleBase[] vehicles)
        {
            vehicles = Vehicles;
        }

        public override string ToString()
        {
            string str = "";
            foreach (var v in Vehicles)
            {
                str += v.ToString() + "\n";
            }
            return str;
        }
    }
}
