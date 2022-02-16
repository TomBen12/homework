using System;

namespace Tom_Class_Types
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Exercise 8
            //Question 8 e): hello from main will print first and then
            //the static constructor.
            Console.WriteLine("hello from main");
            AccountManager.Foo();
            AccountManager.Goo();
            #endregion
            #region Exercise 9
            VehicleBase c1 = new Car(2);
            VehicleBase c2 = new Car(3);
            VehicleBase c3 = new Car(4);
            VehicleBase m1 = new Motorcycle(1);
            VehicleBase m2 = new Motorcycle(2);
            VehicleBase m3 = new Motorcycle(3);
            VehicleBase[] myVehicles = new VehicleBase[] {c1, c2, c3, m1, m2, m3};
            Carrier myCarrier = new Carrier(myVehicles);

            foreach (VehicleBase vehicle in myVehicles)
            {
                Console.WriteLine(vehicle.ToString());
            }
            #endregion

        }
    }
}
