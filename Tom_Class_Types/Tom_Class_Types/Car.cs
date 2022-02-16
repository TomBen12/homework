using System;
namespace Tom_Class_Types
{
    // Question 9 b
    public class Car : VehicleBase
    {
        public int NumberOfDoors { get; set; }

        public Car(int numOfDoors)
        {
            NumberOfDoors = numOfDoors;
        }

        public override string ToString()
        {
            return base.ToString() + NumberOfDoors;
        }

        public override void GetMaxNumOfPassengers()
        {
            
        }

        public override void GetMaxSpeed()
        {
            
        }
    }
}
