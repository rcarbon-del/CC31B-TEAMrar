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
            _standardGameItems.Add(new GameItem(64, "Bear Jelly Coins", 1,""));
            _standardGameItems.Add(new GameItem(65, "Star Jelly", 10,""));
            _standardGameItems.Add(new GameItem(66, "Cookie Powder", 10, ""));
            _standardGameItems.Add(new GameItem(67, "Sugar Crystals", 10, ""));
            _standardGameItems.Add(new GameItem(68, "Insignia Cookie Treasures", 10, ""));
            _standardGameItems.Add(new GameItem(69, "Crystal Jam", 10, ""));
            _standardGameItems.Add(new GameItem(70, "Golden Croissant", 10, ""));
            _standardGameItems.Add(new Weapon(71, "Cookie Axe", 10, "", 2, 7));
            _standardGameItems.Add(new Weapon(72, "Cookie Gun", 10, "", 2, 7));

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
