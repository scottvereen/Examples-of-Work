using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperHero
{
    class Validation
    {
       //clean validator's looking for following issue's
        public static bool IsStringClean(string temp)
        {

            bool result = false;




            string[] bw = { "democrat", "test", "hillary", "obama" };

            for (int ctr = 0; ctr < bw.Count(); ctr++)
            {
                if (temp.ToUpper().Contains(bw[ctr]))
                {
                    result = true;

                }

            }

            return result;

        }


        public static bool IsItFilledIn(string temp, int minlen)
        {
            bool result = false;

            if (temp.Length >= minlen)
            {
                result = true;
            }

            return result;
        }

        public static bool IsValidLength(string temp)
        {
            bool result = false;

            if (temp.Length > 0)
            {
                result = true;
            }
            return result;

        }

        public static bool IsValidEmail(string temp)
        {

            bool result = true;

            int atLocation = temp.IndexOf("@");
            int NextatLocation = temp.IndexOf("@", atLocation + 1);

            int periodLocation = temp.LastIndexOf(".");

            if (temp.Length < 8)
            {
                result = false;
            }
            else if (atLocation < 2)
            {
                result = false;
            }
            else if (periodLocation + 2 > (temp.Length))
            {
                result = false;
            }

            return result;


        }
        public static bool IsNumeric(string temp)
        {

            bool result = temp.All(char.IsDigit);

            return result;

        }



    }
}
