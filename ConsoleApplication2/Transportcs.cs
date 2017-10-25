using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirCompany
{
    abstract class Transportcs : Airplane
    {
        public int Carrying_capacity { get; protected set; }
        public Transportcs(int carrying_capacity, float consuption, int altitudeIncrement) : base( consuption, altitudeIncrement)
        {
            Carrying_capacity = carrying_capacity;
        }
    }
}
