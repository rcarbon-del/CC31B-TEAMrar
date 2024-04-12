using Engine.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Factories
{
    public static class MonsterFactory
    {
        public static Monster GetMonster(int monsterID)
        {
            switch (monsterID)
            {
                case 1:
                    Monster gingerbread =
                        new Monster("Giant Gingerbread Ogre ", "GiantGingerbreadOgre.png", 4, 4, 5, 1);
                    AddLootItem(gingerbread, 9001, 25);
                    AddLootItem(gingerbread, 9002, 75);
                    return gingerbread;
                case 2:
                    Monster doughogres =
                        new Monster("Dough Ogres", "DoughOgres.png", 5, 5, 5, 1);
                    AddLootItem(doughogres, 9003, 25);
                    AddLootItem(doughogres, 9004, 75);
                    return doughogres;
                case 3:
                    Monster burntCookies =
                        new Monster("Burnt Cookies", "BurntCookies.png", 10, 10, 10, 3);
                    AddLootItem(burntCookies, 9005, 25);
                    AddLootItem(burntCookies, 9006, 75);
                    return burntCookies;
                case 4:
                    Monster overbakedCupcake =
                        new Monster("Overbaked Cupcake", "OverbakedCupcake.png", 5, 5, 5, 1);
                    AddLootItem(overbakedCupcake, 9007, 25);
                    AddLootItem(overbakedCupcake, 9008, 75);
                    return overbakedCupcake;
                case 5:
                    Monster notsoSmore =
                        new Monster("notsoSmore", "NotSoSmore.png", 4, 4, 5, 1);
                    AddLootItem(notsoSmore, 9009, 25);
                    AddLootItem(notsoSmore, 9010, 75);
                    return notsoSmore;
                case 6:
                    Monster theTeeth =
                        new Monster("The Teeth", "TheTeeth.png", 10, 10, 10, 3);
                    AddLootItem(theTeeth, 9009, 25);
                    AddLootItem(theTeeth, 9010, 75);
                    return theTeeth;
                default:
                    throw new ArgumentException(string.Format("MonsterType '{0}' does not exist", monsterID));
            }
        }
        private static void AddLootItem(Monster monster, int itemID, int percentage)
        {
            if (RandomNumberGenerator.NumberBetween(1, 100) <= percentage)
            {
                monster.Inventory.Add(new ItemQuantity(itemID, 1));
            }
        }
    }
}
