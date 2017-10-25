using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirCompany
{
    class Boing: Passenger
    {
        
        public Boing(int capacity, float consuption, int altitudeIncrement, string model):base(capacity, consuption, altitudeIncrement)
        {
            AutoPilotOn = true;
            Forsage = false;
            Model = model;
        }
    }
}
