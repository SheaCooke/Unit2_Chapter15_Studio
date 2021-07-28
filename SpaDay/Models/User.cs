﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SpaDay.Models
{
    public class User
    {

        public string UserName { get; set; }
        public string Email { get; set; }
        public string PassWord { get; set; }

        public DateTime DateJoined = DateTime.Now;

        public string VerifyPassword { get; set; }

    }
}
