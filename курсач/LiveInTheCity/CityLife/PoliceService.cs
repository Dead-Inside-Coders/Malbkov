using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CityLife
{
    public class PoliceService  
    {
        private City Current;

        public PoliceService(City city) 
        {
            Current = city;
            Current.crimeEvent += new CrimeEvent(CrimeHandler);
        }
         
        private void CrimeHandler(int day)
        {
            string message =
                   "В городе {0} произошло преступление! " + 
                   "Преступник пойман!";
            Console.WriteLine(string.Format(message, Current.TownName,
               day));
        }

        public void GoOut()
        {
            Current.crimeEvent -= new CrimeEvent(CrimeHandler);
        } 
    }   
}
  