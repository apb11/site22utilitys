using Exiled.API.Interfaces;
using System;
using System.ComponentModel;

namespace site22utillitys;

public class Config : IConfig
{
    [Description("Is the plugin enabled?")]
    public bool IsEnabled { get; set; } = true;

    [Description("Are debug messages displayed?")]
    public bool Debug { get; set; } = false;
    public bool EnableInfoLogs { get; internal set; }

    internal static void LoadItems()
    {
        throw new NotImplementedException();
    }

    internal void LoadRoles()
    {
        throw new NotImplementedException();
    }
}