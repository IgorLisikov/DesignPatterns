using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderSolution
{
    public class BurgerBuilder : IBurgerBuilder
    {
        private Burger burger = new Burger();
        public IBurgerBuilder WithBacon()
        {
            burger.Bacon = true;
            return this;
        }

        public IBurgerBuilder WithCheese()
        {
            burger.Cheese = true;
            return this;
        }

        public IBurgerBuilder WithLettuce()
        {
            burger.Lettuce = true;
            return this;
        }

        public IBurgerBuilder WithPickles()
        {
            burger.Pickles = true;
            return this;
        }

        public IBurgerBuilder WithTomato()
        {
            burger.Tomato = true;
            return this;
        }

        public Burger GetBurger()
        {
            return burger;
        }
    }
}
