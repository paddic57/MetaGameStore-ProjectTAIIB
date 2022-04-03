using IRepositories;
using Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly UnitOfWork unitOfWork;

        public UserRepository(UnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }


        public int authorization(string username, string password)
        {
            return this.unitOfWork.userRepository.authorization(username, password);
        }

        public void delete(int userId)
        {
            this.unitOfWork.userRepository.delete(userId);
        }

        public User getByUserId(int userId)
        {
            throw new NotImplementedException();
        }

        public void post(User user)
        {
            throw new NotImplementedException();
        }

        public void put(User user)
        {
            throw new NotImplementedException();
        }
    }
}
