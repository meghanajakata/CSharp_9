﻿using System;

namespace CSharpFeatures_9.Record
{
    public class User
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Password { get; set; }
        public DateTime Created_at { get; set; }  
    }
}
