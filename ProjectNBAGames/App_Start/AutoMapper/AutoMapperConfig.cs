using AutoMapper;
using ProjectNBAGames.App_Start.AutoMapper.AutoMapperProfiles;

namespace ProjectNBAGames.App_Start.AutoMapper
{
    public class AutoMapperConfig
    {
        public static void Configure()
        {
            Mapper.Initialize(x =>
            {
                x.AddProfile<PageProfile>();
                x.AddProfile<GamesProfile>();
                x.AddProfile<TeamsProfile>();
            });
            Mapper.Configuration.AssertConfigurationIsValid();
        }
    }
}