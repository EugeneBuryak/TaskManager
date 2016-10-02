﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace TaskManager.Models
{
    public class ViewTasksModel
    {
        [HiddenInput(DisplayValue = false)]
        public int Id { get; set; }

        [Required]
        [MaxLength(25)]
        public string Title { get; set; }

        [Required]
        [MaxLength(255)]
        public string Description { get; set; }

        [DataType(DataType.Date)]
        public DateTime? CreationDate { get; set; }

        [DataType(DataType.DateTime)]
        [Required]
        public DateTime? DeadLine { get; set; }

        [HiddenInput(DisplayValue = false)]
        public int ProjectId { get; set; }

        [HiddenInput(DisplayValue = false)]
        public int? StatusId { get; set; }

        [HiddenInput(DisplayValue = false)]
        public int? PriorityId { get; set; }

        [HiddenInput(DisplayValue = false)]
        public string AssignedToId { get; set; }

        [HiddenInput(DisplayValue = false)]
        public string CreatedById { get; set; }

        [Display(Name = "Status")]
        [Required]
        public string StatusTitle { get; set; }

        [Display(Name = "Priority")]
        [Required]
        public string PriorityTitle { get; set; }

        [Display(Name = "Assign to")]
        [EmailAddress]
        public string AssignedToEmail { get; set; }

        [HiddenInput(DisplayValue = false)]
        public string CreatedByEmail { get; set; }

        [Display(Name = "Project")]
        [Required]
        public string ProjectTitle { get; set; }

        [HiddenInput(DisplayValue = false)]
        public List<CommentModel> Comments { get; set; }
    }
}