using AutoMapper;
using BlogEngine.Business.Interfaces.Entities;
using BlogEngine.Business.Models;
using BlogEngine.Data.Interfaces;
using BlogEngine.Data.Model.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BlogEngine.Business.Services.Entities
{
    public class PostService : IPostService
    {
        private readonly IPostRepository _postRepository;
        private readonly IMapper _mapper;

        public PostService(IPostRepository postRepository, IMapper mapper)
        {
            _postRepository = postRepository;
            _mapper = mapper;
        }

        public async Task<List<PostModel>> GetAll()
        {
            var entities = await _postRepository.GetAsync().ConfigureAwait(false);
            return _mapper.Map<List<Post>, List<PostModel>>(entities);
        }
    }
}
