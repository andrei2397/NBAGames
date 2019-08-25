using RestSharp;

namespace ProjectNBAGames.Services
{
    public class RestApiCallService
    {
        private readonly string _baseUrl;
        private readonly string _apiHost;
        private readonly string _apiKey;

        public RestApiCallService(string baseUrl, string apiHost, string apikey)
        {
            _baseUrl = baseUrl;
            _apiHost = apiHost;
            _apiKey = apikey;

        }
        public IRestResponse Call(string resource)
        {
            var client = new RestClient(_baseUrl);
            var request = new RestRequest(resource, Method.GET);

            request.AddHeader("x-rapidapi-host", _apiHost);
            request.AddHeader("x-rapidapi-key", _apiKey);

            var response = client.Execute(request);
            return response;

        }


    }
}