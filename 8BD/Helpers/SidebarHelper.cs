﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using _8BD.Models;
using RestSharp;
using Newtonsoft.Json;

namespace _8BD.Helpers
{
    public class SidebarHelper
    {
        IConfiguration configuration;

        public SidebarHelper(IConfiguration configuration)
        {
            this.configuration = configuration;
        }

        public IOrderedEnumerable<Subject> getSubjects()
        {
            IRestClient restClient = new RestClient();
            IRestRequest restRequest = new RestRequest(configuration["ApiAddress"] + $"/subjects");
            var restResponse = restClient.Get(restRequest);
            var subjects = JsonConvert.DeserializeObject<List<Subject>>(restResponse.Content);
            var deneme = subjects.OrderByDescending(x => x.updateDate);
            return deneme;
        }

    }
}