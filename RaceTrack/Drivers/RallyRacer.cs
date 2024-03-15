using RaceTrack.RaceTrack.Cars;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaceTrack.RaceTrack.Drivers
{
    internal class RallyRacer : Driver
    {
        public RallyRacer(RaceCar car) : base(car)
        {
            Name = "Rally Racer";
            SkillLevel = 17;
        }

        public override void Drive()
        {
            Car.Accelerate(SkillLevel);
        }
    }
}
