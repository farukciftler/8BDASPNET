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
        public string subject { get; set; }
        public string entry { get; set; }
        public DateTime createDate { get; set; }
        public DateTime lastUpdateDate { get; set; }
    }
}
