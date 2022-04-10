using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IRepositories
{
    public interface IUserRepository
    {
        //authorization
        public bool authorization(string username, string password);
        //delete
        public bool delete(int userId);
        //getById
        public User getByUserId(int userId);
        //post
        public void post(User user);
        //put
        public void put(User user);

        public User getUserByUsername(string username);

        //?get-all?
        
    }
}
