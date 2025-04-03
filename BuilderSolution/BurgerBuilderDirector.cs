using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderSolution
{
    public class BurgerBuilderDirector : IBurgerBuilderDirector  // can be implemented without this class
    {
        private IBurgerBuilder builder;

        public BurgerBuilderDirector(IBurgerBuilder builder)
        {
            this.builder = builder;
        }

        public void Build()
        {
            builder
                .WithBacon()
                .WithCheese()
                .WithLettuce()
                .WithPickles()
                .WithTomato();
        }
    }
}
