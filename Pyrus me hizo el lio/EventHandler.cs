using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Exiled.API.Interfaces;
using Exiled.API.Features;
using Exiled.Events.EventArgs;
using Player = Exiled.API.Features.Player;
using Exiled.API.Enums;
using System.Threading.Tasks;


namespace Pyrus_me_hizo_el_lio
{
    internal class EventHandler
    {

        private readonly Plugin plugin;
        public Dictionary<string, Zombie> Zombies = new Dictionary<string, Zombie>();

        public EventHandler(Plugin plugin)
        {
            this.plugin = plugin;
        }

        public void Conexion(JoinedEventArgs ev)
        {
            Map.Broadcast(2, $"{ev.Player}se conectó");
        }

        public void AbrirPuerta(InteractingDoorEventArgs ev)
        {
            Map.Broadcast(2, $"Puerta abierta");
        }



        public void Zombie(ChangingRoleEventArgs ev)
        {
            Player player = ev.Player;

            if (Zombies.ContainsKey(ev.Player.UserId))
            {
                if (Config.RagueQuit == true)
                {
                    Zombies[ev.Player.UserId] = new Zombie(player.Id, player.Nickname, player.UserId);
                    ev.NewRole = RoleType.Scp0492;
                    ev.Player.Broadcast(6, "Al desconectarte siendo zombie, reapareces como zombie");
                }
            }
        }

        /*
        public void OnPlayerRole(DiedEventArgs ev)
        {
            if (ev.Killer.Role == RoleType.Scp049)
            {
                if (Zombies[ev.Id].Desconectado = true)
                {
                    
                }
            }
        }
        */

        public void OnPlayerLeft(LeftEventArgs ev)
        {
            if (ev.Player.Role == RoleType.Scp0492)
            {
                if (Config.RagueQuit==false)
                {
                    Config.RagueQuit = true;
                }
            }
        }





    }
}

