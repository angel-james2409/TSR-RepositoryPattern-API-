using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Property.Models;
using Property.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Property.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUser _user;

        private readonly IWebHostEnvironment _env;

        public UserController(IUser user, IWebHostEnvironment env)
        {

            _user = user;
            _env = env;
        }

        [HttpPost("Create")]
        public string Create([FromBody] User user)
        {
            if (_user.ExistsAlready(user))
            {
                return "User Exists ";
            }
            return _user.CreateUser(user);
        }

        [HttpPost("Login")]
        public string Login([FromBody] User user)
        {
            if (_user.ExistsAlready(user))
            {
                return "Welcome ";
            }
            return "please enter correct username or password";
        }

    }
}
