﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace BanHang.Models
{
    [Table("Accounts")]
    public class Account
    {
        [key]
        public int id { get; set; }
        [Required, StringLength(30)]
        public string Name { get; set; }
        [Required]
        public string Phone { get; set; }
        public string address { get; set; }
        [Required, EmailAddress]
        public string email { get; set; }
        public object Email { get; internal set; }
        [Required]
        public string password { get; set; }
        [NotMapped]
        [Required]
        [System.ComponentModel.DataAnnotations.Compare("password")]
        public string Confirm_password { get; set; }
    }
}
