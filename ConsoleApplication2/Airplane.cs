using System;
using System.Threading;
namespace AirCompany
{
   abstract class Airplane
    {
        public string Model { get; protected set; }
        
        public bool AutoPilotOn { get; set; }

        /// <summary>
        /// Fuel consuption. kg/km
        /// </summary>
        public float Consuption { get; private set; }

        public int Altitude { get; private set; }
        public bool Forsage { get; set; }

        public static decimal TicketPrice { get; set; }
        public static int MinAltitudeAuto { get; set; }
        public static int MaxAltitudeAuto { get; set; }

        private int _altitudeIncrement;
        static Airplane()
        {
            MinAltitudeAuto = 500;
            MaxAltitudeAuto = 11000;
        }
        public Airplane( float consuption, int altitudeIncrement)
        {
            
            Altitude = 0;
            AutoPilotOn = false;
            Forsage = false;
            Consuption = consuption;
            _altitudeIncrement = altitudeIncrement;
        }

        protected int Climb(int increment)
        {
            if (Altitude > 15000) throw new Exception("Altiude>15000!");
            if (Forsage) increment *= 2;
            if (!AutoPilotOn) return Altitude += increment;
            if (Altitude + increment < MaxAltitudeAuto)
            {
                return Altitude += increment;
            }
            
            return Altitude = MaxAltitudeAuto;
        }

        protected int Down(int increment)
        {
           
                if (AutoPilotOn)
            {
                if (Altitude - increment > MinAltitudeAuto)
                {
                    return Altitude -= increment;
                }
                if (Altitude < MinAltitudeAuto) return Altitude;
                return Altitude = MinAltitudeAuto;
            }

            if (Altitude - increment < 0) return Altitude = 0;
            return Altitude -= increment;
        }

        public int SetAltitude(int targetAlitude)
        {
            
          
            int temp = _altitudeIncrement;
            if (AutoPilotOn && targetAlitude >= MaxAltitudeAuto)
            {
                Console.WriteLine("AutoPilot On! MaxAltitude - " + MaxAltitudeAuto);
                targetAlitude = MaxAltitudeAuto;
            }
            if (AutoPilotOn && targetAlitude <= MinAltitudeAuto)
            {
                Console.WriteLine("AutoPilot On! MinAltitude - " + MinAltitudeAuto);
                targetAlitude = MinAltitudeAuto;
            }
                while (Altitude != targetAlitude)
                {
                if (Math.Abs(Altitude - targetAlitude) < _altitudeIncrement) _altitudeIncrement /= 2;
                if (Altitude > targetAlitude) Down(_altitudeIncrement);
                    else Climb(_altitudeIncrement);
                if (Altitude < 0) Altitude = 0;

                Console.WriteLine("Altitude - " + Altitude);
                Thread.Sleep(100);
                Console.Clear();
            }
          
            _altitudeIncrement = temp;
            return Altitude;


        }

        public override string ToString()
        {
            return this.GetType().ToString() +"\n Molel "+ Model + "\nAltitudeIncrement - " + _altitudeIncrement;
        }
    }
    
}