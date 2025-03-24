using System.Collections.Generic;
using Exiled.API.Enums;
using Exiled.API.Features.Spawn;
using Exiled.CustomRoles.API.Features;
using PlayerRoles;
using Exiled.Events;
using Exiled;
using Exiled.API;
using InventorySystem.Items.Pickups;
using Exiled.Events.EventArgs.Player;
using Exiled.Events.Features;
using System;



namespace site22utillitys
{
    public class MedicZombie : CustomRole, ICustomRole
    {
        private object activeHoTs;
        private object random;

        public int Chance { get; set; } = 0;
        public override uint Id { get; set; } = 101;
        public override int MaxHealth { get; set; } = 850;
        public override string Name { get; set; } = "<color=#FF0000>SCP-008 instance</color>";
        public override string Description { get; set; } = "";
        public override string CustomInfo { get; set; } = "SCP-008";
        public override RoleTypeId Role { get; set; } = RoleTypeId.Scp0492;
        public bool DamageInterruptsHot { get; private set; }


        public static void OnKill(DyingEventArgs ev)
        {





        }


    }
}
