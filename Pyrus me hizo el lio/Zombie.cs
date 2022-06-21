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
            public bool Desconectado = false;
            public Dictionary<string, Zombie> Zombies = new Dictionary<string, Zombie>();


            public Zombie(int playerId, string name, string steamId)
            {
                this.PlayerId = playerId;
                this.Name = name;
                this.SteamId = steamId;
            }

            public override string ToString()
            {
                return "[ PlayerId: " + PlayerId + ", Name: " + Name + ", SteamID: " + SteamId + ", Desconectado: " + Desconectado + " ]";
            }


  }
}
