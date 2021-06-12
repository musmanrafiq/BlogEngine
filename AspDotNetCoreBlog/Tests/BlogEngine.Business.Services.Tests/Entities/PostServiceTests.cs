using AutoMapper;
using BlogEngine.Business.Services.Entities;
using BlogEngine.Data.Interfaces;
using BlogEngine.Data.Model.Entities;
using BlogEngine.Tests.Helpers;
using Moq;
using System.Collections.Generic;
using Xunit;

namespace BlogEngine.Business.Services.Tests.Entities
{
    public class PostServiceTests
    {

        [Fact]
        public async System.Threading.Tasks.Task PostServiceTests_GetAll_CanGetAllPostsSuccessfully()
        {
            // Arrange
            int numberOfPosts = 3;
            var (mapper, mockRepo) = SetupDependencies(numberOfPosts);

            // Act
            var a = new PostService(mockRepo.Object, mapper);
            var allPosts = await a.GetAll();

            // Assert
            Assert.Equal(3, allPosts.Count);

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

        private (IMapper, Mock<IPostRepository>) SetupDependencies(int numberOfPosts)
        {
            Mock<IPostRepository> mockRepo = new Mock<IPostRepository>(MockBehavior.Default);
            mockRepo.Setup(m => m.GetAsync()).ReturnsAsync(value: GeneratePosts(numberOfPosts));
            IMapper mapper = AutoMapperHelper.SetupMapper();
            return (mapper, mockRepo);
        }

        #endregion
    }
}
