﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using ServiceEntities;

namespace TaskManager.Models
{
    public class ProjectModel
    {
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        [MaxLength(255)]
        public string Description { get; set; }

        public ICollection<ServiceTask> Tasks { get; set; }
        public ICollection<ApplicationUser> Clients { get; set; }


        public ProjectModel()
        {
            Tasks = new List<ServiceTask>();
            Clients = new List<ApplicationUser>();

        }
    }
}