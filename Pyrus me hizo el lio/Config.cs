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
        public float EscudoBase { get; set; } = 100;
        //Cantidad de vida inicial del zombie
        public float VidaBase { get; set; } = 350;
        //Booleano que guarda si el zombie se ha desconectado o no
        public bool RagueQuit { get; set; } = false;









        public bool IsEnabled { get => throw new NotImplementedException(); set => throw new NotImplementedException();

        }
    }
}
