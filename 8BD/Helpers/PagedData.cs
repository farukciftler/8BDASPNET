using _8BD.Models;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using System.Net;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json.Linq;
namespace _8BD.Helpers
{
    public class PagedData<T> where T:class
    {
        public IEnumerable<T> Data { get; set; }
        public int TotalPages { get; set; }
        public int CurrentPage { get; set; }
    }
    
}