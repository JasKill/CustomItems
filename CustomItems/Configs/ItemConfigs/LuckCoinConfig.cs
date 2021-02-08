using System.Collections.Generic;
using System.ComponentModel;
using CustomItems.API;

namespace CustomItems.ItemConfigs
{
    public class LuckCoinConfig
    {
        [Description("How long the coin will stay spawned inside the PD.")]
        public float Duration { get; set; } = 2;
        
        [Description("Where on the map items should spawn, and their % chance of spawning in each location.")]
        public Dictionary<SpawnLocation, float> SpawnLocations { get; set; } = new Dictionary<SpawnLocation, float>
        {
            { SpawnLocation.Inside012Locker, 100 }, 
            { SpawnLocation.Inside173Armory, 50 }
        };

        [Description("The Custom Item ID for this item.")]
        public int Id { get; set; } = 5;
        
        [Description("The description of this item show to players when they obtain it.")]
        public string Description { get; set; } = "This coin has magical properties when it is dropped inside of SCP-106's pocket dimension.";

        [Description("The name of this item shown to players when they obtain it.")]
        public string Name { get; set; } = "LC-119";
        
        [Description("How many of this item are allowed to naturally spawn on the map when a round starts. 0 = unlimited")]
        public int SpawnLimit { get; set; } = 1;
    }
}