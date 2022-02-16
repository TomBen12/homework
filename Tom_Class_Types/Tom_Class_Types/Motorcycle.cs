using System;
namespace Tom_Class_Types
{// Auestion 9d
    public class Motorcycle : VehicleBase
    {
        public int NumberOfHandBrakes { get; set; }
        public Motorcycle(int numOfBrakes)
        {
            NumberOfHandBrakes = numOfBrakes;
        }

        public override string ToString()
        {
            return base.ToString() + NumberOfHandBrakes;
        }

        public override void GetMaxNumOfPassengers()
        {
        }

        public override void GetMaxSpeed()
        {
            throw new NotImplementedException();
        }
    }
}
