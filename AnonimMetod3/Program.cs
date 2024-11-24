using AnonimProgram2;

namespace AnonimMetod3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var catalog = new CatalogPlanet();

            int callCount = 0;

            Func<string, string> frequencyValidator = name =>
            {
                callCount++;
                return callCount % 3 == 0 ? "Вы спрашиваете слишком часто" : null;
            };

            string[] planets = { "Земля", "Лимония", "Марс" };

            foreach (var planet in planets)
            {
                var result = catalog.GetPlanet(planet, frequencyValidator);
                if (result.error == null)
                    Console.WriteLine($"Название: {planet}, Порядковый номер: {result.countSun}, Длина экватора: {result.dlina} \n");
                else
                    Console.WriteLine(result.error+ "\n");
            }

            Console.WriteLine("Задача со * \n");
            Func<string, string> forbiddenValidator = name => name == "Лимония" ? "Это запретная планета" : null;

            callCount = 0;

            string[] planets2 = { "Земля", "Лимония", "Марс" };

            foreach (var planet in planets2)
            {
                var result = catalog.GetPlanet(planet, forbiddenValidator);
                if (result.error == null)
                    Console.WriteLine($"Название: {planet}, Порядковый номер: {result.countSun}, Длина экватора: {result.dlina} \n");
                else
                    Console.WriteLine(result.error+ "\n");
            }
        }
    }
}

