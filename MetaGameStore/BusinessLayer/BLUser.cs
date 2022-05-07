using IBusinessLayer;
using IRepositories;
using Models;
using Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class BLUser : IUser
    {
        private readonly IUnitOfWork unitOfWork;
        public BLUser(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }
        public bool authorization(string username, string password)
        {
            if(username != null)
            {
                throw new ArgumentException("Invalid username");
            }
            if (password != null)
            {
                throw new ArgumentException("Invalid password");
            }
            return unitOfWork.user.authorization(username, password);
        }

        public void delete(int userId)
        {
            if(userId < 0)
                throw new ArgumentException("Invalid user id");
            unitOfWork.user.delete(userId);
            unitOfWork.Save(); 
        }

        public User getByUserId(int userId)
        {
            if (userId < 0)
                throw new ArgumentException("Invalid user id");
            return unitOfWork.user.getByUserId(userId);
        }

        public User getUserByUsername(string username)
        {
            if (username == null)
                throw new ArgumentException("There is no user");
            return unitOfWork.user.getUserByUsername(username);
        }

        public void add(User user)
        {
            if (user != null)
                throw new ArgumentException("Invalid user");
            unitOfWork.user.add(user);
            unitOfWork.Save();
        }

        public void update(User user)
        {
            if (user != null)
                throw new ArgumentException("Invalid user");
            unitOfWork.user.update(user);
            unitOfWork.Save();
        }
        public IEnumerable<User> getUsers()
        {
            return unitOfWork.user.getUsers();

        }
    }
}
