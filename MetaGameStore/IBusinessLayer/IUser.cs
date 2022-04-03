using Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IBusinessLayer
{
    public interface IUser
    {
        public bool authorization(string username, string password);
        public bool delete(int userId);
        public User getByUserId(int userId);
        public bool post(User user);
        public bool put(User user);
        public User getUserByUsername(string username);
    }
}
