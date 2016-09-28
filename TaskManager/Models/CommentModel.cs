﻿using System.Web.Mvc;

namespace TaskManager.Models
{
    public class CommentModel
    {
        [HiddenInput(DisplayValue = false)]
        public int Id { get; set; }
        public string Text { get; set; }
        [HiddenInput(DisplayValue = false)]
        public int DomainTaskId { get; set; }
        [HiddenInput(DisplayValue = false)]
        public string ClientId { get; set; }

        public string ClientEmail { get; set; }
    }
}