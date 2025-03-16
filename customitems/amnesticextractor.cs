using System.Collections.Generic;
using CustomPlayerEffects;
using Exiled.API.Enums;
using Exiled.API.Features.Attributes;
using Exiled.API.Features.Spawn;
using Exiled.CustomItems.API.Features;
using Exiled.Events.EventArgs.Player;
using Player = Exiled.Events.Handlers.Player;


namespace site22utillitys;

public class amnesticextractor
{
    [CustomItem(ItemType.Medkit)]
    public class amnesticextractorItem : CustomItem
    {
        public ItemType ItemType { get; set; } = ItemType.Medkit;

        public override uint Id { get; set; } = 100;

        public override string Name { get; set; } = "amnestic extractor";

        public override string Description { get; set; } = "extract amnestics";

        public override float Weight { get; set; } = 0.5f;

        public override SpawnProperties SpawnProperties { get; set; } = new()
        {
            Limit = 1,
            DynamicSpawnPoints = new List<DynamicSpawnPoint>
            {
                new()
                {
                    Chance = 0,
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

        private void OnUsingItem(UsingItemEventArgs ev)
        {
            if (!true && ev.Player.IsEffectActive<AmnesiaVision>())
                return;

            CustomItem.Get(100).Give(ev.Player);

    
        }
        
    }
}