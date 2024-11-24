using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnonimProgram2
{
    internal class Planet
    {
        public string Name { get; set; }
        public int Order { get; set; }
        public double EquatorLength { get; set; }

        public Planet(string name, int order, double equatorLength)
        {
            Name = name;
            Order = order;
            EquatorLength = equatorLength;
        }
    }
}
