﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entity
{
    public class User
    {
        public int Id  { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string Password  { get; set; }
        public string Name { get; set; }
        public string MatricNo { get; set; }
        public string CGPA { get; set; }

    }
}
