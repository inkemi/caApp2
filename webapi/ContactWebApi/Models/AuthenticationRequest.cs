﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ContactWebApi.Models
{
    public class AuthenticationRequest
    {
        public string username { get; set; }
        public string password { get; set; }
    }
}
