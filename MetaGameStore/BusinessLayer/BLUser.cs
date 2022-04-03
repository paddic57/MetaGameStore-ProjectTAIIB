using IBusinessLayer;
using Models.Models;
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
        private readonly UnitOfWork unitOfWork;
        public BLUser(UnitOfWork unitOfWork)
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
            if (unitOfWork.user.getUserByUsername(username) != null)
            {
                throw new ArgumentException("There is no user");
            }

        }

        public bool delete(int userId)
        {
            throw new NotImplementedException();
        }

        public User getByUserId(int userId)
        {
            throw new NotImplementedException();
        }

        public bool post(User user)
        {
            throw new NotImplementedException();
        }

        public bool put(User user)
        {
            throw new NotImplementedException();
        }
    }
}
