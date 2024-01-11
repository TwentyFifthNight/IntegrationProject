﻿using System.ComponentModel.DataAnnotations;

namespace Server.Model
{
    public class AuthenticationRequest
    {
        [Required] public string Username { get; set; }
        [Required] public string Password { get; set; }

    }
}
