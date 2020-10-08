﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SpaceStationRecruitment
{
    public class SpaceStation
    {
        private readonly List<Astronaut> data;

        private SpaceStation()
        {
            this.data = new List<Astronaut>();
        }

        public SpaceStation(string name, int capacity)
            : this()
        {
            this.Name = name;
            this.Capacity = capacity;
        }

        public string Name { get; set; }

        public int Capacity { get; set; }

        public void Add(Astronaut astronaut)
        {
            if (this.data.Count + 1 <= this.Capacity)
            {
                this.data.Add(astronaut);
            }
        }

        public bool Remove(string name)
        {
            Astronaut astronaut = this.data
                .FirstOrDefault(a => a.Name == name);

            if (astronaut != null)
            {
                this.data.Remove(astronaut);

                return true;
            }

            return false;
        }

        public Astronaut GetOldestAstronaut()
        {
            int biggestAge = int.MinValue;
            Astronaut oldestOne = new Astronaut(" ", biggestAge, "aaa");

            foreach (var a in this.data)
            {

                if (a.Age > biggestAge)
                {
                    biggestAge = a.Age;
                    oldestOne = a;
                }


            }
            return oldestOne;
        }

        public Astronaut GetAstronaut(string name)
        {
            Astronaut astronaut = this.data.FirstOrDefault(a => a.Name == name);

            return astronaut;
        }

        public int Count
        {
            get
            {
                return this.data.Count();
            }
        }

        public string Report()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Astronauts working at Space Station {this.Name}:");

            foreach (var item in this.data)
            {
                sb.AppendLine(item.ToString());
            }

            return sb.ToString().TrimEnd();
        }


    }
}
