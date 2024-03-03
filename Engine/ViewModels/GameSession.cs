using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Engine.Models;

namespace Engine.ViewModels
{
    public class GameSession
    {
        public Player CurrentPlayer { get; set; }
        public Location CurrentLocation { get; set; }
        public GameSession()
        {
            CurrentPlayer = new Player();
            CurrentPlayer.Name = "Gerr-real";
            CurrentPlayer.CharacterClass = "Fighter";
            CurrentPlayer.HitPoints = 10;
            CurrentPlayer.ExperiencePoints = 0;
            CurrentPlayer.Level = 1;
            CurrentPlayer.Gold = 1000000000;

            CurrentLocation = new Location();
            CurrentLocation.XCoordinate = 0;
            CurrentLocation.YCoordinate = 0;
            CurrentLocation.Name = "Home";
            CurrentLocation.Description = "This is your house";
            CurrentLocation.ImageName = "pack://application:,,,/Engine;component/Images/Locations/Home.png";
        }

        public void MoveNorth()
        {
            CurrentLocation = CurrentLocation.LocationAt(CurrentLocation.XCoordinate, CurrentLocation.YCoordinate + 1);
        }

        public void MoveWest()
        { 
        }

        public void MoveEast()
        {  
        }

        public void MoveSouth()
        {
        }
    }
}
