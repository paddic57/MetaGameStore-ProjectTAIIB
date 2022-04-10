using IRepositories;
using Models;
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


        public bool authorization(string username, string password)
        {
            return this.context.Users.Where(x => (x.username == username) && (x.password == password)).Any();
        }

        public bool delete(int userId)
        {
            User user = getByUserId(userId);
            if(user != null)
            {
                this.context.Users.Remove(user);
                return true;
            }
            return false;
        }

        public User getByUserId(int userId)
        {
            return this.context.Users.Where(x => x.Id == userId).Single();
        }

        public User getUserByUsername(string username)
        {
            return this.context.Users.Where(x => username.Equals(username)).Single();
        }

        public void add(User user)
        {
            this.context.Users.Add(user);
        }

        public void update(User user)
        {
            User u = getByUserId(user.Id);
            if(u != null)
            {
                u.address = user.address;
                u.country = user.country;
                u.city = user.city;
                u.phone_number = user.phone_number;
                u.postal_code = user.postal_code;
            }
        }
    }
}
