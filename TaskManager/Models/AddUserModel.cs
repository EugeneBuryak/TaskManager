﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TaskManager.Models
{
    public class AddUserModel
    {
        [Required]
        public string Email { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [Required]
        [DataType(DataType.Password)]
        [Compare("Password")]
        [Display(Name = "Confirm password")]
        public string ConfirmPassword { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Role { get; set; }

        public string Surname { get; set; }
        [DataType(DataType.PhoneNumber)]
        [Display(Name = "Phone Number")]
        public string PhoneNumber { get; set; }
        [DataType(DataType.Date)]
        [Display(Name = "Date of birth")]
        public DateTime? BirthDate { get; set; }


    }
}