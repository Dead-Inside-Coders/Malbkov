using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CityLife;

namespace LiveInTheCity
{
    class Program
    { 
        static void Main(string[] args)
        {
            City Tver = new City("Tver",10,10,0.05,0.1);
            FireMen fireMen = new FireMen(Tver);
            PoliceService police = new PoliceService(Tver);
            Tver.CityLife();
            Console.ReadKey();   
        }   
    }   
}  
  