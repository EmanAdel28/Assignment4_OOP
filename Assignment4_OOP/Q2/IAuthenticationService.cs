﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4_OOP.Q2
{
    internal interface IAuthenticationService
    {
        bool AuthenticateUser(string username , string password);
        bool AuthorizeUser(string username , string role);
    }
}
