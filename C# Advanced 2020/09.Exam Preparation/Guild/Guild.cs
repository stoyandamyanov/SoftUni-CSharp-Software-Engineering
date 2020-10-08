using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Guild
{
    public class Guild
    {
        private readonly List<Player> roster;

        private Guild()
        {
            this.roster = new List<Player>();
        }

        public Guild(string name, int capacity)
            : this()
        {
            this.Name = name;
            this.Capacity = capacity;
        }

        public string Name { get; set; }

        public int Capacity { get; set; }

        public void AddPlayer(Player player)
        {
            if (this.roster.Count + 1 <= this.Capacity)
            {
                this.roster.Add(player);
            }
        }

        public bool RemovePlayer(string name)
        {
            Player player = this.roster
                .FirstOrDefault(a => a.Name == name);

            if (player != null)
            {
                this.roster.Remove(player);

                return true;
            }

            return false;
        }

        public void PromotePlayer(string name)
        {
            Player player = this.roster
                .FirstOrDefault(a => a.Name == name);

            if (player.Rank != "Member")
            {
                player.Rank = "Member";
            }
        }

        public void DemotePlayer(string name)
        {
            Player player = this.roster
                .FirstOrDefault(a => a.Name == name);

            if (player.Rank != "Trial")
            {
                player.Rank = "Trial";
            }
        }

        public Player[] KickPlayersByClass(string Class)
        {
            
            List<Player> total = new List<Player>();
            Player[] totalPlayers = total.ToArray();
            

            while (true)
            {
                Player player = this.roster
                .FirstOrDefault(a => a.Class == Class);

                total.Add(player);
                roster.Remove(player);
                if(roster.All(a => a.Class != Class))
                {
                   totalPlayers = total.ToArray();
                   break;
                }
                    
            }
            

            return totalPlayers;
            
        }

        public int Count
        {
            get
            {
                return this.roster.Count();
            }
        }

        public string Report()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Players in the guild: {this.Name}");

            foreach (var item in this.roster)
            {
                sb.AppendLine(item.ToString());
            }

            return sb.ToString().TrimEnd();
        }
    }
}
