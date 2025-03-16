using System.Collections.Generic;
using System.ComponentModel;
using Exiled.API.Enums;
using Exiled.API.Features.Attributes;
using Exiled.API.Features.Spawn;
using Exiled.CustomItems.API.Features;
using Exiled.Events.EventArgs.Player;
using InventorySystem.Items.Firearms.Attachments;
using PlayerStatsSystem;
using YamlDotNet.Serialization;
using Exiled.Events.Handlers;

namespace site22utillitys;

public class A7tranq
{
    [CustomItem(ItemType.GunA7)]
    public class tranq : CustomWeapon
    {
        public ItemType ItemType { get; set; } = ItemType.GunA7;

        public override uint Id { get; set; } = 102;

        public override string Name { get; set; } = "A7-tranq";

        public override string Description { get; set; } = "used to stun or slow targets";

        public override float Weight { get; set; } = 3.25f;

        public override byte ClipSize { get; set; } = 3;

        public override bool ShouldMessageOnGban { get; } = true;

        [YamlIgnore]
        public override float Damage { get; set; } = 10;

        public override SpawnProperties SpawnProperties { get; set; } = new()
        {
            Limit = 1,
            DynamicSpawnPoints = new List<DynamicSpawnPoint>
            {
                new()
                {
                    Chance = 100,
                    Location = SpawnLocationType.Inside049Armory,
                },
            },
        };





        protected void Target(ShotEventArgs ev)
        {


            ev.Target.EnableEffect(EffectType.Ensnared, 3, 3f, true);

        }



        



    }
}