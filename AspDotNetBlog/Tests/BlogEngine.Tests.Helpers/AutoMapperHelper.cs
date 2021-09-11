using AutoMapper;
using BlogEngine.Business.Services;

namespace BlogEngine.Tests.Helpers
{
    public class AutoMapperHelper
    {
        public static IMapper SetupMapper()
        {
            var config = ModelMapper.Configure();
            IMapper mapper = config.CreateMapper();
            return mapper;
        }
    }
}
