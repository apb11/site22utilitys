using System;
using Exiled.API.Features;
using Exiled.CreditTags;
using Exiled.CustomItems.API.Features;
using Exiled.CustomRoles;
using site22utillitys.Events;

namespace site22utillitys
{
    public class Main : Plugin<Config>
    {
        private object _serverHandler;

        public override string Name => "Site22utillitys";
        public override string Author => "Apbblox11";
        public override string Prefix { get; } = "22utillitys";
        public override Version RequiredExiledVersion { get; } = new Version(9, 4, 0);
        public override Version Version => new Version(1, 1, 4);
        public static Main Instance { get; private set; }

        public override void OnEnabled()
        {
            Instance = this;
            _serverHandler = new ServerHandler();
            Config.LoadItems();
            Config.LoadRoles();

            Log.Debug("Registering items..");
            Log.Debug("Registering Roles..");
            CustomItem.RegisterItems(overrideClass: Config);
            

            if (Instance.Config.EnableInfoLogs)
            {
                Log.Info("customitem");
                Log.Info("loaded");
                Log.Info("");
                Log.Info("");
                Log.Info("");
                Log.Info("");
                Log.Info("===========================================");
            }
            base.OnEnabled();
        }

        public override void OnDisabled()
        {
            CustomItem.UnregisterItems();
            
            if (Instance.Config.EnableInfoLogs)
            {
                Log.Info("");
                Log.Info("");
                Log.Info("");
                Log.Info("Items are disabled");
            }
            Instance = null;
            base.OnDisabled();
        }
    }
}
