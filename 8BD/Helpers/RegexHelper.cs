using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _8BD.Helpers
{
    public class RegexHelper
    {
        public String[] patterns = new String[2]
         {
             @"\(b: (\s?)*(?<bold>(.*?))\)",
             @"\(i: (\s?)*(?<italic>(.*?))\)"


         };
        public String[] replacements = new String[2] 
        {
        @"<b>${bold}</b>",
        @"<i>${italic}</i>"
        };


        public  String PregReplace(String input, string[] pattern, string[] replacements)
        {

            if (replacements.Length != pattern.Length)
                throw new ArgumentException("Replacement and Pattern Arrays must be balanced");

            for (var i = 0; i < pattern.Length; i++)
            {
                input = Regex.Replace(input, pattern[i], replacements[i]);
            }

            return input;
        }


    }
}
