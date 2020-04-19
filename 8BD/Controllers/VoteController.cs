using _8BD.Helpers;
using _8BD.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _8BD.Controllers
{
    public class VoteController : Controller
    {
        private readonly HttpHelper _helper;

        public VoteController(HttpHelper helper)
        {
            _helper = helper;
        }
        [HttpGet]
        public int LikeThis(int id)
        {
            Vote vote = new Vote();
            vote.entryId = id;
            vote.type = 1;
            vote.date = DateTime.Now;
            vote.userId = Convert.ToInt32(HttpContext.Session.GetInt32("_id"));
            var c = _helper.PostMethod<int>(vote, "/votes/likevote");


            return c;
        }
        [HttpGet]
        public int LikeCount(int id)
        {

            var apiendpoint = $"/votes/countlike/{id}";
            var count = _helper.GetApiEndpoint<int>(apiendpoint);


            return count;
        }
        [HttpGet]
        public int UnLikeThis(int id)
        {
            Vote vote = new Vote();
            vote.entryId = id;
            vote.type = 0;
            vote.date = DateTime.Now;
            vote.userId = Convert.ToInt32(HttpContext.Session.GetInt32("_id"));
            var c = _helper.PostMethod<int>(vote, "/votes/unlikevote");


            return c;
        }
        [HttpGet]
        public int UnLikeCount(int id)
        {

            var apiendpoint = $"/votes/countunlike/{id}";
            var count = _helper.GetApiEndpoint<int>(apiendpoint);


            return count;
        }
    }
}

