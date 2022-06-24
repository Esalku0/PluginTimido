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
            Map.Broadcast(6, $"{ev.Player}se conectó");
        }

        public void AbrirPuerta(InteractingDoorEventArgs ev)
        {
            Map.Broadcast(6, $"fgddfgd");
        }



        public void zombie(ChangingRoleEventArgs ev)
        {
            Player player = ev.Player;

            if (Zombies.ContainsKey(ev.Player.UserId))
            {
                if (Zombies[player.UserId].Desconectado ==false && Config.RagueQuit == true)
                {
                    Zombies[ev.Player.UserId] = new Zombie(player.Id, player.Nickname, player.UserId);
                    ev.NewRole = RoleType.Scp0492;
                }
            }
        }

        public void ZombieSaliendose(LeftEventArgs ev)
        {
            if (ev.Player.IsScp.scp)
            {

            }
        }


        public double ComprobarVidaAtaque()
        {
            if (Config.VidaAlAtacar < 0)
            {
                Config.vidaAlAtacar = 0;
            }
            return Config.VidaAlAtacar;
        }

        public double ComprobarVidaAsesinar()
        {
            if (Config.VidaAlAsesinar < 0)
            {
                Config.VidaAlAsesinar = 0;
            }
            return Config.VidaAlAsesinar;
        }



    }
}

