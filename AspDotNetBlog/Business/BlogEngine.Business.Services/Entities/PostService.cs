using AutoMapper;
using BlogEngine.Business.Interfaces.Entities;
using BlogEngine.Business.Models;
using BlogEngine.Data.Interfaces;
using BlogEngine.Data.Model.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BlogEngine.Business.Services.Entities
{
    public class PostService : IPostService
    {
        private readonly IPostRepository _postRepository;
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _unitOfWork;

        public PostService(IPostRepository postRepository, IMapper mapper, IUnitOfWork unitOfWork)
        {
            _postRepository = postRepository;
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<List<PostModel>> GetAll()
        {
            var entities = await _postRepository.GetAsync();
            return _mapper.Map<List<Post>, List<PostModel>>(entities);
        }

        public async Task<PostModel> CreatePostAsync(PostModel postRequest)
        {
            ArgumentNullException.ThrowIfNull(postRequest, nameof(postRequest));

            var existing = await _postRepository.Get(x=> x.Title == postRequest.Title);
            if(existing != null)
            {
                throw new Exception("Post already exists");
            }
            var entity = _mapper.Map<Post>(postRequest);
            _ = _postRepository.Add(entity);
            _ = await _unitOfWork.SaveChangesAsync();
            return postRequest;
        }

        public async Task<List<PostModel>> Get(string searchQuery)
        {
            var entities = await _postRepository.GetListAsync(x => x.Title.Contains(searchQuery));
            return _mapper.Map<List<Post>, List<PostModel>>(entities);
        }

        Task<List<PostModel>> IPostService.CreatePostAsync(PostModel postRequest)
        {
            throw new NotImplementedException();
        }
    }
}
