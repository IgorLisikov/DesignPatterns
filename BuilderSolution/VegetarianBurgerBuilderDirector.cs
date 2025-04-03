using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderSolution
{
    public class VegetarianBurgerBuilderDirector : IBurgerBuilderDirector  // can be implemented without this class
    {
        private IBurgerBuilder builder;

        public VegetarianBurgerBuilderDirector(IBurgerBuilder builder)
        {
            this.builder = builder;
        }

        public void Build()
        {
            builder
                .WithCheese()
                .WithLettuce()
                .WithPickles()
                .WithTomato();
        }
    }
}
