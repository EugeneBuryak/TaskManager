using System.Data.Entity;
using Microsoft.AspNet.Identity.EntityFramework;

using DomainEntities;
using DomainEF.Interfaces;
using System;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace DomainEF
{
    public class TaskManagerContext : IdentityDbContext<ApplicationUser>, ITaskManagerContext
    {
        public TaskManagerContext()
            : base("TaskManagerDB")
        {
            Configuration.ProxyCreationEnabled = false;
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();
            modelBuilder.Entity<ApplicationUser>().HasMany(x => x.DomainTasks).WithRequired(x => x.CreatedBy).WillCascadeOnDelete(false);
            modelBuilder.Entity<ApplicationUser>().HasOptional(x => x.ClientProfile);

            modelBuilder.Entity<Project>().HasMany(x => x.Tasks).WithRequired(x => x.Project).WillCascadeOnDelete(true);
            modelBuilder.Entity<DomainTask>().Property(x => x.CreatedBy_Id).IsRequired();
            modelBuilder.Entity<Project>().HasMany(x => x.Clients);
            modelBuilder.Entity<ApplicationUser>().HasMany(x => x.DomainTasks);

            base.OnModelCreating(modelBuilder);
        }

        public virtual DbSet<ClientProfile> ClientProfiles { get; set; }
        public virtual DbSet<Project> Projects { get; set; }
        public virtual DbSet<Status> Status { get; set; }
        public virtual DbSet<Priority> Priorities { get; set; }
        public virtual DbSet<Comment> Comments { get; set; }
        public virtual DbSet<DomainTask> Tasks { get; set; }
    }

}