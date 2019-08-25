using AutoMapper;
using ProjectNBAGames.ApiModels.GamesApiModels;
using ProjectNBAGames.ViewModels.GamesViewModels;

namespace ProjectNBAGames.App_Start.AutoMapper.AutoMapperProfiles
{
    public class GamesProfile : Profile
    {
        public GamesProfile()
        {
            CreateMap<ApiGame, GameViewModel>();
            CreateMap<ApiGameContent, GameContentViewModel>();
        }
    }
}