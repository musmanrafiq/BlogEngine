using AutoMapper;
using BlogEngine.Business.Interfaces.Entities;
using BlogEngine.Business.Models;
using BlogEngine.Business.Services.Entities;
using BlogEngine.Data.Interfaces;
using BlogEngine.Data.Model.Entities;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace BlogEngine.Website.Tests.Admin.Controller.Tests
{
    
    public class PostInsert
    {
        private readonly Mock<IMapper> _mapper;
        private readonly Mock<IPostRepository> _postRepository;
        private readonly PostService _postService;
        private readonly Mock<IUnitOfWork> _unitOfWork;

        public PostInsert()
        {
            _mapper = new Mock<IMapper>();
            _postRepository = new Mock<IPostRepository>();
            _unitOfWork = new Mock<IUnitOfWork>();

            _postService = new PostService(_postRepository.Object, _mapper.Object, _unitOfWork.Object);
        }

        [Fact]
        public async Task ShouldReturnPostWithRequiredResponseValue()
        {
            //Arrange
            var postRequest = new PostModel {
                Title = "Test Post",
                Content = "Test Post Content"                
            };
            //Act
            var result = await _postService.CreatePostAsync(postRequest);

            _postRepository.Verify(x=> x.Add(It.IsAny<Post>()), Times.Once);
            _unitOfWork.Verify(x => x.SaveChangesAsync(), Times.Once);


            //Assert
            Assert.NotNull(result);
            Assert.Equal(postRequest.Title, result.Title);
        }

        [Fact]
        public async Task ShouldNotAddResponseValue()
        {
            //Arrange
            var postRequest = new PostModel
            {
                Title = "Test Post",
                Content = "Test Post Content"
            };            
            _postRepository.Setup(x => x.Get(It.IsAny<Expression<Func<Post, bool>>>())).ReturnsAsync(new Post { Title = postRequest.Title});
            
            //Act
            _postRepository.Verify(x=>x.Add(It.IsAny<Post>()), Times.Never);
            _unitOfWork.Verify(x => x.SaveChangesAsync(), Times.Never);            
            
            var exception = await Assert.ThrowsAsync<Exception>(() => _postService.CreatePostAsync(postRequest));
            Assert.Equal("Post already exists", exception.Message);

        }

        [Fact]
        public async Task ShouldThrowNullExceptionIfPostModelIsNull()
        {
            //Arrange
            PostModel postRequest = null;

            //Assert
            _postRepository.Verify(x => x.Add(It.IsAny<Post>()), Times.Never);
            _unitOfWork.Verify(x => x.SaveChangesAsync(), Times.Never);
            var exception = await Assert.ThrowsAsync<ArgumentNullException>(() => _postService.CreatePostAsync(postRequest));
        }
    }
}
