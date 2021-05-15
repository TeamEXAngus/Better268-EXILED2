using System;
using Exiled.API.Enums;
using Exiled.API.Features;

using Player = Exiled.Events.Handlers.Player;

namespace Better268
{
    public class Better268 : Plugin<Config>
    {
        private static readonly Lazy<Better268> LazyInstance = new Lazy<Better268>(valueFactory: () => new Better268());
        public static Better268 Instance => LazyInstance.Value;
        public override PluginPriority Priority { get; } = PluginPriority.Medium;

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