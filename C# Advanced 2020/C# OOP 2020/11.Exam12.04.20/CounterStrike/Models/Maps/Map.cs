using CounterStrike.Models.Maps.Contracts;
using CounterStrike.Models.Players;
using CounterStrike.Models.Players.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CounterStrike.Models.Maps
{
    public class Map : IMap
    {
        private ICollection<IPlayer> players;

        public Map()
        {
            this.players = new List<IPlayer>();
        }

        public string Start(ICollection<IPlayer> players)
        {
            ICollection<IPlayer> Terrorists = players
                .Where(p => p.GetType().Name == nameof(Terrorist) && p.IsAlive)
                .ToList();

            ICollection<IPlayer> CounterTerrorists = players
                .Where(p => p.GetType().Name == nameof(CounterTerrorist) && p.IsAlive == true)
                .ToList();

            while (Terrorists.Count != 0 && CounterTerrorists.Count != 0)
            {

                 IPlayer terrorist = Terrorists.FirstOrDefault(p => p.IsAlive && p.Gun.BulletsCount > 0);


                if(terrorist != null)
                {
                    foreach (var player in CounterTerrorists)
                    {
                        player.TakeDamage(terrorist.Gun.Fire());
                        
                    }
                    for (int i = 0; i < CounterTerrorists.Count; i++)
                    {
                        IPlayer current = CounterTerrorists.ElementAt(i);

                        if (current.IsAlive == false)
                        {
                            CounterTerrorists.Remove(current);

                        }
                    }
                }

                

                IPlayer counterTerrorist = CounterTerrorists.FirstOrDefault(p => p.IsAlive && p.Gun.BulletsCount > 0);

                // !!!
                if (counterTerrorist != null)
                {
                    foreach (var player in Terrorists)
                    {
                        player.TakeDamage(counterTerrorist.Gun.Fire());
                        
                    }
                    for (int i = 0; i < Terrorists.Count; i++)
                    {
                        IPlayer current = Terrorists.ElementAt(i);

                        if (current.IsAlive == false)
                        {
                            Terrorists.Remove(current);

                        }
                    }
                }



            }

            if (Terrorists.Count == 0)
            {
                return "Counter Terrorist wins!";
            }
            else
            {
                return $"{"Terrorist wins!"}";
            }




        }
    }
}
