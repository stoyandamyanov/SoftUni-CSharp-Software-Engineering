using System;
using System.Collections.Generic;
using System.Text;

namespace ViceCity.Models.Players
{
    public class MainPlayer : Player
    {
        private const string mainPlayerName = "Tommy Vercetti";
        private  const int mainPlayerLifepoints = 100;
        public MainPlayer() 
            : base(mainPlayerName, mainPlayerLifepoints)
        {

        }
    }
}
