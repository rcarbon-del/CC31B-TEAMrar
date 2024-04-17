using System;
using System.Collections.Generic;
using System.Linq;
using Engine.Models;

namespace Engine.Factories
{
    public static class TraderFactory
    {
        private static readonly List<Trader> _traders = new List<Trader>();
        static TraderFactory()
        {
            Trader whitelily = new Trader("White Lily Cookie");
            whitelily.AddItemToInventory(ItemFactory.CreateGameItem(2001));
            Trader chocopirate = new Trader("Chocolate Pirate Cookie");
            chocopirate.AddItemToInventory(ItemFactory.CreateGameItem(64));
            Trader prophet = new Trader("Golden Prophet Cookie");
            prophet.AddItemToInventory(ItemFactory.CreateGameItem(67));
            Trader butter = new Trader("Green Tea Butter");
            butter.AddItemToInventory(ItemFactory.CreateGameItem(81));
            butter.AddItemToInventory(ItemFactory.CreateGameItem(81));
            butter.AddItemToInventory(ItemFactory.CreateGameItem(81));
            butter.AddItemToInventory(ItemFactory.CreateGameItem(81));
            butter.AddItemToInventory(ItemFactory.CreateGameItem(81));
            butter.AddItemToInventory(ItemFactory.CreateGameItem(81));
            butter.AddItemToInventory(ItemFactory.CreateGameItem(81));
            butter.AddItemToInventory(ItemFactory.CreateGameItem(81));
            butter.AddItemToInventory(ItemFactory.CreateGameItem(81));
            butter.AddItemToInventory(ItemFactory.CreateGameItem(81));
            butter.AddItemToInventory(ItemFactory.CreateGameItem(81));
            butter.AddItemToInventory(ItemFactory.CreateGameItem(81));
            butter.AddItemToInventory(ItemFactory.CreateGameItem(81));
            butter.AddItemToInventory(ItemFactory.CreateGameItem(81));
            butter.AddItemToInventory(ItemFactory.CreateGameItem(81));
            butter.AddItemToInventory(ItemFactory.CreateGameItem(81));
            Trader macaroon = new Trader("Macaroon Cookie");
            macaroon.AddItemToInventory(ItemFactory.CreateGameItem(69));

            AddTraderToList(whitelily);
            AddTraderToList(chocopirate);
            AddTraderToList(prophet);
            AddTraderToList(butter);
            AddTraderToList(macaroon);
        }
        public static Trader GetTraderByName(string name)
        {
            return _traders.FirstOrDefault(t => t.Name == name);
        }
        private static void AddTraderToList(Trader trader)
        {
            if (_traders.Any(t => t.Name == trader.Name))
            {
                throw new ArgumentException($"There is already a trader named '{trader.Name}'");
            }
            _traders.Add(trader);
        }
    }
}