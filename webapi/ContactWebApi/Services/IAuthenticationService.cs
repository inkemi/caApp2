using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ContactWebApi.Models;

namespace ContactWebApi.Services
{
    public interface IAuthenticationService
    {
        Task<AccessToken> RequestAccessToken(AuthenticationRequest authenticationRequest);
    }
}
