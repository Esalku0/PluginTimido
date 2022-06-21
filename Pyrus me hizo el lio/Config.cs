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

        public float EscudoBase { get; set; } = 100;
        public float VidaBase { get; set; } = 350;

        public bool IsEnabled { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
