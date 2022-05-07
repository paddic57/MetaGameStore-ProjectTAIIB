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
            return this.context.Users.Where(x => (x.Username == username) && (x.Password == password)).Any();
        }

        public void delete(int userId)
        {
            User user = getByUserId(userId);
            if(user != null)
            {
                this.context.Users.Remove(user);
            }
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
                u.Address = user.Address;
                u.Country = user.Country;
                u.City = user.City;
                u.PhoneNumber = user.PhoneNumber;
                u.PostalCode = user.PostalCode;
            }
        }

        public IEnumerable<User> getUsers()
        {
            return this.context.Users;
        }
    }
}
