using AutoMapper;
using ProjectNBAGames.ApiModels.GamesApiModels;
using ProjectNBAGames.ViewModels;

namespace ProjectNBAGames.App_Start.AutoMapper.AutoMapperProfiles
{
    public class PageProfile : Profile
    {
        public PageProfile()
        {
            CreateMap<ApiMeta, MetaViewModel>();
                
        }
    }
}