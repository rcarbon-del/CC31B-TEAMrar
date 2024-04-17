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
                        new Monster("Giant Gingerbread Ogre ", "GiantGingerbreadOgre.png", 4, 4, 5, 1, 100, 10);

                    gingerbread.CurrentWeapon = ItemFactory.CreateGameItem(1501);

                    AddLootItem(gingerbread, 64, 25);
                    AddLootItem(gingerbread, 65, 75);
                    return gingerbread;
                case 2:
                    Monster doughogres =
                        new Monster("Dough Ogres", "DoughOgres.png", 5, 5, 5, 1, 100, 5);

                    doughogres.CurrentWeapon = ItemFactory.CreateGameItem(1502);

                    AddLootItem(doughogres, 64, 25);
                    AddLootItem(doughogres, 65, 75);
                    return doughogres;
                case 3:
                    Monster burntCookies =
                        new Monster("Burnt Cookies", "BurntCookies.png", 10, 10, 10, 3, 100, 3);

                    burntCookies.CurrentWeapon = ItemFactory.CreateGameItem(1503);

                    AddLootItem(burntCookies, 64, 25);
                    AddLootItem(burntCookies, 65, 75);
                    return burntCookies;
                case 4:
                    Monster overbakedCupcake =
                        new Monster("Overbaked Cupcake", "OverbakedCupcake.png", 5, 5, 5, 1, 100, 15);

                    overbakedCupcake.CurrentWeapon = ItemFactory.CreateGameItem(1504);

                    AddLootItem(overbakedCupcake, 64, 25);
                    AddLootItem(overbakedCupcake, 65, 75);
                    return overbakedCupcake;
                case 5:
                    Monster notsoSmore =
                        new Monster("notsoSmore", "NotSoSmore.png", 4, 4, 5, 1, 100, 10);

                    notsoSmore.CurrentWeapon = ItemFactory.CreateGameItem(1505);

                    AddLootItem(notsoSmore, 64, 25);
                    AddLootItem(notsoSmore, 65, 75);
                    return notsoSmore;
                case 6:
                    Monster theTeeth =
                        new Monster("The Teeth", "TheTeeth.png", 10, 10, 10, 3, 100, 20);

                    theTeeth.CurrentWeapon = ItemFactory.CreateGameItem(1506);

                    AddLootItem(theTeeth, 64, 25);
                    AddLootItem(theTeeth, 65, 75);
                    return theTeeth;
                default:
                    throw new ArgumentException(string.Format("MonsterType '{0}' does not exist", monsterID));
            }
        }
        private static void AddLootItem(Monster monster, int itemID, int percentage)
        {
            if (RandomNumberGenerator.NumberBetween(1, 100) <= percentage)
            {
                monster.AddItemToInventory(ItemFactory.CreateGameItem(itemID));
            }
        }
    }
}
