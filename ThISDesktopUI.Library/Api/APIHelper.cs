using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using ThISDesktopUI.Library.Models;
using ThISDesktopUI.Models;

namespace ThISDesktopUI.Library.Api
{
    public class APIHelper : IAPIHelper
    {
        private HttpClient _ApiClient { get; set; }

        private ILoggedInUserModel _loggedInUser;

        public APIHelper(ILoggedInUserModel loggedInUser)
        {
            InitializeClient();

            _loggedInUser = loggedInUser;
        }

        public HttpClient ApiClient
        {
            get 
            { 
                return _ApiClient; 
            }
        }


        private void InitializeClient()
        {
            string api = ConfigurationManager.AppSettings["api"];

            _ApiClient = new HttpClient();
            _ApiClient.BaseAddress = new Uri(api);
            _ApiClient.DefaultRequestHeaders.Accept.Clear();
            _ApiClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }

        public async Task<AuthenticatedUser> Authenticate(string username, string password)
        {
            var data = new FormUrlEncodedContent(new[]
            {
                new KeyValuePair<string, string>("grant_type", "password"),
                new KeyValuePair<string, string>("username", username),
                new KeyValuePair<string, string>("password", password)
            });

            using (HttpResponseMessage response = await _ApiClient.PostAsync("/Token", data))
            {
                if (response.IsSuccessStatusCode)
                {
                    var result = await response.Content.ReadAsAsync<AuthenticatedUser>();
                    return result;
                }
                else
                {
                    throw new Exception(response.ReasonPhrase);
                }
            }
        }

        public async Task GetLoggedInUserInfo(string token) 
        {
            _ApiClient.DefaultRequestHeaders.Clear();
            _ApiClient.DefaultRequestHeaders.Accept.Clear();
            _ApiClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            _ApiClient.DefaultRequestHeaders.Add("Authorization", $"bearer { token }");

            using (HttpResponseMessage response = await _ApiClient.GetAsync("/api/User"))
            {
                if (response.IsSuccessStatusCode)
                {
                    var result = await response.Content.ReadAsAsync<LoggedInUserModel>();
                    _loggedInUser.CreateDate = result.CreateDate;
                    _loggedInUser.EmailAddress = result.EmailAddress;
                    _loggedInUser.FirstName = result.FirstName;
                    _loggedInUser.Id = result.Id;
                    _loggedInUser.LastName = result.LastName;
                    _loggedInUser.Token = token;
                    _loggedInUser.UserAcr = result.UserAcr;
                }
                else
                {
                    throw new Exception(response.ReasonPhrase);
                }
            }
        }
    }
}
