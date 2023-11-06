using Autofac;
using Autofac.log4net;
using FizzBuzz.Application.Service;
using FizzBuzz.Application.Service.AutofacModules;
using FizzBuzz.Application.Service.FileManager.AppService;
using FizzBuzz.CrossCutting.Utilities.Error_Handling;
using FizzBuzz.CrossCutting.Utilities.GetPath;
using System;
using System.Collections.Generic;

using System.Linq;
using System.Web;

namespace FizzBuzzExam.Autofack_Configuration
{
    public class AutofacConfig
    {
        public static IContainer Configure()
        {
            var builder = new ContainerBuilder();

            builder.RegisterModule(new AutofacApplicationModules());
            builder.RegisterModule< Log4NetModule >();

            builder.RegisterType<Service1>().As<IFizzBuzzApiService>().InstancePerDependency();
            builder.RegisterType<FizzBuzzApplicationService>().As<IFizzBuzzApplicationSErvice>().InstancePerDependency();

           builder.RegisterType<FileManagerApplicationService>().As<IFIleManagerApplicationService>().InstancePerDependency();

            builder.RegisterType<ErrorHandling>().As<IErrorHandlin>().InstancePerDependency();
            builder.RegisterType<GetPathFile>().As<IGetPathFile>().InstancePerDependency();
            
            return builder.Build();
        }
       
    }
}