using Microsoft.Extensions.Options;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using VantagepointAPI_BlazorWebApp.Models;

namespace VantagepointAPI_BlazorWebApp
{
    public class VantagepointAPIService
    {
        private VantagepointSettings settings;
        private TokenResponse token;

        /// <summary>
        /// retrieves the configuration settings via
        /// dependency injection (from Startup.cs)
        /// </summary>
        /// <param name="options"></param>
        public VantagepointAPIService(
            IOptions<VantagepointSettings> options
            )
        {
            settings = options.Value;
        }

        /// <summary>
        /// authenticates with Vantagepoint based
        /// on the settings info passed in at creation
        /// </summary>
        /// <returns></returns>
        public Models.TokenResponse authenticate()
        {
            //create new rest client
            var client = new RestClient($"{settings.BaseUrl}/token");
            client.Timeout = -1;

            //set up new request
            var request = new RestRequest(Method.POST);
            request.AddHeader("Content-Type",
                "application/x-www-form-urlencoded");
            request.AddParameter("Username", settings.Username);
            request.AddParameter("Password", settings.Password);
            request.AddParameter("grant_type", "password");
            request.AddParameter("Integrated", "N");
            request.AddParameter("database", settings.database);
            request.AddParameter("Client_Id", settings.Client_Id);
            request.AddParameter("client_secret", settings.client_secret);
            request.AddParameter("culture", settings.culture);

            //query response of type TokenResponse
            var response = client.Post<TokenResponse>(request);

            //set token info for internal use
            token = response.Data;
            //return token info
            return response.Data;
        }

        /// <summary>
        /// gets a list of projects (no filter)
        /// this method always re-authenticates
        /// with every call. In real life code you
        /// should check for the expiration of the token
        /// </summary>
        /// <returns></returns>
        public ProjectsResponse getProjects()
        {
            authenticate();

            var client = new RestClient(
                $"{settings.BaseUrl}/project?limit=5");
            client.Timeout = -1;

            var request = new RestRequest(Method.GET);
            request.AddHeader(
                "Content-Type",
                "application/json");
            request.AddHeader(
                "Authorization",
                $"bearer {token.access_token}");


            var response = client.Get<ProjectsResponse>(request);
            return response.Data;
        }

        /// <summary>
        /// searches for projects by name
        /// </summary>
        /// <param name="searchString"></param>
        /// <param name="limit"></param>
        /// <returns></returns>
        public ProjectsResponse searchProjects(
            string searchString,
            int limit = 10)
        {

            authenticate();

            var client = new RestClient(
                    $"{settings.BaseUrl}/project" +
                    $"?limit={limit}" +
                    $"&{getFilterHashForProjectNameSearch(searchString)}");
            client.Timeout = -1;

            var request = new RestRequest(Method.GET);
            request.AddHeader(
                "Content-Type",
                "application/json");
            request.AddHeader(
                "Authorization",
                $"bearer {token.access_token}");


            var response = client.Get<ProjectsResponse>(request);
            return response.Data;
        }

        /// <summary>
        /// creates the necessary filter hash
        /// for searching a name
        /// </summary>
        /// <param name="searchString"></param>
        /// <returns></returns>
        public string getFilterHashForProjectNameSearch(string searchString)
        {
            string filterHash = "filterHash[0][seq]=1&" +
                "filterHash[0][name]=Name" +
                $"&filterHash[0][value]={HttpUtility.UrlEncode(searchString)}" +
                "&filterHash[0][tablename]=PR" +
                "&filterHash[0][type]=dropdown" +
                "&filterHash[0][opp]=like" +
                "&filterHash[0][condition]=" +
                "&filterHash[0][searchlevel]=1";
            return filterHash;
        }

        /// <summary>
        /// posts the comment record to Vantagepoint
        /// </summary>
        /// <param name="comment"></param>
        /// <returns></returns>
        public CommentsResponse postComment(
            UDIC_Comment comment)
        {
            authenticate();

            var client = new RestClient($"{settings.BaseUrl}/UDIC/UDIC_Comment");
            client.Timeout = -1;

            var request = new RestRequest(Method.POST);
            request.AddHeader(
                "Content-Type",
                "application/json");
            request.AddHeader(
                "Authorization",
                $"bearer {token.access_token}");
            request.AddJsonBody(comment);


            var response = client.Post<CommentsResponse>(request);
            return response.Data;
        }
    }

}
