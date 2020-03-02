using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Contraly.Portal.Data.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Contraly.Portal.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public abstract class BaseController : ControllerBase
    {
        private readonly UserManager<User> _userManager;
        private User _appUser;
        public User CurrentUser => GetCurrentUser();

        public BaseController(UserManager<User> userManager)
        {
            this._userManager = userManager;
        }

        private User GetCurrentUser()
        {
            if (!User.Identity.IsAuthenticated)
                return null;

            if (_appUser != null)
                return _appUser;

            var userId = User?.Claims.FirstOrDefault(x => x.Type == "id")?.Value;
            _appUser = _userManager.FindByIdAsync(userId).Result;
            return _appUser;
        }
    }
}