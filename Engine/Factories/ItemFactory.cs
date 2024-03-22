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
        private static List<GameItem> _standardGameItems;
        static ItemFactory()
        {
            _standardGameItems = new List<GameItem>();
            _standardGameItems.Add(new GameItem(64, "Bear Jelly Coins", 1, "pack://application:,,,/Engine;component/Images/Items/BearJellyCoins.png"));
            _standardGameItems.Add(new GameItem(65, "Star Jelly", 10,"pack://application:,,,/Engine;component/Images/Items/StarJelly.png"));
            _standardGameItems.Add(new GameItem(66, "Cookie Powder", 10, "pack://application:,,,/Engine;component/Images/Items/CookiePowder.png"));
            _standardGameItems.Add(new GameItem(67, "Sugar Crystals", 10, "pack://application:,,,/Engine;component/Images/Items/SugarCrystals.png"));
            _standardGameItems.Add(new GameItem(68, "Insignia Cookie Treasures", 10, "pack://application:,,,/Engine;component/Images/Items/InsigniaCookieTreasure.png"));
            _standardGameItems.Add(new GameItem(69, "Crystal Jam", 10, "pack://application:,,,/Engine;component/Images/Items/CrystalJam.png"));
            _standardGameItems.Add(new GameItem(70, "Golden Croissant", 10, "pack://application:,,,/Engine;component/Images/Items/GoldenCroissant.png"));
            _standardGameItems.Add(new GameItem(71, "The Jelly of Memories", 10, "pack://application:,,,/Engine;component/Images/Items/TheJellyOfMemories.png"));
            _standardGameItems.Add(new Weapon(72, "Cookie Axe", 10, "pack://application:,,,/Engine;component/Images/Items/CookieAxe.png", 2, 7));
            _standardGameItems.Add(new Weapon(73, "Cookie Gun", 10, "pack://application:,,,/Engine;component/Images/Items/CookieGun.png", 2, 7));

        }
        public static GameItem CreateGameItem(int itemTypeID)
        {
            GameItem standardItem = _standardGameItems.FirstOrDefault(item => item.ItemTypeID == itemTypeID);
            if (standardItem != null)
            {
                return standardItem.Clone();
            }
            return null;
        }
    }
}
