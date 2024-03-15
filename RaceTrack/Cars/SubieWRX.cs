using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace RaceTrack.RaceTrack.Cars
{
    internal class SubieWRX : RaceCar
    {
        public SubieWRX()
        {
            Name = "Subie WRX";
            TopSpeed = 174;
        }

        public override void StartEngine()
        {
            Console.WriteLine($"The {Name} revs the turbo engine!");
        }

        public override void Brake()
        {
            Console.WriteLine($"The {Name} pulls the handbreak and screeches to a hault!");
            base.Brake();
        }

        public override void StopEngine()
        {
            Console.WriteLine($"The {Name} releases its blowoff valve as the engine is killed!");
        }
    }
}
