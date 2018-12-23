using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks; 

namespace CityLife
{ 
        /// <summary> 
        /// Пожарная служба - класс Reciver
        /// Принимает и обрабатывает событие FireEvent
        /// пожар в городе, клиентом которого является класс.
        /// </summary>
        public class FireMen
        { 
            /// <summary> 
            /// Город, клиентом которого является класс FireMen
            /// </summary>
            private City MyNativeTown;

            public FireMen(City city) 
            { 
                MyNativeTown = city;
                MyNativeTown.fireEvent += new FireEvent(FireHandler);
            }

            /// <summary>
            /// Обработчик события "пожар в городе"
            /// </summary>
            /// <param name="day">день пожара</param>
            /// <param name="buildings">строение</param>
            private void FireHandler(int day, int buildings)
            {
                string message =
                    "В городе {0} произошел пожар! " +
                    "В доме № {2}" + 
                    "  Пожар потушен!";
                Console.WriteLine(string.Format(message, MyNativeTown.TownName,
                   day, buildings));
            }
            public void GoOut()
            {
                MyNativeTown.fireEvent -= new FireEvent(FireHandler);
            }
        } 
}
