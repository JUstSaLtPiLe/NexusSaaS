﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace NexusSaaS.Entity
{
    public class Role
    {
        [Key]
        public int RoleId { get; set; }
        public string Name { get; set; }
        public RoleStatus Status { get; set; }
        public List<RoleUser> RoleUsers { get; set; }

    }

    public enum RoleStatus
    {
        Active = 1,
        Deactive = 0
    }
}
