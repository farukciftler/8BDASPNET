﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _8BD.Models
{
    public class Vote
    {
        public int id { get; set; }
        public int authorId { get; set; }
        public int voterId { get; set; }
        public int entryId { get; set; }
        public int type { get; set; }
        public DateTime voteDate { get; set; }
    }
}
