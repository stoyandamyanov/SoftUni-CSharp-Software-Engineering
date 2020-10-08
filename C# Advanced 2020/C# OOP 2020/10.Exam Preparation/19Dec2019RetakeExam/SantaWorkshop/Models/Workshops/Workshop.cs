using SantaWorkshop.Models.Dwarfs.Contracts;
using SantaWorkshop.Models.Presents.Contracts;
using SantaWorkshop.Models.Workshops.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SantaWorkshop.Models.Workshops
{
    public class Workshop : IWorkshop
    {
        public Workshop()
        {
        }

        public void Craft(IPresent present, IDwarf dwarf)
        {
            while (true)
            {
                var instrument = dwarf.Instruments.FirstOrDefault(i => i.IsBroken() != true);

                if(present.IsDone() || dwarf.Energy <= 0 || dwarf.Instruments.All(i => i.IsBroken()))
                {
                    break;
                }

                while (true)
                {
                    if(dwarf.Energy > 0 && instrument.IsBroken() != true || present.IsDone() != true)
                    {
                        dwarf.Work();
                        present.GetCrafted();
                        instrument.Use();
                        
                        if (instrument.IsBroken())
                        {
                            dwarf.Instruments.Remove(instrument);
                            break;
                        }
                    }

                    if(present.IsDone() || dwarf.Energy <= 0)
                    {
                        break;
                    }
                }
            }
        }
    }
}
