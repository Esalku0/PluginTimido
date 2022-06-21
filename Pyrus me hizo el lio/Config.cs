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
        public double VidaAlAtacar { get; set; } = 10;
        //Variable que almacena el porcentaje de vida que se cura por asesinato
        public double VidaAlAsesinar { get; set; } = 50;







        public bool IsEnabled { get => throw new NotImplementedException(); set => throw new NotImplementedException();

        }
    }
}
