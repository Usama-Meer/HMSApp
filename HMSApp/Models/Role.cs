﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMSApp.Models
{
    public class Role
    {

        [Key]
        public int RoleId { get; set; }

        [Required]
        public string RoleName { get; set; }

        [Required]
        public string RoleDescription { get; set; }
    }
}
