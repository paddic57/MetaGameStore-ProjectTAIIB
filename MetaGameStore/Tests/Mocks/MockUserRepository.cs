using IRepositories;
using Models;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MockRepository
{
    public class MockUserRepository: Mock<IUserRepository>
    {
        public MockUserRepository mockDelete()
        {
            Setup(x => x.delete(It.IsAny<int>()));
            return this;
        }
        public MockUserRepository mockGetByUserId(User result)
        {
            Setup(x => x.getByUserId(It.IsAny<int>()))
                .Returns(result);
            return this;
        }
        public MockUserRepository mockAdd()
        {
            Setup(x => x.add(It.IsAny<User>()));
            return this;
        }
        public MockUserRepository mockUpdate()
        {
            Setup(x => x.update(It.IsAny<User>()));
            return this;
        }
        public MockUserRepository mockGetUserByUsername(User result)
        {
            Setup(x => x.getUserByUsername(It.IsAny<string>()))
                .Returns(result);
            return this;
        }
        public MockUserRepository mockGetUsers(IEnumerable<User> result)
        {
            Setup(x => x.getUsers());
            return this;
        }

    }
}
