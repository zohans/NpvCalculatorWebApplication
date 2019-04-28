using Castle.MicroKernel.Registration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using NpvWebApplication.Common;

namespace NpvWebApplication.Installer
{

    public class ServiceInstaller : IWindsorInstaller
    {
        public void Install(Castle.Windsor.IWindsorContainer container, Castle.MicroKernel.SubSystems.Configuration.IConfigurationStore store)
        {
            container.Register(
                 Component
                 .For<INpvCalculator>()
                 .ImplementedBy<NpvCalculator>()
                 .LifestyleTransient());
        }
    }
    
}