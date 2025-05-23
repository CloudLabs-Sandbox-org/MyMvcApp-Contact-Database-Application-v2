using System.Collections.Generic;
using System.Linq;
using MyMvcApp.Models;

namespace MyMvcApp.Services
{
    public class UserService
    {
        private static List<User> _users = new List<User>();
        private static int _nextId = 1;

        public List<User> GetAll()
        {
            return _users.ToList();
        }

        public User GetById(int id)
        {
            return _users.FirstOrDefault(u => u.Id == id);
        }

        public void Add(User user)
        {
            user.Id = _nextId++;
            _users.Add(user);
        }

        public bool Update(int id, User updatedUser)
        {
            var user = GetById(id);
            if (user == null) return false;
            user.Name = updatedUser.Name;
            user.Email = updatedUser.Email;
            return true;
        }

        public bool Delete(int id)
        {
            var user = GetById(id);
            if (user == null) return false;
            _users.Remove(user);
            return true;
        }

        public List<User> Search(string query)
        {
            if (string.IsNullOrWhiteSpace(query))
                return GetAll();
            query = query.ToLower();
            return _users.Where(u =>
                (!string.IsNullOrEmpty(u.Name) && u.Name.ToLower().Contains(query)) ||
                (!string.IsNullOrEmpty(u.Email) && u.Email.ToLower().Contains(query))
            ).ToList();
        }
    }
}
