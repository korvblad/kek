using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exempelmedmattias
{
    class Program
    {
        static void Main(string[] args)
        {
        
            Car myCar = new Car();
            Fighter fighter = new Fighter();

            AmphibiousCar amfCar = new AmphibiousCar();


            Vehicle myVehicle = myCar;


            myVehicle.StartEngine();
            myVehicle.Drive();

            myVehicle = fighter;

            myVehicle.StartEngine();
            myVehicle.Drive();



           
            myCar.StopEngine();

            
            fighter.StopEngine();

            amfCar.StartEngine();
            amfCar.Drive();
            amfCar.StopEngine();
        }
    }
}
