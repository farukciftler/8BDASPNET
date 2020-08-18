using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _8BD.Helpers
{
    public class PaginationHelper
    {
        IConfiguration configuration;

        public PaginationHelper(IConfiguration configuration)
        {
            this.configuration = configuration;
        }
        public int getPageNumber(int subjectId)
        {
            IRestClient restClient = new RestClient();
            IRestRequest restRequest = new RestRequest(configuration["ApiAddress"] + "/entries/entrypage/" + subjectId);
            var restResponse = restClient.Get(restRequest);
            var subjects = JsonConvert.DeserializeObject<int>(restResponse.Content);
            return subjects;
        }
        public int getAllEntriesPageNumber(int authorId)
        {
            IRestClient restClient = new RestClient();
            IRestRequest restRequest = new RestRequest(configuration["ApiAddress"] + "/entries/allentriesentrypage/" + authorId);
            var restResponse = restClient.Get(restRequest);
            var subjects = JsonConvert.DeserializeObject<int>(restResponse.Content);
            return subjects;
        }
        public int getMostLikedEntriesPageNumber(int authorId)
        {
            IRestClient restClient = new RestClient();
            IRestRequest restRequest = new RestRequest(configuration["ApiAddress"] + "/entries/mostlikedentriesentrypage/" + authorId);
            var restResponse = restClient.Get(restRequest);
            var subjects = JsonConvert.DeserializeObject<int>(restResponse.Content);
            return subjects;
        }
        public int getMostUnlikedEntriesPageNumber(int authorId)
        {
            IRestClient restClient = new RestClient();
            IRestRequest restRequest = new RestRequest(configuration["ApiAddress"] + "/entries/mostunlikedentriesentrypage/" + authorId);
            var restResponse = restClient.Get(restRequest);
            var subjects = JsonConvert.DeserializeObject<int>(restResponse.Content);
            return subjects;
        }
        public int getMostFavoritedEntriesPageNumber(int authorId)
        {
            IRestClient restClient = new RestClient();
            IRestRequest restRequest = new RestRequest(configuration["ApiAddress"] + "/entries/mostfavoritedentriesentrypage/" + authorId);
            var restResponse = restClient.Get(restRequest);
            var subjects = JsonConvert.DeserializeObject<int>(restResponse.Content);
            return subjects;
        }
    }
}
