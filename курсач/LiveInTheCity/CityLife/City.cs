using System;

namespace CityLife
{

    public delegate void FireEvent(int day, int building);

    public delegate void CrimeEvent(int day);
     
    public class City 
    { 
        /// <summary> 
        /// "Зажигание" события Fire (пожар) 
        /// </summary>
        /// <param name="time">время обнаружения пожара</param>
        /// <param name="build">
        /// здание, в котором произошел пожар </param> 
        void OnFire(int day, int buildings)
        {
            fireEvent?.Invoke(day, buildings); 
        } 
        /// <summary>
        /// "Включение" события Преступление 
        /// </summary>
        /// <param name="day">время обнаружения преступления</param>
        void OnCrime(int day)
        {   
            crimeEvent?.Invoke(day);
        }     
          
        public event FireEvent fireEvent;
        public event CrimeEvent crimeEvent;

        public string TownName { get; private set; }
        int buildings;
        int days; 
        double fireProbability;
        double crimeProbability;  
        Random random = new Random(); 

        /// <summary>  
        /// Конструктор, инициализирующий поля класса
        /// </summary>
        /// <param name="name">название города</param>
        /// <param name="buildings">число домов</param>
        /// <param name="days">число дней жизни города</param>
        /// <param name="fireProbability"> 
        /// вероятность пожара в доме в текущий день</param> 
        /// <param name="crimeProbabilily">вероятность преступления</param>
        public City(string name, int buildings,
        int days, double fireProbability, double crimeProbabilily )
        { 
            TownName = name;   
            this.buildings = buildings;  
            this.days = days; 
            this.fireProbability = fireProbability;
            this.crimeProbability = crimeProbabilily; 
        } 
           
        /// <summary>  
        /// Моделирование жизни города
        /// </summary>
        public void CityLife() 
        { 
            const string NotFire =  
                "Пожаров нет :)";  
            const string NotCrime =   
                "Преступлений нет :)"; 


            for (int day = 1; day < days; day++)
            {
                bool wasFire = false;
                bool wasCrime = false;
                 
                Console.WriteLine("---"); 
                Console.WriteLine("День " + day);
                for (int building = 1; building < buildings; building++)
                {
                    if (random.NextDouble() < fireProbability)
                    {
                        OnFire(day, building);
                        wasFire = true;
                    } 
                    if (random.NextDouble() < crimeProbability)
                    {
                        OnCrime(day);
                        wasCrime = true;   
                    }  
                }
                if (!wasFire)
                    Console.WriteLine(NotFire); 
                if (!wasCrime)
                    Console.WriteLine(NotCrime); 
            }    
          

        }  

    } 
       
}
