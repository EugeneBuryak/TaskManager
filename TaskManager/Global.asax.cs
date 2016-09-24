﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using AutoMapper;
using ServiceMapper;
using TaskManager.Models;

namespace TaskManager
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start(object sender, EventArgs e)
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            MVCMapperConfig.ConfigureAutoMapper();
        }
    }

    class MVCMapperProfile : Profile
    {
        [Obsolete]
        protected override void Configure()
        {
            CreateMap<ServiceEntities.Project, ProjectModel>()
                .ForMember(x => x.TaskCount, op => op.MapFrom(project => project.Tasks.Count))
                .ForMember(x => x.ClientsCount, op => op.MapFrom(project => project.Clients.Count))
                .MaxDepth(2);
            CreateMap<ServiceEntities.ApplicationUser, ApplicationUserModel>();
            CreateMap<ServiceEntities.ApplicationUser, EditUserModel>()
                .ForMember(x => x.Name, op => op.MapFrom(user => user.ClientProfile.Name))
                .ForMember(x => x.Surname, x => x.MapFrom(user => user.ClientProfile.Surname));
            CreateMap<ServiceEntities.ServiceTask, ViewTasksModel>()
                .ForMember(x => x.AssignedToEmail, op => op.MapFrom(user => user.Client.Email))
                .ForMember(x => x.CreatedByEmail, op => op.MapFrom(user => user.CreatedBy.Email))
                .ForMember(x => x.PriorityTitle, op => op.MapFrom(title => title.Priority.Title))
                .ForMember(x => x.StatusTitle, op => op.MapFrom(status => status.Status.Title))
                .MaxDepth(1);
        }
    }
    public static class MVCMapperConfig
    {
        public static void ConfigureAutoMapper()
        {
            Mapper.Initialize(x =>
            {
                x.AddProfile(new MVCMapperProfile());
                x.AddProfile(new MapperProfile());
            });
        }
    }
}
