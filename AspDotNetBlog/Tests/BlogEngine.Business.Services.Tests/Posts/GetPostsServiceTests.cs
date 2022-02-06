using AutoMapper;
using BlogEngine.Business.Services.Entities;
using BlogEngine.Data.Interfaces;
using BlogEngine.Data.Model.Entities;
using BlogEngine.Tests.Helpers;
using FluentAssertions;
using Moq;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xunit;

namespace BlogEngine.Business.Services.Tests.Posts
{
    public class GetPostsServiceTests
    {
        private readonly PostService _mockPostService;
        private readonly Mock<IPostRepository> _mockPostRepository;
        private readonly Mock<IUnitOfWork> _mockUnitOfWork;
        private readonly IMapper _mockuMapper;

        public GetPostsServiceTests()
        {            
            _mockPostRepository = new Mock<IPostRepository>(MockBehavior.Default);
            _mockuMapper = AutoMapperHelper.SetupMapper();
            _mockUnitOfWork = new Mock<IUnitOfWork>();
            _mockPostService =  new PostService(_mockPostRepository.Object, _mockuMapper, _mockUnitOfWork.Object);
        }

        [Fact]
        public async Task PostServiceTests_GetAll_ShouldGetAllPostsSuccessfully()
        {
            // Arrange
            int numberOfPosts = 3;
            _mockPostRepository.Setup(m => m.GetAsync()).ReturnsAsync(value: GeneratePosts(numberOfPosts));

            // Act
            var allPosts = await _mockPostService.GetAll();

            // Assert
            allPosts.Count.Should().Be(numberOfPosts);
        }


        #region private methods

        private List<Post> GeneratePosts(int noOfPosts)
        {
            var tempPosts = new List<Post>();

            for (int i = 0; i < noOfPosts; i++)
            {
                tempPosts.Add(new Post() { Id = i, Title = $"{i}" });
            }
            return tempPosts;
        }

        #endregion
    }
}
