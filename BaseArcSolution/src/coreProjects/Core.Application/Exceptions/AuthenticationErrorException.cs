﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Application.Exceptions
{
    public class AuthenticationErrorException : Exception
    {

        public AuthenticationErrorException() : base("Kimlik doğrulama hatası!")
        {
        }

        public AuthenticationErrorException(string? message) : base(message)
        {
        }
    }
}
