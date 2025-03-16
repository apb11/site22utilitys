


using System.Collections.Generic;
using Exiled.API.Enums;
using Exiled.API.Features;
using Exiled.API.Features.Attributes;
using Exiled.API.Features.Spawn;
using Exiled.CustomItems.API.Features;
using Exiled.Events.EventArgs.Player;

using Targeting;
using Player = Exiled.Events.Handlers.Player;


namespace site22utillitys;

public class amnestics
{
    [CustomItem(ItemType.Painkillers)]
    public class amnesticspills : CustomItem
    {
        public ItemType ItemType { get; set; } = ItemType.Painkillers;

        public override uint Id { get; set; } = 101;

        public override string Name { get; set; } = "amnestics pill";

        public override string Description { get; set; } = "does funny things";

        public override float Weight { get; set; } = 0.5f;

        public override SpawnProperties SpawnProperties { get; set; } = new()
        {
            Limit = 1,
            DynamicSpawnPoints = new List<DynamicSpawnPoint>
            {
                new()
                {
                    Chance = 100,
                    Location = SpawnLocationType.InsideHid,
                },
            },
        };

        protected override void SubscribeEvents()
        {
            Player.UsingItem += OnUsingItem;
            base.SubscribeEvents();
        }

        protected override void UnsubscribeEvents()
        {
            Player.UsingItem -= OnUsingItem;
            base.UnsubscribeEvents();
        }

        public void OnUsingItem(UsingItemEventArgs ev)
        {
            if (!Check(ev.Player.CurrentItem))
                return;
            
            ev.Player.EnableEffect(EffectType.Traumatized, 10, 250f, true);
            
            
            


        }

    }
}
