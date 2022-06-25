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
            public static bool RagueQuit { get; set; } = false;

        public Zombie(int playerId, string name, string steamId)
            {
                this.PlayerId = playerId;
                this.Name = name;
                this.SteamId = steamId;
            }

        public Zombie()
        {
                
        }

            //Metodo que nos devuelve todos los datos del jugador zombie en cadena de string
            public override string ToString()
            {
                return "[ PlayerId: " + PlayerId + ", Name: " + Name + ", SteamID: " + SteamId + ", Desconectado: " + Desconectado + " ]";
            }


  }
}
