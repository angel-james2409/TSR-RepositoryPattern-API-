using Property.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Property.Repository
{
    public interface IUser
    {
        string CreateUser(User user);

        bool ExistsAlready(User user);
    }
}
