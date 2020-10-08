using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Christmas
{
    public class Bag
    {
        private readonly List<Present> data;

        private Bag()
        {
            this.data = new List<Present>();
        }

        public Bag(string color,int capacity)
            : this()
        {
            this.Color = color;
            this.Capacity = capacity;
        }

        public string Color { get; set; }
        public int Capacity { get; set; }

        public int Count
        {
            get
            {
                return this.data.Count;
            }

        }

        public void Add(Present present)
        {
            if(this.data.Count + 1 <= this.Capacity)
            {
                this.data.Add(present);
            }
        }

        public bool Remove(string name)
        {
            Present present = this.data
                .FirstOrDefault(p => p.Name == name);

            if(present != null)
            {
                this.data.Remove(present);

                return true;
            }

            return false;
            
        }
        public Present GetHeaviestPresent()
        {
            double max = double.MinValue;
            Present heaviest = new Present("a",0.0,"aaa");
            foreach (var item in this.data)
            {
                
                if(item.Weight > max)
                {
                    heaviest = item;
                    max = heaviest.Weight;
                }
               
            }
            return heaviest;
            
        }
        public Present GetPresent(string name)
        {
            Present present = this.data.FirstOrDefault(p => p.Name == name);
           
            return present;
        }

        public string Report()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{this.Color} bag contains:");

            foreach (var item in this.data)
            {
                sb.AppendLine(item.ToString());
            }

            return sb.ToString().TrimEnd();
        }
    }
}
