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
        delegate string PlanetValidator(string planet);

        PlanetValidator validator = Validator;
        public CatalogPlanet()
        {
            var planetVenera = new Planet("Венера",2, 12100, null);
            var planetEarth = new Planet("Земля", 3, 12756, planetVenera);
            var planetMars = new Planet("Марс",4, 6792, planetEarth);
            planets.Add(planetVenera);
            planets.Add(planetEarth);
            planets.Add(planetMars);
        }
        
        public void AddPlanet(Planet planet)
        {
            planets.Add(planet);             
        }
        public (int? countSun, float? dlina, string error) GetPlanet(string namePlanet)
        {
            var str = validator(namePlanet);
            if(str == null)
            {
                return (0, 0, str);
            }

            var planet = FindPlanet(str);            
           
            if (planet == null)
            {
                return (0, 0, "Не удалось найти планету");
            }

            return (planet.CountOfTheSun, planet.Dlina, "Поиск выполнен");
        }
        public static string Validator(string str) 
        {  
            if(str ==null)  return ("Не удалось найти планету");
            return str;
        }
        public Planet FindPlanet(string namePlanet)
        {            
            var planet = planets.Where(x => x.Name ==namePlanet).FirstOrDefault();
            return planet;
        }
    }
}
