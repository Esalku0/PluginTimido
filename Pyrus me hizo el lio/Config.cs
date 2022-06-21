using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Exiled.API.Interfaces;
using Exiled.API.Features;
using Exiled.Events.EventArgs;
using Exiled.API.Enums;
using System.Threading.Tasks;

namespace Pyrus_me_hizo_el_lio
{
    internal class Config : IConfig
    {
        //Cantidad de escudo base que recibe el zombie al crearse
        public double EscudoBase { get; set; } = 100;
        //Cantidad de vida inicial del zombie
        public double VidaBase { get; set; } = 350;
        //Booleano que guarda si el zombie se ha desconectado o no
        public bool RagueQuit { get; set; } = false;
        //Variable que almacena el porcentaje de vida que se cura por golpe
        public double vidaAlAtacar = 10;
        //Variable que almacena el porcentaje de vida que se cura por asesinato
        public double vidaAlAsesinar = 50;

        public string Mensaje { get; set; } = "Tu rol es de Zombie debido a tu desconexion";


        public double VidaAlAtacar  { get { return vidaAlAtacar; } set { vidaAlAtacar = value; } }
        public double VidaAlAsesinar { get { return vidaAlAsesinar; } set { vidaAlAsesinar = value; } }





        public bool IsEnabled { get => throw new NotImplementedException(); set => throw new NotImplementedException();}



    }
}
