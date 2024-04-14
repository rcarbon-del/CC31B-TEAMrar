using Engine.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Factories
{
    public static class ItemFactory
    {
        private static readonly List<GameItem> _standardGameItems = new List<GameItem>();
        static ItemFactory()
        {
            _standardGameItems = new List<GameItem>();
            _standardGameItems.Add(new GameItem(64, "Bear Jelly Coins", 1, "BearJellyCoins.png"));
            _standardGameItems.Add(new GameItem(65, "Star Jelly", 10,"StarJelly.png"));
            _standardGameItems.Add(new GameItem(66, "Cookie Powder", 10, "CookiePowder.png"));
            _standardGameItems.Add(new GameItem(67, "Sugar Crystals", 10, "SugarCrystals.png"));
            _standardGameItems.Add(new GameItem(68, "Insignia Cookie Treasures", 10, "InsigniaCookieTreasure.png"));
            _standardGameItems.Add(new GameItem(69, "Crystal Jam", 10, "CrystalJam.png"));
            _standardGameItems.Add(new GameItem(70, "Golden Croissant", 10, "GoldenCroissant.png"));
            _standardGameItems.Add(new GameItem(71, "The Jelly of Memories", 10, "TheJellyOfMemories.png"));
            _standardGameItems.Add(new Weapon(72, "Cookie Axe", 10, "CookieAxe.png", 2, 7));
            _standardGameItems.Add(new Weapon(73, "Cookie Gun", 10, "CookieGun.png", 2, 7));

        }
        public static GameItem CreateGameItem(int itemTypeID)
        {
            GameItem standardItem = _standardGameItems.FirstOrDefault(item => item.ItemTypeID == itemTypeID);
            if (standardItem != null)
            {
                if (standardItem is Weapon)
                {
                    return (standardItem as Weapon).Clone();
                }
                return standardItem.Clone();
            }
            return null;
        }
    }
}
