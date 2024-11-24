using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnonimProgram2
{
    internal class Planet
    {
        public string Name { get; }
        public int CountOfTheSun {  get; }
        public float Dlina {  get; }
        public Planet? PrevPlanet { get; }

        public Planet(string _name, int _count, float _dlina,Planet _prev)
        {
            Name = _name;
            CountOfTheSun = _count;
            Dlina = _dlina;
            PrevPlanet=_prev;
        }
    }
}
