using System;
namespace Tom_Class_Types
{//question 9 a
    public abstract class VehicleBase
    {
        int NumberOfWeels { get; set; }
        string Model { get; set; }

        public VehicleBase()
        {
        }

        public abstract void GetMaxNumOfPassengers();

        public abstract void GetMaxSpeed();

        public override string ToString()
        {
            return base.ToString();
        }



    }
}
