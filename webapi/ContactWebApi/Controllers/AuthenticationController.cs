using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ContactWebApi.Models;
using ContactWebApi.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ContactWebApi.Controllers
{
    [Route("api/authenticate")]
    public class AuthenticationController : Controller
    {
        private readonly IAuthenticationService _authenticationService;

        public AuthenticationController(IAuthenticationService authenticationService)
        {
            _authenticationService = authenticationService;
        }
            [HttpPost]
            public async Task<IActionResult> Authenticate([FromBody] AuthenticationRequest request)
            {
                var token = await _authenticationService.RequestAccessToken(request);
                if (token == null)
                {
                    return new UnauthorizedResult();
                }
                return new JsonResult(token);
            }
    }
}
