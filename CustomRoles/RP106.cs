using System.Collections.Generic;
using System.Numerics;
using Exiled.API.Enums;
using Exiled.API.Features.Attributes;
using Exiled.API.Features.Spawn;
using Exiled.CustomRoles.API.Features;
using Exiled.Events.EventArgs.Scp106;
using MapEditorReborn.Events.EventArgs;
using PlayerRoles;


namespace site22utillitys
{
    [CustomRole(RoleTypeId.Scp106)]
    public class rp106 : CustomRole
    {
        public int Chance { get; set; } = 0;





        public override uint Id { get; set; } = 100;

        public override RoleTypeId Role { get; set; } = RoleTypeId.Scp106;

        public override int MaxHealth { get; set; } = 2350;

        public override string Name { get; set; } = "RP 106";

        public override string Description { get; set; } =
            "an Scp 106 used for RPs";


        public override string CustomInfo { get; set; } = "RP 106";

        public override bool KeepInventoryOnSpawn { get; set; } = false;

        public override bool KeepRoleOnDeath { get; set; } = false;

        public override bool RemovalKillsPlayer { get; set; } = true;



        public override SpawnProperties SpawnProperties { get; set; } = new()
        {
            Limit = 0,
            RoleSpawnPoints = new List<RoleSpawnPoint>
            {
                new()
                {
                    Role = RoleTypeId.Scp106,
                    Chance = 100,
                },
            },
        };

        public override List<string> Inventory { get; set; } = new()
        {
        };

        







    }
}