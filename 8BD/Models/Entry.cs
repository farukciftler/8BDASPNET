using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _8BD.Models
{
    public class Entry
    {
        public int id { get; set; }
        public int authorId { get; set; }
        public int subjectId { get; set; }
        public string entry { get; set; }
        public DateTime createDate { get; set; }
        public DateTime lastUpdateDate { get; set; }
        public int entryLike { get; set; }
        public int entryUnlike { get; set; }
        public int entryFavorite { get; set; }

        public Entry()
        {
            createDate = DateTime.Now;
            lastUpdateDate = DateTime.Now;
            entry = "";
            entryLike = 0;
            entryUnlike = 0;
            entryFavorite = 0;
        }
    }
   

}
