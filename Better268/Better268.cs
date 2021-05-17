using System;
using Exiled.API.Enums;
using Exiled.API.Features;

using Player = Exiled.Events.Handlers.Player;

namespace Better268
{
    public class Better268 : Plugin<Config>
    {
        private static Better268 singleton = new Better268();
        public static Better268 Instance => singleton;
        public override PluginPriority Priority { get; } = PluginPriority.Medium;

        public override Version RequiredExiledVersion { get; } = new Version(2, 10, 0);
        public override Version Version { get; } = new Version(1, 0, 1);

        //Event handler for player events
        private Handlers.TriggeringTesla triggeringTesla;

        private Better268()
        {
        }

        //Run startup code when plugin is enabled
        public override void OnEnabled()
        {
            RegisterEvents();
        }

        //Run shutdown code when plugin is disabled
        public override void OnDisabled()
        {
            UnregisterEvents();
        }

        //Plugin startup code
        public void RegisterEvents()
        {
            triggeringTesla = new Handlers.TriggeringTesla();

            Player.TriggeringTesla += triggeringTesla.OnTriggeringTesla;
        }

        //Plugin shutdown code
        public void UnregisterEvents()
        {
            Player.TriggeringTesla -= triggeringTesla.OnTriggeringTesla;

            triggeringTesla = null;
        }
    }
}