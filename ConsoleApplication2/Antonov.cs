using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirCompany
{
    class Antonov:Transportcs
    {
        public Antonov(int carrying_capacity, float consuption, int altitudeIncrement, string model) :base(carrying_capacity, consuption, altitudeIncrement)
        {
            Model = model;
        }
    }
}
