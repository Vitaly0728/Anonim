using AnonimProgram2;

namespace AnonimProgram3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var catalogPlanet = new CatalogPlanet();

            var planet = catalogPlanet.GetPlanet("Земля");
            Console.WriteLine($"{planet.error}\nПорядковый номер от солнца = {planet.countSun}\nДлинна экватора = {planet.dlina}\n ");
            var planet1 = catalogPlanet.GetPlanet("Лимония");
            Console.WriteLine($"{planet1.error}\nПорядковый номер от солнца = {planet1.countSun}\nДлинна экватора = {planet1.dlina}\n ");
            var planet2 = catalogPlanet.GetPlanet("Марс");
            Console.WriteLine($"{planet2.error}\nПорядковый номер от солнца = {planet2.countSun}\nДлинна экватора = {planet2.dlina}\n ");
            var planet3 = catalogPlanet.GetPlanet("Лимония");
            Console.WriteLine($"{planet3.error}\nПорядковый номер от солнца = {planet3.countSun}\nДлинна экватора = {planet3.dlina}\n ");
        }
    }
}
