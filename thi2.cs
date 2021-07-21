using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1
{
    class SetMe
    {
        private string Name { get; set; }
        private int Weight { get; set; }

        public SetMe(string name, int weight)
        {
            this.Name = name;
            this.Weight = weight;
        }
        public override string ToString()
        {
            return $"Name: {Name}, Weight: {Weight}";
        }
    }
}