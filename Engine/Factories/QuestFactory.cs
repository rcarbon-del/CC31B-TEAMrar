using Engine.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Factories
{
    public static class QuestFactory
    {
        private static readonly List<Quest> _quests = new List<Quest>();
        static QuestFactory()
        {

            List<ItemQuantity> itemsToComplete1 = new List<ItemQuantity>();
            List<ItemQuantity> rewardItems1 = new List<ItemQuantity>();
            itemsToComplete1.Add(new ItemQuantity(65, 5));
            rewardItems1.Add(new ItemQuantity(64, 1000));

            List<ItemQuantity> itemsToComplete2 = new List<ItemQuantity>();
            List<ItemQuantity> rewardItems2 = new List<ItemQuantity>();
            itemsToComplete2.Add(new ItemQuantity(65, 5));
            rewardItems2.Add(new ItemQuantity(64, 1000));

            List<ItemQuantity> itemsToComplete3 = new List<ItemQuantity>();
            List<ItemQuantity> rewardItems3 = new List<ItemQuantity>();
            itemsToComplete3.Add(new ItemQuantity(65, 5));
            rewardItems3.Add(new ItemQuantity(64, 1000));

            List<ItemQuantity> itemsToComplete4 = new List<ItemQuantity>();
            List<ItemQuantity> rewardItems4 = new List<ItemQuantity>();
            itemsToComplete4.Add(new ItemQuantity(65, 5));
            rewardItems4.Add(new ItemQuantity(64, 1000));

            List<ItemQuantity> itemsToComplete5 = new List<ItemQuantity>();
            List<ItemQuantity> rewardItems5 = new List<ItemQuantity>();
            itemsToComplete5.Add(new ItemQuantity(65, 5));
            rewardItems5.Add(new ItemQuantity(64, 1000));

            List<ItemQuantity> itemsToComplete6 = new List<ItemQuantity>();
            List<ItemQuantity> rewardItems6 = new List<ItemQuantity>();
            itemsToComplete6.Add(new ItemQuantity(65, 5));
            rewardItems6.Add(new ItemQuantity(64, 1000));

            List<ItemQuantity> itemsToComplete7 = new List<ItemQuantity>();
            List<ItemQuantity> rewardItems7 = new List<ItemQuantity>();
            itemsToComplete7.Add(new ItemQuantity(65, 5));
            rewardItems7.Add(new ItemQuantity(64, 1000));

            List<ItemQuantity> itemsToComplete8 = new List<ItemQuantity>();
            List<ItemQuantity> rewardItems8 = new List<ItemQuantity>();
            itemsToComplete8.Add(new ItemQuantity(65, 5));
            rewardItems8.Add(new ItemQuantity(64, 1000));

            _quests.Add(new Quest(1,
                                  "The Missing Letter: Look for the missing letter of Choco Pirate Cookie",
                                  "It is said that on the Choco Pirate's journey across the Cinnamon Coral Ocean, he lost his treasure and left a letter there.",
                                  itemsToComplete1,
                                  25, 10,
                                  rewardItems1));
            _quests.Add(new Quest(2,
                                  "Oh no, we can't cross: Make a Bridge to Bamboo Cookie Forest",
                                  "Time to play architect and build a bridge that’s strong enough for a cookie, but not too tasty for them to eat!" +
                                  "\nThe bridge connecting Bamboo Cookie Forest and Fondue Lake was said to be destroyed by a group of Burnt Cookies due to an argument about who was the crumbiest amongst them",
                                  itemsToComplete2,
                                  25, 10,
                                  rewardItems2));
            _quests.Add(new Quest(3,
                                  "Matcha Tea Time Alliance: Befriend Mayor Green Tea Butter",
                                  "Win over Mayor Green Tea Butter for him to give a special ingredient" +
                                  "\nLet me tell you a rumor, there's a mayor in Matcha Green Province that likes butter with his tea. Yikes! don't let the breadish people know!",
                                  itemsToComplete3,
                                  25, 10,
                                  rewardItems3));
            _quests.Add(new Quest(4,
                                "Crumby Encounter: Look for Macaroon Cookie and give him the ingredients for “Golden Croissant”",
                                "Seek out Macaroon Cookie at the Bamboo Cookie Forest, the master baker with a golden touch for croissants. Rumor has it, his pastries are so shiny, you might just need sunglasses to see them!",
                                itemsToComplete4,
                                25, 10,
                                rewardItems4));
            _quests.Add(new Quest(5,
                                "Go where the X is: Follow the treasure map given by Choco Pirate Cookie",
                                "A dessert full of craft and uneven peak, making you second-guess your visit for sure, the Crinkles Dessert holds what you seek, so go forth your journey to find the treasure.",
                                itemsToComplete5,
                                25, 10,
                                rewardItems5));
            _quests.Add(new Quest(6,
                                "Land of Cleanliness: Get White Chocolate Mocha Concentrate",
                                "There was once a legend that hides on white waters, they lived in concentrated that fall naturally from the mountain at White Chocolate Mocha Falls.",
                                itemsToComplete6,
                                25, 10,
                                rewardItems6));
            _quests.Add(new Quest(7,
                                "Let the path lead you: Follow Golden Prophet Cookie to the City",
                                "When you surrender to the divine, you let them lead the path for you. The residents think it’s cheesy, but even on the most Tropical Cheesy Beach, you will find your meaning.",
                                itemsToComplete7,
                                25, 10,
                                rewardItems7));
            _quests.Add(new Quest(8,
                                "Long way home: Give the Golden Croissant to Vanilla Cookie",
                                "The divine seeks your presence in their dwelling heavenly chocolate place. And on this last leg of your journey, remember that the best journey takes you home.",
                                itemsToComplete8,
                                25, 10,
                                rewardItems8));
        }
            internal static Quest GetQuestByID(int id)
        {
            return _quests.FirstOrDefault(quest => quest.ID == id);
        }
    }
}
