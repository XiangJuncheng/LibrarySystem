﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace librarySytstem.Domain.Entities
{
    public class User
    {
        public long Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public DateTime CreateTime { get; set; }
        public long RoleId { get; set; }
    }
}