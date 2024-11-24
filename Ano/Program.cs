using System.Numerics;
using AnonimProgram2;

namespace Ano
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var catalog = new CatalogPlanet();

            int callCount = 0;

            Func<string, string> Validator = name =>
            {
                callCount++;
                return callCount % 3 == 0 ? "Вы спрашиваете слишком часто" : null;
            };

            string[] planets = { "Земля", "Лимония", "Марс" };

            foreach (var planet in planets)
            {
                var result = catalog.GetPlanet(planet, Validator);
                if (result.error == null)
                    Console.WriteLine($"Название: {planet}, Порядковый номер: {result.order}, Длина экватора: {result.equatorLength} \n");
                else
                    Console.WriteLine(result.error+"\n");
            }

            // Программа со звездочкой*
            Func<string, string> Validator2 = name => name == "Лимония" ? "Это запретная планета" : null;

            callCount = 0;

            string[] planets2 = { "Земля", "Лимония", "Марс" };

            foreach (var planet in planets2)
            {
                var result = catalog.GetPlanet(planet, Validator2);
                if (result.error == null)
                    Console.WriteLine($"Название: {planet}, Порядковый номер: {result.order}, Длина экватора: {result.equatorLength} \n");
                else
                    Console.WriteLine(result.error+ "\n");
            }
        }
    }
}

