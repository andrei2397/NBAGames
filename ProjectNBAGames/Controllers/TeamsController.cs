using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AutoMapper;
using ProjectNBAGames.ApiModels.TeamsApiModels;
using ProjectNBAGames.ApiModels.PlayersApiModels;
using ProjectNBAGames.ViewModels.TeamsViewModels;
using Newtonsoft.Json;
using ProjectNBAGames.Services;

namespace ProjectNBAGames.Controllers
{
    public class TeamsController : BaseController
    {
        // GET: Teams
        public ActionResult Details(TeamsFilterViewModel model, int id)
        {
            model.Id = model.Id ?? id;

            if (!ModelState.IsValid)
                return View(TeamContentViewModel.Empty);

            try
            {
                
                var resource = string.Format("teams/{0}", model.Id);
                var restReponse = RestApiCallService.Call(resource);
                ApiTeam response = JsonConvert.DeserializeObject<ApiTeam>(restReponse.Content);
                ViewBag.Abbreviation = response.Abbreviation;
                ViewBag.City = response.City;
                ViewBag.Conference = response.Conference;
                ViewBag.Division = response.Division;
                ViewBag.FullName = response.FullName;
                ViewBag.Id = response.Id;
                ViewBag.Name = response.Name;
                GetPlayers(response.Id);
              
                return View();
            }
            catch (Exception exception)
            {
                // TODO: logging
                ModelState.AddModelError("", "A aparut o eroare.");
                return View(TeamContentViewModel.Empty);
            }
        }
        public void GetPlayers(int? id)
        {
            try
            {
            
                var resourcePlayers = string.Format("players");
                var restReponsePlayers = RestApiCallService.Call(resourcePlayers);
                var responsePlayers = JsonConvert.DeserializeObject<ApiPlayerContent>(restReponsePlayers.Content);      
                ViewBag.playersAtTeam = responsePlayers.Data.Where(s => s.Team.Id == id);

            }
            catch (Exception exception)
            {
                
            }
        }
    }
}