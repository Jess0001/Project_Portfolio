using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CanYouSaveSirDewford
{
    internal class PointSystem
    {
        /// <summary>
        /// set initial point score
        /// </summary>
        public static int total = 0;
        public static int rbScoreCount = 0;
        public static int points = 0;
        public static int iaScoreCount = 0;

        public static int CheckRBAnswers()
        {
            GenerateDeweyCharacters.SortDewey();

            //get score count
            for (int i = 0; i < ReplacingBooks.deweyList.Count; i++)
            {
                if (ReplacingBooks.deweyListAscend[i] == ReplacingBooks.deweyList[i])
                {
                    ++rbScoreCount;
                }
            }
            return rbScoreCount;
        }

        public static int CalculateReplaceBooksPoints()
        {
            CheckRBAnswers();

            //calculate points
            points = rbScoreCount * 10;

            //if count reaches certain amount of scores, earn points
            if (rbScoreCount > 4)
            {
                points = points + 20;
            }

            //if count reaches certain amount of scores, earn points
            if (rbScoreCount == 10)
            {
                points = points + 30;
            }

            total = total + points;

            return total;
        }

        //Check answer for identifying areas game
        public static int CheckIAAnswer()
        {
            foreach (var item in IdentifyingAreas.matchItems)
            {
                foreach (KeyValuePair<String, String> kvp in DeweyDictionary.deweyCategories)
                {
                    if (item.Content.ToString().Substring(0, 1) == kvp.Key.Substring(0, 1) && IdentifyingAreas.deweyInput == kvp.Value)
                    {
                        iaScoreCount++;
                    }
                    else if (IdentifyingAreas.deweyInput.Substring(0, 1) == kvp.Key.Substring(0, 1) && item.Content == kvp.Value)
                    {
                        iaScoreCount++;
                    }
                }
            }
            CalculateIAScore();
            return iaScoreCount;
        }

        //Calculate score
        private static int CalculateIAScore()
        {
            int tempPoints = iaScoreCount * 10;
            total = total + tempPoints;
            return total;
        }
    }
}
