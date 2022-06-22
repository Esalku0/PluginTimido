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
        public Jugador(Zombie plugin) => this.plugin = plugin;


        //Creamos el metodo que nos permite instanciar un zombie
        public void CrearZombie(VerifiedEventArgs ev)
        {
            Player player = ev.Player;
            if (!this.plugin.Zombies.ContainsKey(ev.Player.UserId))
            {
                this.plugin.Zombies[ev.Player.UserId] = new Zombie(player.Id, player.Nickname, player.UserId);
            }
        }


        //Comprobamos si el jugador tiene una id, si el jugador esta desconectado y se conecta, el jugador pasara al rol de zombie.
        public void SiCambiaRol(ChangingRoleEventArgs ev)
        {
            Player player = ev.Player;
            if (partidaAcabada==false)
            {
                if (this.plugin.Zombies.ContainsKey(player.UserId))
                {
                    if (plugin.Zombies[player.UserId].Desconectado && Config.RagueQuit)
                    {
                        plugin.Zombies[player.UserId].Desconectado = false;


                        /* Intento para spawnear al zombie en la sala del 049
                         * 
                        ev.Player.Position = RoomType.Hcz049()
                        */


                        /*Intento de recorrer la lista de jugadores y sacar al scp049 para enviarle un mensaje
                         * 
                         * 
                        foreach (Player players in Exiled.API.Features.Player.List)
                        {
                            if (ev.Player.Role.Is<>
                            {

                            }
                        }

                       */

                        ev.NewRole = RoleType.Scp0492;
                        ev.Player.Broadcast(duration: 7, message: Config.Mensaje);

                    }
                }
            }
        }

        //Comprobamos si la configuracion de la recuperacion de vida por ataque es menor que 0
        public double ComprobarVidaAtaque()
        {
            if (Config.VidaAlAtacar<0)
            {
                Config.vidaAlAtacar = 0;
            }
            return Config.VidaAlAtacar;
        }

        //Comprobamos si la configuracion de la recuperacion de vida por asesinato es menor que 0
        public double ComprobarVidaAsesinar()
        {
            if (Config.VidaAlAsesinar < 0)
            {
                Config.VidaAlAsesinar = 0;
            }
            return Config.VidaAlAsesinar;
        }












        //METODOS DE PRUEBA
        //
        //Metodo de prueba que avisa del jugador que se ha conectado al servidor
        public void Conexion(JoinedEventArgs ev)
        {
            Map.Broadcast(duration: 6, message:$"{ev.Player} se conectó");
     
        }

        //Metodo de prueba que avisa que jugador se ha desconectado                                                                                                                             
        public void Desconexion(LeftEventArgs ev)
        {
            Map.Broadcast(duration: 6, message: $"{ev.Player} salió del servidor");
        }
        
        

    }
}
