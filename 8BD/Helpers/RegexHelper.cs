using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _8BD.Helpers
{
    public class RegexHelper
    {
        public  List<string> patternss = new List<string> {
        @"\(b: (\s?)*(?<bold>(.*?))\)"
        };
        public List<string> substitutions = new List<string> {
        @"\2"
        };

        //https://regex101.com/r/Ai92e7/3


    }
}
