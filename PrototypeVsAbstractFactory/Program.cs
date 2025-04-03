using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypeVsAbstractFactory
{
    public class Program
    {
        static void Main(string[] args)
        {
            AbstractFactory factory = new PrototypeFactory(new WinWindow(), new WinButton());
            Window window = factory.CreateWindow();
            Button button = factory.CreateButton();
            Console.WriteLine(window.GetType());
            Console.WriteLine(button.GetType());
        }
    }
}
