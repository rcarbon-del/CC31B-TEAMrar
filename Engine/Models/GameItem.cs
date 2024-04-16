using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Models
{
    public class GameItem
    {
        public int ItemTypeID { get; }
        public string Name { get; }
        public int Price { get; }
        public string ImageName { get; }
        public bool IsUnique { get; }

        public GameItem(int itemTypeID, string name, int price, string imageName, bool isUnique = false)
        {
            ItemTypeID = itemTypeID;
            Name = name;
            Price = price;
            ImageName = $"/Engine;component/Images/Locations/{imageName}";
            IsUnique = isUnique;
        }
        public GameItem Clone()
        {
            return new GameItem(ItemTypeID, Name, Price, ImageName, IsUnique);
        }
    }
}
