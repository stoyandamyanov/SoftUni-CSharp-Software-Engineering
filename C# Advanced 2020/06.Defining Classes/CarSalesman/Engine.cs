﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CarSalesman
{
    public class Engine
    {
        private string model;
        private int power;
        private int? displacement;
        private string efficiency;


        public Engine(string model,int power)
        {
            this.Model = model;
            this.Power = power;
        }

        public Engine(string model,int power,int displacement)
            : this(model,power)
        {
            this.Displacement = displacement;
        }

        public Engine(string model, int power, string efficiency)
            :this(model,power)
        {
            this.Efficiency = efficiency;
        }

        public Engine(string model, int power, int displacement, string efficiency)
            :this(model,power)
        {
            this.Displacement = displacement;
            this.Efficiency = efficiency;
        }
        public string Model { get; set; }

        public int Power { get; set; }

        public int? Displacement { get; set; }

        public string Efficiency { get; set; }

        public override string ToString()
        {

            StringBuilder sb = new StringBuilder();
            string dispStr = this.Displacement.HasValue ? this.Displacement.ToString() : "n/a";
            string effiStr = string.IsNullOrEmpty(this.Efficiency) ? "n/a" : this.Efficiency;

            sb
                .AppendLine($"{this.Model}:")
                .AppendLine($"    Power: {this.Power}")
                .AppendLine($"    Displacement: {dispStr}")
                .AppendLine($"    Efficiency: {effiStr}");

            return sb.ToString().TrimEnd();
        }
    }
}
