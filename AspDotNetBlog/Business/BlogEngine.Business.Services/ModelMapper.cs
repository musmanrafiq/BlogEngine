using AutoMapper;
using System;

namespace BlogEngine.Business.Services
{
    public class ModelMapper
    {
        private readonly IMapper mapper;
        public ModelMapper(IMapper mapper)
        {
            this.mapper = mapper;
        }

        public static MapperConfiguration Configure()
        {
            return new MapperConfiguration(cfg =>
            {

                cfg.CreateMap<Models.BaseEntityModel, Data.Model.Entities.BaseEntity>().ReverseMap();
                cfg.CreateMap<Models.PostModel, Data.Model.Entities.Post>().ReverseMap();
                cfg.CreateMap<Models.PromptModel, Data.Model.Entities.Prompt>().ReverseMap();

                /*cfg.CreateMap<Models.UserInterests, Data.Models.UserInterests>().AfterMap((source, destination) =>
                {
                    destination.PersonalityInterestsId = source.PIId;
                });
                cfg.CreateMap<Data.Models.UserInterests, Models.UserInterests>().AfterMap((source, destination) =>
                {
                    destination.PIId = source.PersonalityInterestsId;
                });*/

            });
        }
        /*public static TDestination Map<TDestination>(object source) where TDestination : class
        {
            return Mapper.Map<TDestination>(source);
        }

        public static TDestination Map<TSource, TDestination>(TSource source) where TSource : class where TDestination : class
        {
            return Mapper.Map<TSource, TDestination>(source);
        }

        public static TDestination Map<TDestination>(object source, Action<IMappingOperationOptions> opts)

            where TDestination : class
        {
            return Mapper.Map<TDestination>(source, opts);
        }

        public static TDestination Map<TSource, TDestination>(TSource source, Action<IMappingOperationOptions> opts) where TSource : class where TDestination : class
        {
            return Mapper.Map<TSource, TDestination>(source, opts);
        }

        public static TDestination Map<TSource, TDestination>(TSource source, TDestination destination) where TSource : class where TDestination : class
        {
            return Mapper.Map(source, destination);
        }

        public static object Map(object source, Type sourceType, Type destinationType)
        {
            return Mapper.Map(source, sourceType, destinationType);
        }

        public static TDestination Map<TSource, TDestination>(TSource source, TDestination destination, Action<IMappingOperationOptions> opts) where TSource : class where TDestination : class

        {
            return Mapper.Map(source, destination, opts);
        }

        public static object Map(object source, object destination, Type sourceType, Type destinationType)
        {
            return Mapper.Map(source, destination, sourceType, destinationType);
        }

        public static object Map(object source, Type sourceType, Type destinationType, Action<IMappingOperationOptions> opts)
        {
            return Mapper.Map(source, sourceType, destinationType, opts);
        }

        public static object Map(object source, object destination, Type sourceType, Type destinationType, Action<IMappingOperationOptions> opts)
        {
            return Mapper.Map(source, destination, sourceType, destinationType, opts);
        }*/
    }
}
