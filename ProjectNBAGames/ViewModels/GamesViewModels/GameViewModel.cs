using ProjectNBAGames.ApiModels.TeamsApiModels;
using System;


namespace ProjectNBAGames.ViewModels.GamesViewModels
{
    public class GameViewModel
    {
        public int? Id { get; set; }
        public DateTime? Date { get; set; }
        public int? HomeTeamScore { get; set; }
        public int? VisitorTeamScore { get; set; }
        public int? Season { get; set; }
        public ApiTeam HomeTeam { get; set; }
        public ApiTeam VisitorTeam { get; set; }
    }
}