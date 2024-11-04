using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnonimProgram2
{
    internal class CatalogPlanet
    {
        public List<Planet> planets = new List<Planet>();

        public CatalogPlanet()
        {
            
        }

        public (int? ,float?,int?,string) GetPlanet(string namePlanet)
        {
            foreach (Planet planet in planets)
            {
                if (planet.Name != namePlanet)
                {
                    return (null, null, null, "Не удалось найти планету");
                }
            }
            
        }
    }
}
