using Autofac;
using FizzBuzz.Infrastructure.Repository;
using FizzBuzz.Infrastructure.Repository.FileManager.Infrastructure.Repository;
using System;
using System.Collections.Generic;
using System.IO.Abstractions;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Module = Autofac.Module;

namespace FizzBuzz.Application.Service.AutofacModules
{
    public class AutofacApplicationModules : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<FileSystem>().As<IFileSystem>().InstancePerDependency();
            builder.RegisterType< FizzBuzzRepository >().As<IFizzBuzzRepository>().InstancePerDependency();
            builder.RegisterType<FileManagerInfrastructureRepository>().As<IFileManagerInfrastructureRepository>().InstancePerDependency();
            
            base.Load(builder);
        }
    }
}
