using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pyrus_me_hizo_el_lio
{
    internal class Zombie
    {

            public int PlayerId;
            public string Name;
            public string SteamId;
            public bool Undead = false;
            public bool Disconnected = false;

            public Zombie(int playerId, string name, string steamId, string ipAddress)
            {
                this.PlayerId = playerId;
                this.Name = name;
                this.SteamId = steamId;
            }
        public Zombie()
        {

        }

            public override string ToString()
            {
                return "[ PlayerId: " + PlayerId + ", Name: " + Name + ", SteamID: " + SteamId + ", Undead: " + Undead + ", Disconnected: " + Disconnected + " ]";
            }


        }
}
