using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HardCodeBrawlStarsAI.PlayerRecognition
{
    internal class Recognize
    {
        // This is to recognise the Player name so we know where my player is at all times
        public string PlayerName { get; set; } = null;

        /// <summary>
        ///  What I am trying to do is make a Class that will take a Empty list as 
        ///  parameter and then return the strign full with info on the players that 
        ///  it recognises each Frame
        /// </summary>
        public List<int> AmountOfPlayersSeen()
        {
            List<int> Players = new List<int>();

            Players.Add(0);

            return Players;
        }

        /// <summary>
        ///  This is a class method to get the names of all the Players Seen each frame 
        /// </summary>
        public List<string> NamesOfPlayerSeen()
        {
            List<string> Names = new List<string>();

            Names.Add("Dhruv");

            return Names;
        }

        /// <summary>
        /// This is a class to Return the X and Y cords of MY character
        /// </summary>
        public int[] MyPlayerCords()
        {
            int[] CordsXY = { 1, 2, 3};

            
            return CordsXY;
        }
    }
}
