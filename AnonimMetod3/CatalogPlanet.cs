using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace AnonimProgram2
{
    internal class CatalogPlanet
    {
        public List<Planet> planets;

        public CatalogPlanet()
        {
            planets = new List<Planet>
            {
                new Planet("Венера",2, 12100),
                new Planet("Земля", 3, 12756),
                new Planet("Марс",4, 6792)
            };
            
        }       
        
        public (int? countSun, float? dlina, string error) GetPlanet(string namePlanet, Func<string, string> validator)
        {
            string validationError = validator(namePlanet);

            if (!string.IsNullOrEmpty(validationError))
                return (null, null, validationError);

            foreach (var planet in planets)
            {
                if (planet.Name.Equals(namePlanet, StringComparison.OrdinalIgnoreCase))
                    return (planet.CountOfTheSun, planet.Dlina, null);
            }

            return (null, null, "Не удалось найти планету");
        }
    }
}
