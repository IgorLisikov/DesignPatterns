using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    class Program
    {
        static void Main(string[] args)
        {
            Prototype prot1 = new ConcretePrototype1("1");  // Base constructor is called
            Prototype prot2 = new ConcretePrototype2("2");  // Base constructor is called
            Prototype prot3 = prot1.Clone();        // Base constructor is not called
            Prototype prot4 = prot2.Clone();        // Base constructor is called
        }
    }

    public abstract class Prototype
    {
        // Constructor
        public Prototype(string id)
        {
            this.Id = id;

            Console.Write("Base constructor is called.\n");
        }

        // Property
        public string Id { get; private set; }

        public virtual Prototype Clone()
        {
            // Shallow copy
            return (Prototype)this.MemberwiseClone();
        }
    }

    public class ConcretePrototype1 : Prototype
    {
        public ConcretePrototype1(string id) : base(id)
        {
        }
    }

    public class ConcretePrototype2 : Prototype
    {
        public ConcretePrototype2(string id) : base(id)
        {
        }

        public override Prototype Clone()
        {
            // Deep copy
            string result = JsonConvert.SerializeObject(this);
            return JsonConvert.DeserializeObject<ConcretePrototype2>(result);
        }
    }
}

