using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _8BD.Helpers
{
    public class RegexHelper
    {
        public String[] patterns = new String[6]
         {
             @"\(b: (\s?)*(?<bold>(.*?))\)",
             @"\(i: (\s?)*(?<italic>(.*?))\)",
             @"\(bkz: (\s?)*(?<bkz>(.*?))\)",
             @"\(gbkz: (\s?)*(?<gbkz>(.*?))\)",
             @"(?:https?:)?(?:\/\/)?(?:[0-9A-Z-]+\.)?(?:youtu\.be\/|youtube(?:-nocookie)?\.com\/\S*?[^\w\s-])(?<youtube>((?!videoseries)[\w-]{11}))(?=[^\w-]|$)(?![?=&+%\w.-]*(?:['""][^<>]*>|<\/a>))[?=&+%\w.-]*",
             @"(?<image>^(?:(?<scheme>[^:\/?#]+):)?(?:\/\/(?<authority>[^\/?#]*))?(?<path>[^?#]*\/)?(?<file>[^?#]*\.(?<extension>[Jj][Pp][Ee]?[Gg]|[Pp][Nn][Gg]|[Gg][Ii][Ff]))(?:\?(?<query>[^#]*))?(?:#(?<fragment>.*))?$)"



         };
        public String[] replacements = new String[6]
        {
        @"<b>${bold}</b>",
        @"<i>${italic}</i>",
        @"(bkz: <a href='subject?search=${bkz}'><b>${bkz}</b></a>)",
        @"<a href='subject?search=${gbkz}'><b>${gbkz}</b></a>",
        @"</p><iframe style='width:99%; height: 400px;' src='https://www.youtube.com/embed/${youtube}' frameborder='0' allow='accelerometer; autoplay; encrypted-media; gyroscope; picture-in-picture' allowfullscreen></iframe><p class='tanim'>",
        @"<img style='width:99%; height: 400px;' src='${image}'>"
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
