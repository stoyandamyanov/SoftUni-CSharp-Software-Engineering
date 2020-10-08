using CounterStrike.Core.Contracts;
using CounterStrike.Models.Guns;
using CounterStrike.Models.Guns.Contracts;
using CounterStrike.Models.Maps;
using CounterStrike.Models.Maps.Contracts;
using CounterStrike.Models.Players;
using CounterStrike.Models.Players.Contracts;
using CounterStrike.Repositories;
using CounterStrike.Repositories.Contracts;
using CounterStrike.Utilities.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CounterStrike.Core
{
    public class Controller : IController
    {
        private readonly IRepository<IGun> gunRepository;
        private readonly IRepository<IPlayer> playersRepository;
        private IMap map;
        private IGun gun;
        private IPlayer player;

        public Controller()
        {
            this.gunRepository = new GunRepository();
            this.playersRepository = new PlayerRepository();
            this.map = new Map();
        }

        public string AddGun(string type, string name, int bulletsCount)
        {
            if (type == "Pistol")
            {
                gun = new Pistol(name,bulletsCount);
                gunRepository.Add(gun);

                return $"Successfully added gun {name}.";
            }
            else if (type == "Rifle")
            {
                gun = new Rifle(name,bulletsCount);
                gunRepository.Add(gun);
                return $"Successfully added gun {name}.";
            }
            else
            {
                throw new ArgumentException(ExceptionMessages.InvalidGunType);
            }

        }

        public string AddPlayer(string type, string username, int health, int armor, string gunName)
        {
            gun = this.gunRepository.Models.FirstOrDefault(g => g.Name == gunName);
            if(gun == null)
            {
                throw new ArgumentException(ExceptionMessages.GunCannotBeFound);
            }

            if(type == nameof(Terrorist) && gun != null)
            {
                player = new Terrorist(username, health, armor, gun);
                this.playersRepository.Add(player);
              
            }
            else if(type == nameof(CounterTerrorist) && gun != null)
            {
                player = new CounterTerrorist(username, health, armor, gun);
                this.playersRepository.Add(player);
            }
            else if(type != nameof(Terrorist) && type != nameof(CounterTerrorist))
            {
                throw new ArgumentException(ExceptionMessages.InvalidPlayerType);
            }

            return $"Successfully added player {username}.";
        }

        public string StartGame()
        {
            ICollection<IPlayer> alivePlayers = new List<IPlayer>();
            alivePlayers = this.playersRepository.Models
                .Where(p => p.IsAlive == true)
                .ToList();

            return this.map.Start(alivePlayers);
        }

        public string Report()
        {
            ICollection<IPlayer> allplayers = this.playersRepository.Models
                .OrderBy(t => t.GetType().Name)
                .ThenByDescending(p => p.Health)
                .ThenBy(p => p.Username)
                .ToList();
            StringBuilder sb = new StringBuilder();

            foreach (var player in allplayers)
            {
                sb.AppendLine($"{player.GetType().Name}: {player.Username}");
                sb.AppendLine($"--Health: {player.Health}");
                sb.AppendLine($"--Armor: {player.Armor}");
                sb.AppendLine($"--Gun: {player.Gun.Name}");
            }

            return sb.ToString().TrimEnd();


        }

       
    }
}
