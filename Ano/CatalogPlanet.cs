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
        private List<Planet> planets;

        public CatalogPlanet()
        {
            planets = new List<Planet>
            {
                new Planet("Венера",2, 12100),
                new Planet("Земля", 3, 12756),
                new Planet("Марс",4, 6792)
            };
        }

        public (int? order, double? equatorLength, string error) GetPlanet(string name, Func<string, string> validator)
        {
            string validationError = validator(name);

            if (!string.IsNullOrEmpty(validationError))
                return (null, null, validationError);
            
            foreach (var planet in planets)
            {
                if (planet.Name.Equals(name, StringComparison.OrdinalIgnoreCase))
                    return (planet.Order, planet.EquatorLength, null);
            }

            return (null, null, "Не удалось найти планету");
        }
    }
}
