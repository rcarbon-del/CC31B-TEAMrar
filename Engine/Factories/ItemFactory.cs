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
            BuildMiscellaneousItem(64, "Bear Jelly Coins", 1, "BearJellyCoins.png");
            BuildMiscellaneousItem(65, "Star Jelly", 10, "StarJelly.png");
            BuildMiscellaneousItem(66, "Cookie Powder", 10, "CookiePowder.png");
            BuildMiscellaneousItem(67, "Sugar Crystals", 10, "SugarCrystals.png");
            BuildMiscellaneousItem(68, "Insignia Cookie Treasures", 10, "InsigniaCookieTreasure.png");
            BuildMiscellaneousItem(69, "Crystal Jam", 10, "CrystalJam.png");
            BuildMiscellaneousItem(70, "Golden Croissant", 10, "GoldenCroissant.png");
            BuildMiscellaneousItem(71, "The Jelly of Memories", 10, "TheJellyOfMemories.png");

            BuildWeapon(72, "Cookie Axe", 10, "CookieAxe.png", 2, 7);
            BuildWeapon(73, "Cookie Gun", 10, "CookieGun.png", 2, 7);

            BuildMiscellaneousItem(74, "Wood for Bridge Repair", 10, "WoodForBridgeRepair.png");
            BuildMiscellaneousItem(75, "Mayor's Special Butter", 10, "MayorsSpecialButter.png");
            BuildMiscellaneousItem(76, "Special Ingredient", 10, "SpecialIngredient.png");
            BuildMiscellaneousItem(77, "Treasure Map", 10, "TreasureMap.png");
            BuildMiscellaneousItem(78, "Cookie Dough Spell", 10, "CookieDoughSpell.png");
            BuildMiscellaneousItem(79, "Choco Pirate's Letter", 10, "ChocoPirateLetter.png");
            BuildMiscellaneousItem(80, "Matcha Tea Time Alliance Membership Card", 10, "MatchaTeaTimeAllianceCard.png");

            BuildWeapon(1501, "Sugar of Death", 0, "sugarOfDeath.jpg", 0, 2); // gingerbread : sugarOfDeath
            BuildWeapon(1502, "MolDough", 0, "molDough.jpg", 0, 2);//doughogres : molDough
            BuildWeapon(1503, "Cookie Cutter", 0, "cookieCutter.jpg", 0, 2); //burntCookies : cookieCutter
            BuildWeapon(1504, "Dark Crust Magic", 0, "darkCrustMagic.jpg", 0, 2);//overbakedCupcake: darkCrustMagic
            BuildWeapon(1505, "Stick", 0, "stick.jpg", 0, 2);//notsoSmore : stick
            BuildWeapon(1506, "Cavittack", 0, "Cavittack.jpg", 0, 2); //theTeeth : Cavittack

            BuildHealingItem(2001, "SugarCubes", 5, 2, "SugarCubes.jpg"); //SugarCubes

            BuildMiscellaneousItem(3001, "Sugar Cane", 1, "sugarCane.jpg"); // sugarCane
            BuildMiscellaneousItem(3002, "Bamboo Grinder", 1, "bambooGrinder.jpg");// bambooGrinder

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