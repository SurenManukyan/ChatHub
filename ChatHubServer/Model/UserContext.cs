﻿using JetBrains.Annotations;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChatHubServer.Model
{
    public class UserContext : DbContext
    {
        public UserContext( DbContextOptions<UserContext> options) : base(options)
        {
        }

        public DbSet<User> Users { get; set; }

        public DbSet<Role> Roles  { get; set; }
    }
}
