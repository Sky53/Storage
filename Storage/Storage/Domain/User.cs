﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Storage.Domain
{
    public class User
    {
        public Guid Id { get; set; }
        public List<Order> Orders { get; set; }
        public string NameUser { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public DateTime DateOfBrith { get; set; }
        public bool IsDeleted { get; set; }
    }
}
