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
    internal class Jugador : Plugin<Config>
    {



        public bool partidaAcabada = false;
        private readonly Zombie plugin;
        Zombie z1;
        public Jugador(Zombie plugin) => this.plugin = plugin;



        public void CreateZombie(VerifiedEventArgs ev)
        {
            Player jogador = ev.Player;
            z1 = new Zombie(jogador.Id, jogador.Nickname, jogador.UserId);
        }




        public void SiCambiaRol(ChangingRoleEventArgs ev)
        {
            Player player = ev.Player;
            if (this.plugin.Zombies.ContainsKey(player.UserId))
            {
                if (plugin.Zombies[player.UserId].Disconnected && Config.RagueQuit)
                {
                    plugin.Zombies[player.UserId].Disconnected = false;
                    ev.NewRole = RoleType.Scp0492;
                }
            }
        }















        //Metodo de prueba que avisa del jugador que se ha conectado al servidor
        public void OnConnect(JoinedEventArgs ev)
        {
            Map.Broadcast(duration: 6, message:$"{ev.Player} has connected");
     
        }

        //Metodo de prueba que avisa que jugador se ha desconectado                                                                                                                             
        public void OnLeft(LeftEventArgs ev)
        {
            Map.Broadcast(duration: 6, message: $"{ev.Player} has Left");
        }
        
        

    }
}
