using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirCompany
{
    abstract class Passenger : Airplane
    {
        public int Capacity { get; private set; }
        public Passenger(int capacity, float consuption, int altitudeIncrement):base( consuption, altitudeIncrement)
        {
            Capacity = capacity;
        }
    }
}
