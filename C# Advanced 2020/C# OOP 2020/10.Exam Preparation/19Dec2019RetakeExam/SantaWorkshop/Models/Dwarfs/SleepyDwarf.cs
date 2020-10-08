using System;
using System.Collections.Generic;
using System.Text;

namespace SantaWorkshop.Models.Dwarfs
{
    public class SleepyDwarf : Dwarf
    {
        private const int SleepyDwarfEnergy = 50;
        private const int ENR_WORK_DECRESEMENT = 5;
        public SleepyDwarf(string name) 
            : base(name, SleepyDwarfEnergy)
        {
        }

        public override void Work()
        {
            base.Work();
            this.Energy -= ENR_WORK_DECRESEMENT;
        }
    }
}
