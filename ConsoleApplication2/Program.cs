using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AirCompany;
namespace AirCompany
{
    class Program
    {
        static void Main(string[] args)
        {
            Airplane Plane=null;
            Console.WriteLine("Select a plane");
            Console.WriteLine("a - An 124 \"Ruslan\"");
            Console.WriteLine("b - Boing 747");

            
            do
            {
                bool result = char.TryParse(Console.ReadLine(), out  char key);
                if(result==false)
                {
                    Console.WriteLine("Error! Enter one character!");
                    continue;
                }
                if (key == 'b') Plane = new Boing(500, 300.5F, 20, "747");
                else
                {
                    if (key == 'a') Plane = new Antonov(120000, 600.5F, 10, "An 124 \"Ruslan\"");
                    else
                    {
                        Console.WriteLine("Error! Set a or b !");
                    }
                 
                }
                
            } while (Plane==null);
            int NewAltitude;
            Console.WriteLine(Plane.ToString());
            do
            {
                
                Console.WriteLine("In this moment");
                Console.WriteLine("Altitude - "+Plane.Altitude);
                Console.WriteLine("AutoPilot - " + Plane.AutoPilotOn);
                Console.WriteLine("Forsage - " + Plane.Forsage);
                Console.WriteLine("\nSet New Altitude ");
                NewAltitude=Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("AutoPilot On?(y/n) ");
                Plane.AutoPilotOn=(Console.ReadKey().Key == ConsoleKey.Y) ? true : false;
                Console.WriteLine("\nForsage On?(y/n) ");
                Plane.Forsage = (Console.ReadKey().Key == ConsoleKey.Y) ? true : false;
                Plane.SetAltitude(NewAltitude);
                Console.Clear();
                Console.WriteLine("Altitude - " + Plane.Altitude);
                Console.WriteLine("Do You want to  continue?(y/n) ");
                
            } while (Console.ReadKey().Key != ConsoleKey.N);

        }
    }
}
