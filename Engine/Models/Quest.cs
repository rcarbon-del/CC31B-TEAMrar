using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Models
{
    public class Quest
    {
        private int v1;
        private string v2;
        private string v3;
        private ItemQuantity itemQuantity;
        private int v4;
        private int v5;

        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public List<ItemQuantity> ItemsToComplete { get; set; }
        public int RewardExpPoints { get; set; }
        public int RewardGold { get; set; }
        public List<ItemQuantity> RewardItems { get; set; }
        public Quest(int id, string name, string description, List<ItemQuantity> itemsToComplete, int rewardExpPoints, int rewardGold, List<ItemQuantity> rewardItems)
        {
            ID = id;
            Name = name;
            Description = description;
            ItemsToComplete = itemsToComplete;
            RewardExpPoints = rewardExpPoints;
            RewardGold = rewardGold;
            RewardItems = rewardItems;
        }

        public Quest(int v1, string v2, string v3, ItemQuantity itemQuantity, int v4, int v5, List<ItemQuantity> rewardItems)
        {
            this.v1 = v1;
            this.v2 = v2;
            this.v3 = v3;
            this.itemQuantity = itemQuantity;
            this.v4 = v4;
            this.v5 = v5;
            RewardItems = rewardItems;
        }
    }
}
