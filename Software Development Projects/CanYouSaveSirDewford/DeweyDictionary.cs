using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CanYouSaveSirDewford
{
    internal class DeweyDictionary
    {
        public static Dictionary<String,String> deweyCategories = new Dictionary<String, String>(){};
        
        public static void PopulateDictionary()
        {
            deweyCategories.Add("000", "General Knowledge");
            deweyCategories.Add("100", "Psychology and Philosophy");
            deweyCategories.Add("200", "Religions and Mythology");
            deweyCategories.Add("300", "Social Sciences and Folklore");
            deweyCategories.Add("400", "Languages and Grammar");
            deweyCategories.Add("500", "Math and Science");
            deweyCategories.Add("600", "Medicine and Technology");
            deweyCategories.Add("700", "Arts and Recreation");
            deweyCategories.Add("800", "Literature");
            deweyCategories.Add("900", "Social Sciences");

        }

    }
}
