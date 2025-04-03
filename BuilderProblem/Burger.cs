using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderProblem
{
    public class Burger
    {
        public bool Cheese { get; set; }
        public bool Bacon { get; set; }
        public bool Pickles { get; set; }
        public bool Lettuce { get; set; }
        public bool Tomato { get; set; }

        public Burger(bool cheese, bool bacon, bool pickles, bool letuce, bool tomato)
        {
            Cheese = cheese;
            Bacon = bacon;
            Pickles = pickles;
            Lettuce = letuce;
            Tomato = tomato;
        }

        public override string ToString()
        {
            return $"Burger with: {(Cheese ? "Cheese " : "")}" +
                $"{(Bacon ? "Bacon " : "")}" +
                $"{(Pickles ? "Pickles " : "")}" +
                $"{(Lettuce ? "Lettuce " : "")}" +
                $"{(Tomato ? "Tomato " : "")}";
        }
    }
}
