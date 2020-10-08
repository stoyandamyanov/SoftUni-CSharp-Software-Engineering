using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ViceCity.Core.Contracts;
using ViceCity.Models.Guns;
using ViceCity.Models.Guns.Contracts;
using ViceCity.Models.Neghbourhoods;
using ViceCity.Models.Neghbourhoods.Contracts;
using ViceCity.Models.Players;
using ViceCity.Models.Players.Contracts;
using ViceCity.Repositories;
using ViceCity.Repositories.Contracts;

namespace ViceCity.Core
{
    public class Controller : IController
    {
        private readonly List<IPlayer> players;
        private readonly IRepository<IGun> gunRepository;
        private INeighbourhood neighbourhood;
        private IPlayer player;
        private IGun gun;
        public Controller()
        {
            this.players = new List<IPlayer>();
            this.players.Add(new MainPlayer());
            this.gunRepository = new GunRepository();
            this.neighbourhood = new GangNeighbourhood();
        }

        public string AddGun(string type, string name)
        {
            if (type == "Pistol")
            {
                gun = new Pistol(name);
                gunRepository.Add(gun);

                return $"Successfully added {name} of type: {type}";
            }
            else if (type == "Rifle")
            {
                gun = new Rifle(name);
                gunRepository.Add(gun);
                return $"Successfully added {name} of type: {type}";
            }

            return $"Invalid gun type!";
        }

        public string AddGunToPlayer(string name)
        {
            if (gunRepository.Models.Count == 0)
            {
                return $"There are no guns in the queue!";
            }
            else
            {

                if (name == "Vercetti")
                {
                    player = this.players.FirstOrDefault(p => p.Name == "Tommy Vercetti" && p.GetType().Name == nameof(MainPlayer));
                    gun = this.gunRepository.Models.FirstOrDefault(g => g.CanFire);

                    player.GunRepository.Add(gun);
                    this.gunRepository.Remove(gun);

                    return $"{string.Format("Successfully added {0} to the Main Player: Tommy Vercetti", this.gun.Name)}";
                }
                else
                {
                    player = new CivilPlayer(name);
                    player = this.players.Find(p => p.Name == player.Name);
                    
                    if (player != null)
                    {
                        player = this.players.FirstOrDefault(p => p.Name == name && p.GetType().Name == nameof(CivilPlayer));
                        gun = this.gunRepository.Models.FirstOrDefault(g => g.CanFire);

                        player.GunRepository.Add(gun);
                        this.gunRepository.Remove(gun);
                    }
                    else
                    {
                        return $"Civil player with that name doesn't exists!";
                    }

                    return $"{string.Format("Successfully added {0} to the Civil Player: {1}",this.gun.Name,this.player.Name)}";
                
                }

            }
        }

        public string AddPlayer(string name)
        {
            player = new CivilPlayer(name);
            this.players.Add(player);

            return $"{string.Format("Successfully added civil player: {0}!", name)}";
        }

        public string Fight()
        {
            MainPlayer player = (MainPlayer)this.players.FirstOrDefault(p => p.GetType().Name == nameof(MainPlayer));
            this.neighbourhood = new GangNeighbourhood();
            List<IPlayer> civilPlayers = players.FindAll(p => p.GetType().Name != nameof(MainPlayer)).ToList();
            
            this.neighbourhood.Action(player, civilPlayers);

            if(civilPlayers.All(p => p.IsAlive == true) && player.LifePoints == 100)
            {
                return $"Everything is okay!";
            }
            else
            {
                StringBuilder sb = new StringBuilder();

                sb.AppendLine("A fight happened:");
                sb.AppendLine(String.Format("Tommy live points: {0}!", player.LifePoints));
                sb.AppendLine(string.Format("Tommy has killed: {0} players!",civilPlayers.Count(p => p.LifePoints <= 0)));
                civilPlayers.RemoveAll(p => p.LifePoints <= 0);
                sb.AppendLine(string.Format("Left Civil Players: {0}!",civilPlayers.Count));

                return sb.ToString().TrimEnd();
            }

            
        }
    }
}
