﻿using System;
using System.Collections.Generic;
using System.Text;
using Autofac;
using REST.Core.Interafaces;
using REST.Core.Services;
using REST.Data.Repository;

namespace REST.Core.Modules
{
    public class ExampleRESTApiModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterGeneric(typeof(Repository<>)).As(typeof(IRepository<>)).InstancePerLifetimeScope();
            builder.RegisterType<UserService>().As<IUserService>().InstancePerLifetimeScope();
        }
    }
}
