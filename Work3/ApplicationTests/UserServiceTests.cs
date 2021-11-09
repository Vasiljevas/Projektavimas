using Xunit;
using System;
using static Work3.User;
using static Work3.IUserService;
using Moq;

namespace ApplicationTests
{
    public class UserServiceTests
    {
        private readonly IUserService _service;

        public UserServiceTests(IUserService service)
        {
            _service = service;
        }
        [Fact]
        public void GetAllUsersTest()
        {
            Assert.True(_service.GetAllUsers());
        }

        [Fact]
        public void CreateUserTest()
        {
            Assert.False(_service.CreateUser());
        }

        [Fact]
        public void DeleteUserTest()
        {
            Assert.True(_service.DeleteUser(1));
        }

        [Fact]
        public void EditUserTest()
        {
            Assert.False(_service.EditUser());
        }

        [Fact]
        public void GetUserByIdTest()
        {
            Assert.True(_service.GetUserById(1));
        }

        [Fact]
        public void ValidateUserTest()
        {
            Assert.False(_service.ValidateUser());
        }
    }
}