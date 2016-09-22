﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TaskManager.Models
{
    public class ApplicationUserModel
    {
        public string Id { get; set; }
        public string Email { get; set; }
        public string UserName { get; set; }

        public ICollection<CommentModel> Comments { get; set; }
        public ICollection<ProjectModel> Projects { get; set; }
        public ICollection<TaskModel> Tasks { get; set; }

        public ApplicationUserModel()
        {
            Comments = new List<CommentModel>();
            Projects = new List<ProjectModel>();
            Tasks = new List<TaskModel>();
        }
    }
}