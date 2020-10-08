using SantaWorkshop.Core.Contracts;
using SantaWorkshop.Models.Dwarfs;
using SantaWorkshop.Models.Dwarfs.Contracts;
using SantaWorkshop.Models.Instruments;
using SantaWorkshop.Models.Instruments.Contracts;
using SantaWorkshop.Models.Presents;
using SantaWorkshop.Models.Presents.Contracts;
using SantaWorkshop.Models.Workshops;
using SantaWorkshop.Models.Workshops.Contracts;
using SantaWorkshop.Repositories;
using SantaWorkshop.Repositories.Contracts;
using SantaWorkshop.Utilities.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SantaWorkshop.Core
{
    class Controller : IController
    {
        private IRepository<IDwarf> dwarfs;
        private IRepository<IPresent> presents;
        private IDwarf dwarf;
        private IInstrument instrument;
        private IPresent present;
        private IWorkshop workshop;

        public Controller()
        {
            this.dwarfs = new DwarfRepository();
            this.presents = new PresentRepository();
            this.workshop = new Workshop();
        }

        public string AddDwarf(string dwarfType, string dwarfName)
        {
            if(dwarfType == nameof(HappyDwarf) || dwarfType == nameof(SleepyDwarf))
            {
                if(dwarfType == nameof(HappyDwarf))
                {
                    dwarf = new HappyDwarf(dwarfName);
                    dwarfs.Add(dwarf);
                }
                else
                {
                    dwarf = new SleepyDwarf(dwarfName);
                    dwarfs.Add(dwarf);
                }

                return $"Successfully added {dwarfType} named {dwarfName}.";
            }
            else
            {    // message only !!!!
                throw new InvalidOperationException(ExceptionMessages.InvalidDwarfType);
            }
        }

        public string AddInstrumentToDwarf(string dwarfName, int power)
        {
            instrument = new Instrument(power);
            dwarf = dwarfs.FindByName(dwarfName);
            
            if(dwarf != null)
            {
                dwarf.AddInstrument(instrument);

                return $"Successfully added instrument with power {power} to dwarf {dwarfName}!";
            }
            else
            {
                throw new InvalidOperationException(ExceptionMessages.InexistentDwarf);
            }
        }

        public string AddPresent(string presentName, int energyRequired)
        {
            present = new Present(presentName, energyRequired);
            presents.Add(present);

            return $"{string.Format(OutputMessages.PresentAdded,presentName)}";
        }

        public string CraftPresent(string presentName)
        {
            present = presents.FindByName(presentName);
            ICollection<IDwarf> dwarves = this.dwarfs
                .Models
                .Where(d => d.Energy >= 50)
                .OrderByDescending(D => D.Energy)
                .ToList();
            
            if (dwarves == null)
            {
                throw new InvalidOperationException(ExceptionMessages.DwarfsNotReady);
            }
            while (true)
            {

                if (present.IsDone())
                {
                    break;
                }

                if (dwarves.Count == 0)
                {
                    break;
                }
                dwarf = dwarves.First(d => d.Energy >= 50);

                

                while (true)
                {
                    workshop.Craft(present, dwarf);
                    if(dwarf.Energy <= 0)
                    {
                        dwarfs.Remove(dwarf);
                    }
                    else if(dwarf.Instruments.Count == 0)
                    {
                        dwarves.Remove(dwarf);
                        break;
                    }
                    if(dwarf == null || present.IsDone())
                    {
                        break;
                    }

                    
                }

                
            }

            if (present.IsDone())
            {
                return $"{string.Format(OutputMessages.PresentIsDone,presentName)}";
            }
            else
            {
                return $"{string.Format(OutputMessages.PresentIsNotDone,presentName)}";
            }

        }

        public string Report()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"{string.Format("{0} presents are done!",presents.Models.Count(p => p.IsDone()))}");
            sb.AppendLine("Dwarfs info: ");
            
            foreach (var dwarf in dwarfs.Models)
            {
                sb.AppendLine($"Name: {dwarf.Name}");
                sb.AppendLine($"Energy: {dwarf.Energy}");
                sb.AppendLine(string.Format("Instruments: {0} not broken left",dwarf.Instruments.Count(i => i.IsBroken() == false)));
            }

            return sb.ToString().TrimEnd();
        }
    }
}
