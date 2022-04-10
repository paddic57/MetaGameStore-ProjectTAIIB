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
        public bool authorization(string username, string password);

        public bool delete(int userId);
        public User getByUserId(int userId);
        public void add(User user);
        public void update(User user);
        public User getUserByUsername(string username);
        
    }
}
