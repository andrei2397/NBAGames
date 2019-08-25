using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ProjectNBAGames.ApiModels.GamesApiModels;
using ProjectNBAGames.ViewModels.GamesViewModels;
using AutoMapper;


namespace ProjectNBAGames.Controllers
{
    public class GamesController : BaseController
    {
        // GET: Games
        public ActionResult Index(GamesFilterViewModel model, string season, int page)
        {
            model.Season = model.Season ?? season;
            model.Page = model.Page ?? page;
            model.PageSize = model.PageSize ?? 25;
            ViewBag.Season = season;
            ViewBag.Page = page;
            if (!ModelState.IsValid)
                return View(GameContentViewModel.Empty);

            try
            {
                //throw new NotImplementedException();
                var resource = string.Format("games?seasons[]={0}&page={1}&per_page={2}",
                   model.Season, model.Page, model.PageSize);
              

                var restReponse = RestApiCallService.Call(resource);
                var response = JsonConvert.DeserializeObject<ApiGameContent>(restReponse.Content);
                var gamesListModel = Mapper.Map<GameContentViewModel>(response);
                var st = response.Data.Where(x => x.Id == 1);
                
                return View(gamesListModel);


            }
            catch (Exception exception)
            {
                // TODO: logging
                ModelState.AddModelError("", "A aparut o eroare.");
                return View(GameContentViewModel.Empty);
            }
            
          
        }
    }
}