﻿using System.ComponentModel;
using Exiled.API.Interfaces;

namespace Better268
{
    public sealed class Config : IConfig
    {
        [Description("Whether or not the plugin is enabled on this server.")]
        public bool IsEnabled { get; set; } = true;
    }
}