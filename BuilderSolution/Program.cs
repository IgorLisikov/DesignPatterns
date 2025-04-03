using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderSolution
{
    class Program
    {
        static void Main(string[] args)
        {
            var burgerBuilder = new BurgerBuilder();
            var burgerBuilderDiretor = new VegetarianBurgerBuilderDirector(burgerBuilder);

            burgerBuilderDiretor.Build();
            var burger = burgerBuilder.GetBurger();
            Console.WriteLine(burger);

            // if implemented without this IBurgerBuilderDirector
            var burgerBuilder2 = new BurgerBuilder();
            burgerBuilder2
                .WithCheese()
                .WithLettuce()
                .WithPickles()
                .WithTomato();

            var burger2 = burgerBuilder2.GetBurger();
            Console.WriteLine(burger2);
        }
    }
}
