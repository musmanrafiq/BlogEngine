using AutoMapper;
using BlogEngine.Business.Interfaces.Entities;
using BlogEngine.Business.Models;
using BlogEngine.Data.Interfaces;
using BlogEngine.Data.Model.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BlogEngine.Business.Services.Entities
{
    public class PromptService : IPromptService
    {
        private readonly IPromptRepository _promptRepository;
        private IMapper _mapper;

        public PromptService(IPromptRepository promptRepository, IMapper mapper)
        {
            _promptRepository = promptRepository;
            _mapper = mapper;
        }

        public async Task<List<PromptModel>> GetAll()
        {
            var entities = await _promptRepository.GetAsync().ConfigureAwait(false);
            return _mapper.Map<List<Prompt>, List<PromptModel>>(entities);
        }
    }
}
