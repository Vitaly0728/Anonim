namespace AnonimProgram2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var catalog = new CatalogPlanet();

            string[] planets = { "Земля", "Лимония", "Марс" };

            foreach (var planet in planets)
            {
                var result = catalog.GetPlanet(planet);
                if (result.error == null)
                    Console.WriteLine($"Название: {planet}, Порядковый номер: {result.countSun}, Длина экватора: {result.dlina}\n");
                else
                    Console.WriteLine(result.error+"\n");
            }
        }
    }
}
