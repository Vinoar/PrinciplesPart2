using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrinciplesPart2
{
    public class KISSPrinciple
    {
        public KISSPrinciple()
        {
            
        }

        /// <summary>
        /// using IF .. else if... else statment it will hard if conditions are grow.
        /// </summary>
        /// <param name="gameType"></param>
        /// <returns></returns>
        public string ComplexCodeMethodOne(int gameType)
        {
            if (gameType == 1)
            {
                return "Indoor Game";
            }
            else if (gameType == 2)
            {
                return "Outdoor Game";
            }
            else
            {
                return "NA";
            }            
        }

        /// <summary>
        /// Its array index finder, it will create unwanted errors and complex of code in future.
        /// </summary>
        /// <param name="gameType"></param>
        /// <returns></returns>
        public string ComplexCodeMethodTwo(int gameType)
        {
            string[] gameTypes = new string[2] { "Indoor Game", "Outdoor Game" };
            if ((gameType - 1) == 1 || (gameType - 1) == 0)
            {
                return gameTypes[(gameType - 1)];
            }
            return "NA";
        }

        /// <summary>
        /// Using Switch Statement for simple and easy understand.
        /// </summary>
        /// <param name="sportsType"></param>
        /// <returns></returns>
        public string KISS_SimpleCodeMethod(int sportsType)
        {
             switch (sportsType)
            {
                case 1:
                    return "Traditional Sports";
                case 2:
                    return "Tag Games";
                case 3:
                    return "Water Sports";
                case 4:
                    return "Team Sports";
                case 5:
                    return "Adventure Sports";
                case 6:
                    return "Playground Games";
                case 7:
                    return "Gardening Games";
                // Will be add more cases
                default:
                    return "NA";
            }
        }

        /// <summary>
        /// Using Switch Expression in C# advance concept for simple and sweet
        /// </summary>
        /// <param name="sportsType"></param>
        /// <returns></returns>
        public string KISS_AdvancedCodeMethod(int sportsType)
        {
            return sportsType switch
            {
                1 => "Traditional Sports",
                2 => "Tag Games",
                3 => "Water Sports",
                4 => "Team Sports",
                5 => "Adventure Sports",
                6 => "Playground Games",
                7 => "Gardening Games",
                // Will be add more cases
                _ => "NA",
            };
        }


    }
}
