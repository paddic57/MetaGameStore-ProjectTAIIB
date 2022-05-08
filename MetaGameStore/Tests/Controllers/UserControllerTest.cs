using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using MetaGameStore.Controllers;
using Microsoft.AspNetCore.Mvc;
using Models;
using BusinessLayer;
using MockRepository;

namespace Tests.Controllers
{
    public class UserControllerTest
    {
        [Fact(DisplayName = "usercontoller indexNotNull")]
        public void IndexNotNullTest()
        {
            
            var mockUsersList = new List<User>()
            {
                new User()
                {
                    Id = 1,
                    UserType = 2,
                    Username = "username1",
                    Password = "password1",
                    Email = "email2@.com",
                    PhoneNumber = 323234432,
                    City = "osw",
                    PostalCode = "23-500",
                    Address = "ulspa",
                    Country = "pl"
                },
                new User()
                {
                    Id = 2,
                    UserType = 2,
                    Username = "username2",
                    Password = "password2",
                    Email = "email2@.com",
                    PhoneNumber = 323234432,
                    City = "osw",
                    PostalCode = "23-500",
                    Address = "ulspa",
                    Country = "pl"
                }

            };

            var mockUsersRepo = new MockUserRepository().mockGetUsers(mockUsersList);


            var testUnitOfWork = new UnitOfWorkTests();

            testUnitOfWork.user = mockUsersRepo.Object;
            var service = new BLUser(testUnitOfWork);

            UsersController controller = new UsersController(service);
            ViewResult result = controller.Index() as ViewResult;
            Assert.NotNull(result);
        }
        [Fact(DisplayName = "usercontoller details viewdata")]
        public void DetailsTest()
        {
            var mockUsersList = new List<User>()
            {
                new User()
                {
                    Id = 1,
                    UserType = 2,
                    Username = "username1",
                    Password = "password1",
                    Email = "email2@.com",
                    PhoneNumber = 323234432,
                    City = "osw",
                    PostalCode = "23-500",
                    Address = "ulspa",
                    Country = "pl"
                },
                new User()
                {
                    Id = 2,
                    UserType = 2,
                    Username = "username2",
                    Password = "password2",
                    Email = "email2@.com",
                    PhoneNumber = 323234432,
                    City = "osw",
                    PostalCode = "23-500",
                    Address = "ulspa",
                    Country = "pl"
                }

            };

            var mockUsersRepo = new MockUserRepository().mockGetUsers(mockUsersList);


            var testUnitOfWork = new UnitOfWorkTests();

            testUnitOfWork.user = mockUsersRepo.Object;
            var service = new BLUser(testUnitOfWork);

            UsersController controller = new UsersController(service);
            ViewResult result = controller.Detail(1) as ViewResult;
            User user = (User) result.ViewData.Model;
            /*Assert.Equal("username2", user.Username);*/
        }
        [Fact(DisplayName ="usercontoller delete redirection")]
        public void DeleteRedirectionTest()
        {
            var mockUsersList = new List<User>()
            {
                new User()
                {
                    Id = 1,
                    UserType = 2,
                    Username = "username1",
                    Password = "password1",
                    Email = "email2@.com",
                    PhoneNumber = 323234432,
                    City = "osw",
                    PostalCode = "23-500",
                    Address = "ulspa",
                    Country = "pl"
                },
                new User()
                {
                    Id = 2,
                    UserType = 2,
                    Username = "username2",
                    Password = "password2",
                    Email = "email2@.com",
                    PhoneNumber = 323234432,
                    City = "osw",
                    PostalCode = "23-500",
                    Address = "ulspa",
                    Country = "pl"
                }

            };

            var mockUsersRepo = new MockUserRepository().mockGetUsers(mockUsersList);


            var testUnitOfWork = new UnitOfWorkTests();

            testUnitOfWork.user = mockUsersRepo.Object;
            var service = new BLUser(testUnitOfWork);

            UsersController controller = new UsersController(service);
            RedirectToRouteResult result = (RedirectToRouteResult)controller.Delete(1);
            Assert.Equal("Index", result.RouteValues["action"]);
        }
        [Fact(DisplayName = "usercontoller delete viewdata")]
        public void DeleteDataTest()
        {
            var mockUsersList = new List<User>()
            {
                new User()
                {
                    Id = 1,
                    UserType = 2,
                    Username = "username1",
                    Password = "password1",
                    Email = "email2@.com",
                    PhoneNumber = 323234432,
                    City = "osw",
                    PostalCode = "23-500",
                    Address = "ulspa",
                    Country = "pl"
                },
                new User()
                {
                    Id = 2,
                    UserType = 2,
                    Username = "username2",
                    Password = "password2",
                    Email = "email2@.com",
                    PhoneNumber = 323234432,
                    City = "osw",
                    PostalCode = "23-500",
                    Address = "ulspa",
                    Country = "pl"
                }

            };

            var mockUsersRepo = new MockUserRepository().mockGetUsers(mockUsersList);


            var testUnitOfWork = new UnitOfWorkTests();

            testUnitOfWork.user = mockUsersRepo.Object;
            var service = new BLUser(testUnitOfWork);

            UsersController controller = new UsersController(service);
            ViewResult result = controller.Detail(1) as ViewResult;
            /*Assert.Equal("Record Delete Successfully", result.ViewData["Messsage"]);*/
        }
    }
}
