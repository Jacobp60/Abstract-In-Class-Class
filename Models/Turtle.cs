using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractExample.Models
{
    public class Turtle : Animal
    {
        public Turtle(string name)
        {
            Name = name;
        }

        public Turtle()
        {
            Name = "Master Oogway";
        }
        public override void MakeNoise()
        {
            Console.WriteLine($"{Name} make the noise click click cluck ");
        }

        public virtual void Sleep()
        {
            Console.WriteLine("ZZZZZZ");
        }
    }
}
