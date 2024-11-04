using System;

namespace AnonimMetod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var venus = new
            {
                Name = "Венера",
                CountOfTheSun = 2,
                Dlina = 12100,
                prevPlanet= null as object
            };

            var earth = new
            {
                Name = "Земля",
                CountOfTheSun = 3,
                Dlina = 12756,
                prevPlanet= venus
            };

            var mars = new
            {
                Name = "Марс",
                CountOfTheSun = 4,
                Dlina = 6792,
                prevPlanet = earth
            };
            var venusAgain = new
            {
                Name = "Венера",
                CountOfTheSun = 2,
                Dlina = 12100,
                prevPlanet = mars
            };

            List<dynamic> planets = [venus, earth, mars, venusAgain];

            foreach (var planet in planets)
            {
                bool isEquivalentToVenus = planet.Name == venus.Name;
                Console.WriteLine($"Название: {planet.Name}," +
                    $" Порядковый номер: {planet.CountOfTheSun}, " +
                    $"Длина экватора: {planet.Dlina} км, " +
                    $"Предыдущая планета: {(planet.prevPlanet != null ? planet.prevPlanet.Name : "Нет")}");
                Console.WriteLine($"Эквивалентна ли Венере: {isEquivalentToVenus}");
                Console.WriteLine();
            }



        }
    }   

}
