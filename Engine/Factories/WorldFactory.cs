using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Engine.Models;

namespace Engine.Factories
{
    public class WorldFactory
    {
        public static World CreateWorld()
        {
            World newWorld = new World();

            newWorld.AddLocation(0, 0,
            "Matcha Green Office",
            "Home",
            "pack://application:,,,/Engine;component/Images/Locations/MatchaGreenOffice.png");

            newWorld.AddLocation(-1, 0,
            "Fondue Lake",
            "You see a lake!",
            "pack://application:,,,/Engine;component/Images/Locations/FondueLake.png");

            newWorld.AddLocation(-2, 0,
            "Bamboo Cookie Forest",
            "You see a forest!",
            "pack://application:,,,/Engine;component/Images/Locations/BambooCookieForest.png");

            newWorld.AddLocation(-2, 1,
            "White Chocolate Heaven",
            "You see heaven!",
            "pack://application:,,,/Engine;component/Images/Locations/WhiteChocolateHeaven.png");

            newWorld.AddLocation(-1, -1,
            "White Chocolate Mocha Falls",
            "You see a chocolate waterfall!",
            "pack://application:,,,/Engine;component/Images/Locations/WhiteChocolateMochaFalls.png");

            newWorld.AddLocation(1, 0,
            "Vanilla Ice City",
            "You see neighboring city!",
            "pack://application:,,,/Engine;component/Images/Locations/VanillaIceCity.png");

            newWorld.AddLocation(2, 0,
            "Crinkle Dessert",
            "You see a dessert",
            "pack://application:,,,/Engine;component/Images/Locations/CrinkleDessert.png");

            newWorld.AddLocation(1, -1,
            "Tropical Cheese Beach",
            "You see a beach!",
            "pack://application:,,,/Engine;component/Images/Locations/TropicalCheeseBeach.png");

            newWorld.AddLocation(1, -2,
            "Cinnamon Coral Ocean",
            "You're in the ocean",
            "pack://application:,,,/Engine;component/Images/Locations/CinnamonCoralOcean.png");

            newWorld.AddLocation(2, -2,
            "Choco Lava Island",
            "You see an island",
            "pack://application:,,,/Engine;component/Images/Locations/ChocoLavaIsland.png");

            return newWorld;
        }
    }
}
