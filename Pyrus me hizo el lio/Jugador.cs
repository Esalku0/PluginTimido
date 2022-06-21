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


        public void OnPlayerVerified(VerifiedEventArgs ev)
        {
            Player jogador = ev.Player;
            Zombie zomb1 = new Zombie();

            if (Zombie.ContainsKey(ev.Player.UserId))
            {
                Z[ev.Player.UserId] = new Zombie(jogador.Id, jogador.Nickname, jogador.UserId, jogador.IPAddress);
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
