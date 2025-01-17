﻿using System;
using Licenser.Server.Domain.Entities.Abstractions;
using Microsoft.AspNetCore.Identity;

namespace Licenser.Server.Domain.Entities
{
    public class Role : IdentityRole, IEntity<string>
    {
        public Role()
        {

        }

        public Role(string roleName) : base(roleName)
        {

        }

        public override string Id { get; set; } = Guid.NewGuid().ToString();
        public string Description { get; set; }
        public DateTime Timestamp { get; set; } = DateTime.Now;

        public override string ToString()
        {
            return Name;
        }
    }
}