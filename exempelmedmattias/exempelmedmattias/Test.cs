using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exempelmedmattias
{
    public class Test
    {

        public void Run()
        {
            Car myCar = new Car();
            Fighter myFighter = new Fighter();
            AmphibiousCar myAmphibiousCar = new AmphibiousCar();

            DoAction(myCar);
            DoAction(myFighter);
            DoAction(myAmphibiousCar);
        }

        private void DoAction(Vehicle vehicle)
        {
            vehicle.StartEngine();
            vehicle.Drive();
            vehicle.StopEngine();
        }
    }
}
