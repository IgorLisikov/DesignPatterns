using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderSolution
{
    public interface IBurgerBuilder
    {
        IBurgerBuilder WithCheese();
        IBurgerBuilder WithBacon();
        IBurgerBuilder WithPickles();
        IBurgerBuilder WithLettuce();
        IBurgerBuilder WithTomato();
        Burger GetBurger();
    }
}
