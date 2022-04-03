using IRepositories;
using Models;
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
        private readonly MyContext context;

        public UserRepository(MyContext context)
        {
            this.context = context;
        }


        public int authorization(string username, string password)
        {
            return -1;
            //return this.unitOfWork.userRepository.authorization(username, password);
        }

        public void delete(int userId)
        {
            //this.unitOfWork.userRepository.delete(userId);
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
