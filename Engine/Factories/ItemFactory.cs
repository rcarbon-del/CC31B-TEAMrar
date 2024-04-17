using Engine.Actions;
using Engine.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Engine.Factories
{
    public static class ItemFactory
    {
        private static readonly List<GameItem> _standardGameItems = new List<GameItem>();
        static ItemFactory()
        {
            BuildMiscellaneousItem(64, "Bear Jelly Coins", 1, "/Engine;component/Images/Items/BearJellyCoins.png");
            BuildMiscellaneousItem(65, "Star Jelly", 10, "/Engine;component/Images/Items/StarJelly.png");
            BuildMiscellaneousItem(66, "Cookie Powder", 10, "/Engine;component/Images/Items/CookiePowder.png");
            BuildMiscellaneousItem(67, "Sugar Crystals", 10, "/Engine;component/Images/Items/SugarCrystals.png");
            BuildMiscellaneousItem(68, "Insignia Cookie Treasures", 10, "/Engine;component/Images/Items/InsigniaCookieTreasure.png");
            BuildMiscellaneousItem(69, "Crystal Jam", 10, "/Engine;component/Images/Items/CrystalJam.png");
            BuildMiscellaneousItem(70, "Golden Croissant", 10, "/Engine;component/Images/Items/GoldenCroissant.png");
            BuildMiscellaneousItem(71, "The Jelly of Memories", 10, "/Engine;component/Images/Items/TheJellyOfMemories.png");

            BuildWeapon(72, "Cookie Axe", 10, "/Engine;component/Images/Items/CookieAxe.png", 2, 7);
            BuildWeapon(73, "Cookie Gun", 10, "/Engine;component/Images/Items/CookieGun.png", 2, 7);

            BuildMiscellaneousItem(74, "Wood for Bridge Repair", 10, "/Engine;component/Images/Items/WoodForBridgeRepair.png");
            BuildMiscellaneousItem(75, "Mayor's Special Butter", 10, "/Engine;component/Images/Items/MayorsSpecialButter.png");
            BuildMiscellaneousItem(76, "Special Ingredient", 10, "/Engine;component/Images/Items/SpecialIngredient.png");
            BuildMiscellaneousItem(77, "Treasure Map", 10, "/Engine;component/Images/Items/TreasureMap.png");
            BuildMiscellaneousItem(78, "Cookie Dough Spell", 10, "/Engine;component/Images/Items/CookieDoughSpell.png");
            BuildMiscellaneousItem(79, "Choco Pirate's Letter", 10, "/Engine;component/Images/Items/ChocoPirateLetter.png");
            BuildMiscellaneousItem(80, "Matcha Tea Time Alliance Membership Card", 10, "/Engine;component/Images/Items/MatchaTeaTimeAllianceCard.png");
            BuildMiscellaneousItem(81, "Not so Special Butter", 10, "/Engine;component/Images/Items/NotSoSpecialButter.png");

            BuildWeapon(1501, "Sugar of Death", 0, "/Engine;component/Images/Items/sugarOfDeath.jpg", 0, 2); // gingerbread : sugarOfDeath
            BuildWeapon(1502, "MolDough", 0, "/Engine;component/Images/Items/molDough.jpg", 0, 2); //doughogres : molDough
            BuildWeapon(1503, "Cookie Cutter", 0, "/Engine;component/Images/Items/cookieCutter.jpg", 0, 2); //burntCookies : cookieCutter
            BuildWeapon(1504, "Dark Crust Magic", 0, "/Engine;component/Images/Items/darkCrustMagic.jpg", 0, 2); //overbakedCupcake: darkCrustMagic
            BuildWeapon(1505, "Stick", 0, "/Engine;component/Images/Items/stick.jpg", 0, 2); //notsoSmore : stick
            BuildWeapon(1506, "Cavittack", 0, "/Engine;component/Images/Items/Cavittack.jpg", 0, 2); //theTeeth : Cavittack

            BuildHealingItem(2001, "SugarCubes", 5, 2, "/Engine;component/Images/Items/SugarCubes.jpg"); //SugarCubes

            BuildMiscellaneousItem(3001, "Sugar Cane", 1, "/Engine;component/Images/Items/sugarCane.jpg"); // sugarCane
            BuildMiscellaneousItem(3002, "Bamboo Grinder", 1, "/Engine;component/Images/Items/bambooGrinder.png");// bambooGrinder

        }
        public static GameItem CreateGameItem(int itemTypeID)
        {
            return _standardGameItems.FirstOrDefault(item => item.ItemTypeID == itemTypeID)?.Clone();
        }
        private static void BuildMiscellaneousItem(int id, string name, int price, string ImageName)
        {
            _standardGameItems.Add(new GameItem(GameItem.ItemCategory.Miscellaneous, id, name, price, ImageName));
        }
        private static void BuildWeapon(int id, string name, int price, string imageName,
                                        int minimumDamage, int maximumDamage)
        {
            GameItem weapon = new GameItem(GameItem.ItemCategory.Weapon, id, name, price, imageName, true);
            weapon.Action = new AttackWithWeapon(weapon, minimumDamage, maximumDamage);
            _standardGameItems.Add(weapon);
        }
        private static void BuildHealingItem(int id, string name, int price, int hitPointsToHeal, string imageName)
        {
            GameItem item = new GameItem(GameItem.ItemCategory.Consumable, id, name, price, imageName);
            item.Action = new Heal(item, hitPointsToHeal);
            _standardGameItems.Add(item);
        }
        public static string ItemName(int itemTypeID)
        {
            return _standardGameItems.FirstOrDefault(i => i.ItemTypeID == itemTypeID)?.Name ?? "";
        }
    }
}