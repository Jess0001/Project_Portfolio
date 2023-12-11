using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CanYouSaveSirDewford
{
    internal class GenerateDeweyCharacters
    {

        private static Random random = new Random();
        private static String deweyValue;

        /// <summary>
        /// generate random values into a string
        /// temporarily store in array
        /// show on textboxes
        /// </summary>
        private static String GetDeweyCharacters()
        {
            const String charLetters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            const String charNumbers = "0123456789";


            var result1 = (from m in Enumerable.Repeat(charNumbers, 3)
                           select m[random.Next(m.Length)]).ToArray();

            var result2 = (from m in Enumerable.Repeat(charNumbers, 2)
                           select m[random.Next(m.Length)]).ToArray();

            var result3 = (from m in Enumerable.Repeat(charLetters, 3)
                           select m[random.Next(m.Length)]).ToArray();

            String callnumber = new string(result1);
            String classification = new string(result2);
            String authorInitials = new string(result3);
            deweyValue = (callnumber + "." + classification + " " + authorInitials);

            return deweyValue;

        }

        public static void GenerateValues()
        {
            for (int i = 0; i < 10; i++)
            {
                GetDeweyCharacters();
                ReplacingBooks.deweyList.Add(deweyValue);
                String subDewey1 = deweyValue.Substring(0, 6);
                String subDewey2 = deweyValue.Substring(7);
                ReplacingBooks.displayDeweyList[i].Text = subDewey1 + "\n" + subDewey2;
            }
        }

        public static void SortDewey()
        {
            ReplacingBooks.deweyListAscend.AddRange(ReplacingBooks.deweyList);
            ReplacingBooks.deweyListAscend.Sort();
        }

    }
}
