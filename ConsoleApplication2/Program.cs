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
            char key;
            do
            {
                bool result = char.TryParse(Console.ReadLine(), out   key);
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
            int i ;
            do
            {
                Console.WriteLine("In this moment");
                Console.WriteLine("Altitude - "+Plane.Altitude);
                Console.WriteLine("AutoPilot - " + Plane.AutoPilotOn);
                Console.WriteLine("Forsage - " + Plane.Forsage);
                Console.WriteLine("\nSet New Altitude ");
                NewAltitude=Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("AutoPilot On?(y/n) ");
                do
                {
                    i = 0;
                    bool result = char.TryParse(Console.ReadLine(), out  key);
                    if (result == false)
                    {
                        Console.WriteLine("Error! Enter one character!");
                        i++;
                        continue;
                    }
                     if(key == 'y') Plane.AutoPilotOn = true;
                    else
                    {
                        if (key == 'n') Plane.AutoPilotOn = false;
                        else
                        {
                            Console.WriteLine("Error! Set y or n !");
                            i++;
                        }
                    }
                } while (i!=0);  
                Console.WriteLine("\nForsage On?(y/n) ");
                do
                {
                    i = 0;
                    bool result = char.TryParse(Console.ReadLine(), out  key);
                    if (result == false)
                    {
                        Console.WriteLine("Error! Enter one character!");
                        i++;
                        continue;
                    }
                    if (key == 'y') Plane.Forsage = true;
                    else
                    {
                        if (key == 'n') Plane.Forsage = false;
                        else
                        {
                            Console.WriteLine("Error! Set y or n !");
                            i++;
                        }
                    }
                } while (i != 0);
                try
                {
                    Plane.SetAltitude(NewAltitude);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    Console.ReadKey();
                }
                Console.Clear();
                Console.WriteLine("Altitude - " + Plane.Altitude);
                Console.WriteLine("Do You want to  continue?(y/n) ");  
            } while (Console.ReadKey().Key != ConsoleKey.N);

        }
    }
}
