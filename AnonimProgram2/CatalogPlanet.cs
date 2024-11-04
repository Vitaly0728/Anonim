using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace AnonimProgram2
{
    internal class CatalogPlanet
    {
        public List<Planet> planets = new List<Planet>();
        private int _count = 3;
        public CatalogPlanet()
        {
            
        }

        public (int? ,float?) GetPlanet(string namePlanet)
        {
            if (_count == 0)
            {
                Console.WriteLine("Вы спрашиваете слишком часто");
            }
            _count--;
            foreach (Planet planet in planets)
            {
                if (planet.Name == namePlanet)
                {
                    return (planet.CountOfTheSun, planet.Dlina);
                }                
            }
            
                Console.WriteLine("Не удалось найти планету");              
            
            
            return (null,null);
        }
    }
}
