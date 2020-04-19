using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _8BD.Helpers
{
    public class RegexHelper
    {
        public String[] patterns = new String[7]
         {
             @"\(b: (\s?)*(?<bold>(.*?))\)",
             @"\(i: (\s?)*(?<italic>(.*?))\)",
             @"\(bkz: (\s?)*(?<bkz>(.*?))\)",
             @"\(gbkz: (\s?)*(?<gbkz>(.*?))\)",
             @"\(u: (\s?)*(?<star>(.*?))\)",
             @"(?:https?:)?(?:\/\/)?(?:[0-9A-Z-]+\.)?(?:youtu\.be\/|youtube(?:-nocookie)?\.com\/\S*?[^\w\s-])(?<youtube>((?!videoseries)[\w-]{11}))(?=[^\w-]|$)(?![?=&+%\w.-]*(?:['""][^<>]*>|<\/a>))[?=&+%\w.-]*",
             @"(?<image>^(?:(?<scheme>[^:\/?#]+):)?(?:\/\/(?<authority>[^\/?#]*))?(?<path>[^?#]*\/)?(?<file>[^?#]*\.(?<extension>[Jj][Pp][Ee]?[Gg]|[Pp][Nn][Gg]|[Gg][Ii][Ff]))(?:\?(?<query>[^#]*))?(?:#(?<fragment>.*))?$)"


         };
        public String[] reversepatterns = new String[1]
        {

            @"<br \/>"

        };

        public String[] replacements = new String[7]
        {
        @"<b>${bold}</b>",
        @"<i>${italic}</i>",
        @"(bkz: <a href=""subject?search=${bkz}"" style=""text-decoration: underline;""><b>${bkz}</b></a>)",
        @"<a href=""subject?search=${gbkz}"" style=""text-decoration: underline;""><b>${gbkz}</b></a>",
         @"<span class='tooltip'>*<span class='tooltip-text'><a href='/subject?search=${star}'>${star}</a></span></span>",
        @"</p><iframe style='width:99%; height: 400px;' src='https://www.youtube.com/embed/${youtube}' frameborder='0' allow='accelerometer; autoplay; encrypted-media; gyroscope; picture-in-picture' allowfullscreen></iframe><p class='tanim'>",
        @"<br><img style='width:99%; height: 400px;' src='${image}'><br>"
        };
        public String[] reversereplacements = new String[1]
        {

           @"\\n"

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
        public String PregReplaceReverse(String input, string[] reversepattern, string[] reversereplacements)
        {

            if (reversereplacements.Length != reversepatterns.Length)
                throw new ArgumentException("Replacement and Pattern Arrays must be balanced");

            for (var i = 0; i < reversepattern.Length; i++)
            {
                input = Regex.Replace(input, reversepattern[i], replacements[i]);
            }

            return input;
        }


    }
}
