using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Achievements.Handlers;
using Exiled.API.Enums;
using Exiled.API.Features;
using Player = Exiled.Events.Handlers.Player;
using Server = Exiled.Events.Handlers.Server;

namespace Pyrus_me_hizo_el_lio
{
    internal class Plugin : Plugin<Config>
    {

		public override string Author { get; } = "Luxitoh";
		public override string Name { get; } = "Prueba";
		public override string Prefix { get; } = "Prueba";
		public override Version RequiredExiledVersion { get; } = new Version(5, 0, 0);
		public const string VersionStr = "3.3.2";
		public override Version Version { get; } = new Version(VersionStr);
		public EventHandler EventHandlers { get; private set; }


		public override void OnEnabled()
		{
			EventHandlers = new EventHandler(this);

			Player.Joined += EventHandlers.Conexion;
			Player.InteractingDoor += EventHandlers.AbrirPuerta;
			Player.ChangingRole += EventHandlers.ZombieEntra;
			Player.Left += EventHandlers.OnPlayerLeft;
			Player.Joined += EventHandlers.OnPlayerConnect;
			base.OnEnabled();
		}

		public override void OnDisabled()
		{
			Player.Joined -= EventHandlers.Conexion;
			Player.InteractingDoor -= EventHandlers.AbrirPuerta;
			Player.ChangingRole -= EventHandlers.ZombieEntra;
			Player.Left -= EventHandlers.OnPlayerLeft;
			Player.Joined -= EventHandlers.OnPlayerConnect;
			EventHandlers = null;
			base.OnDisabled();
		}

		

	}
}
