using System.Configuration;
using System.Web.Mvc;
using ProjectNBAGames.Services;

namespace ProjectNBAGames.Controllers
{
    public class BaseController : Controller
    {
        public RestApiCallService RestApiCallService { get; }

        public BaseController()
        {
            RestApiCallService = new RestApiCallService(
                ConfigurationManager.AppSettings["x-rapidapi-base-url"],
                ConfigurationManager.AppSettings["x-rapidapi-host"],
                ConfigurationManager.AppSettings["x-rapidapi-key"]);
        }
    }
}