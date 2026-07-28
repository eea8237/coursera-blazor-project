using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EventEase.Models;

namespace EventEase.Services
{
    public class UserService
    {
        private List<User> users = new List<User>();

        public User GetUser(int id)
        {
            try 
            {
                return users[id];
            }
            catch
            {
                Console.WriteLine("invalid id");
                return null;
            }
        }

        public List<User> GetUsersList() => new(users);

        public void RemoveUser(int id)
        {
            try 
            {
                users.RemoveAt(id);
            }
            catch
            {
                Console.WriteLine("invalid id");
            }
        }

        public void AddUser(User user) => users.Add(user);

    }
}