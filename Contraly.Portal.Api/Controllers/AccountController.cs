using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Contraly.Portal.Business.Interfaces;
using Contraly.Portal.Data.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Contraly.Portal.Api.ViewModels;

namespace Contraly.Portal.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : BaseController
    {
        private readonly UserManager<User> _userManager;
        private readonly ITokenService _tokenService;

        public AccountController(UserManager<User> userManager,
                                ITokenService tokenService)
            : base(userManager)
        {
            this._userManager = userManager;
            this._tokenService = tokenService;
        }

        [HttpPost]
        [AllowAnonymous]
        [ProducesResponseType(typeof(string), 200)]
        [Route("signin")]
        public async Task<IActionResult> SignIn([FromBody] SignInViewModel model)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var user = await _userManager.FindByEmailAsync(model.Email);
            if (user == null)
                return BadRequest("Wrong email or password");

            //var isEmailConfirmed = await _userManager.IsEmailConfirmedAsync(user);
            //if (!isEmailConfirmed)
            //    return BadRequest("The email is not confirmed");

            var result = await _userManager.CheckPasswordAsync(user, model.Password);
            if (!result)
                return BadRequest("Wrong email or password");

            return Ok(_tokenService.Generate(user));
        }

        [HttpPost]
        [AllowAnonymous]
        [ProducesResponseType(typeof(string), 200)]
        [Route("signup")]
        public async Task<IActionResult> SignUp([FromBody] SignUpViewModel model)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var newUser = new User
            {
                UserName = model.Email,
                Email = model.Email,
                Name = model.Name,
                CreatedDate = DateTime.UtcNow
            };

            var result = await _userManager.CreateAsync(newUser, model.Password);
            if (!result.Succeeded)
                return BadRequest("Sorry, an unexpected error occured");

            return Ok("We've sent you an email to verify that the address is correct");
        }

    }
}