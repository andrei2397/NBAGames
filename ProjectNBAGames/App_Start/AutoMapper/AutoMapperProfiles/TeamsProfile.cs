using AutoMapper;
using ProjectNBAGames.ApiModels.TeamsApiModels;
using ProjectNBAGames.ViewModels.TeamsViewModels;

namespace ProjectNBAGames.App_Start.AutoMapper.AutoMapperProfiles
{
    public class TeamsProfile:Profile
    {
        public TeamsProfile()
        {
            CreateMap<ApiTeam, TeamViewModel>();
        }
    }
}