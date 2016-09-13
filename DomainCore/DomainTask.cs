﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainCore
{
    public class DomainTask
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }

        //Foreign keys
        public int ProjectId { get; set; }
        public int? StatusId { get; set; }
        public int? PriorityId { get; set; }
        public int? UserId { get; set; }

        //Navigation properties
        public Project Project { get; set; }
        public Status Status { get; set; }
        public Priority Priorities { get; set; }
        public User User { get; set; }

        public ICollection<Comment> Comments { get; set; }
    }
}
