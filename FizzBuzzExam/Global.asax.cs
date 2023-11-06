using System;
using Autofac;
using Autofac.Integration.Wcf;
using FizzBuzzExam.Autofack_Configuration;


namespace FizzBuzzExam
{
    public class Global : System.Web.HttpApplication
    {
         protected void Application_Start(object sender, EventArgs e)
         {
             log4net.Config.XmlConfigurator.Configure();
             IContainer container = AutofacConfig.Configure();
             AutofacHostFactory.Container = container;
         }
        
    }
}