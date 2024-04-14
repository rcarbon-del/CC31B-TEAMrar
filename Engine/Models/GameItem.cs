using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Models
{
    public class GameItem
    {
        public int ItemTypeID { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public string ImageName { get; set; }
        public bool IsUnique { get; set; }

        public GameItem(int itemTypeID, string name, int price, string imageName, bool isUnique = false)
        {
            ItemTypeID = itemTypeID;
            Name = name;
            Price = price;
            ImageName = imageName;
            IsUnique = isUnique;
        }
        public GameItem Clone()
        {
            return new GameItem(ItemTypeID, Name, Price, ImageName);
        }
    }
}
