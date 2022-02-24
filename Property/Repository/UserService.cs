using Property.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Property.Data;
using Property.Repository;
namespace Property.Repository
{
    public class UserService : IUser
    {
        private PropetyContext _proj;

        public UserService(PropetyContext proj)
        {
            _proj = proj;
        }
        public string CreateUser(User user)
        {
            _proj.Users.Add(user);
            _proj.SaveChanges();
            return "Created Sucessfully";
        }

        public bool ExistsAlready(User user)
        {
            bool value = _proj.Users.Any(a => a.UserName.ToLower().Trim() == user.UserName.ToLower().Trim() && a.Password.ToLower().Trim() == user.Password.ToLower().Trim());
            return value;
        }
    }
}
