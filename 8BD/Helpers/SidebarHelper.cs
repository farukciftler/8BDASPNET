using System;
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
            IRestRequest restRequest = new RestRequest(configuration["ApiAddress"] + $"/subjects?pageIndex=0&pageSize=20");
            var restResponse = restClient.Get(restRequest);
            var subjects = JsonConvert.DeserializeObject<List<Subject>>(restResponse.Content);
            var deneme = subjects.OrderByDescending(x => x.updateDate);
            return deneme;
        }
        
        public  IOrderedEnumerable<Subject> getSubjectsTwo(int pageNumber, int pageSize)
        {
             IRestClient restClient = new RestClient();
            IRestRequest restRequest = new RestRequest(configuration["ApiAddress"] + $"/subjects?pageIndex={pageNumber-1}&pageSize={pageSize}");
            var restResponse = restClient.Get(restRequest);
            var subjects = JsonConvert.DeserializeObject<List<Subject>>(restResponse.Content);
            var deneme = subjects.OrderByDescending(x => x.updateDate);
            return deneme;
        }
        public int GetSubjectCount(int id)
        {
            var deserializedobject = 0;

            try
            {
                IRestClient restClient = new RestClient();
                IRestRequest restRequest = new RestRequest(configuration["ApiAddress"] + "/subjects/count/" + id);
                var restResponse = restClient.Get(restRequest);
                deserializedobject = JsonConvert.DeserializeObject<int>(restResponse.Content);
            }
            catch (Exception)
            {

                throw;
            }
            



            return deserializedobject;
        }

        public int getSubjectsQuantity(int subjectId)
        {
            IRestClient restClient = new RestClient();
            IRestRequest restRequest = new RestRequest(configuration["ApiAddress"] + "/entries/entrynumber/" + subjectId);
            var restResponse = restClient.Get(restRequest);
            var subjects = JsonConvert.DeserializeObject<int>(restResponse.Content);
            return subjects;
        }

    }
}