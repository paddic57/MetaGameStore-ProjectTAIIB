using Models.Models;
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
        public int authorization(string username, string password);
        //delete
        public void delete(int userId);
        //getById
        public User getByUserId(int userId);
        //post
        public void post(User user);
        //put
        public void put(User user);

        //?get-all?
        
    }
}
