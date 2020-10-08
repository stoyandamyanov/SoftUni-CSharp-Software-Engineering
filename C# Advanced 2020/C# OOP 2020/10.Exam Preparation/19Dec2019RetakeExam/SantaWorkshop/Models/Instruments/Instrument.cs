﻿using SantaWorkshop.Models.Instruments.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace SantaWorkshop.Models.Instruments
{
    public class Instrument : IInstrument
    {
        private int power;

        public Instrument(int power)
        {
            this.Power = power;
        }
        public int Power
        {
            get
            {
                return this.power;
            }
            private set
            {
                if(value < 0)
                {
                    this.power = 0;
                }
                
                this.power = value;
            }
        }

        public void Use()
        {
            this.Power -= 10;
            if (this.Power < 0)
            {
                this.Power = 0;
            }
        }
        public bool IsBroken()
        {
            return this.Power == 0;
        }

    }
}
