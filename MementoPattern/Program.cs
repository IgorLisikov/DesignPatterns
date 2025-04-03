using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MementoPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var document = new Document();
            var history = new History();

            document.Content = "a";
            history.Push(document.CreateState());
            Console.WriteLine(document);

            document.FontName = "font1";
            history.Push(document.CreateState());
            Console.WriteLine(document);

            document.FontSize = 14;
            history.Push(document.CreateState());
            Console.WriteLine(document);

            document.FontSize = 10;
            history.Push(document.CreateState());
            Console.WriteLine(document);

            document.RestoreState(history.Pop());
            Console.WriteLine(document);
        }
    }
}
