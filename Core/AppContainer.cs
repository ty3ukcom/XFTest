﻿using Autofac;
using Autofac.Extras.CommonServiceLocator;
using CommonServiceLocator;
using Xamarin.Forms;

namespace XFTest.Core
{
    public abstract class AppContainer
    {
        public void Setup()
        {
            var containerBuilder = new ContainerBuilder();

            this.RegisterServices(containerBuilder);

            var container = containerBuilder.Build();

            ServiceLocator.SetLocatorProvider(() => new AutofacServiceLocator(container));

            container.BeginLifetimeScope();
        }

        protected virtual void RegisterServices(ContainerBuilder containerBuilder)
        {
            containerBuilder.RegisterType<App>().SingleInstance();

            containerBuilder.RegisterType<NavigationService>().As<INavigationService>().SingleInstance();
            containerBuilder.RegisterType<JobDialogService>().As<IJobDialogService>().InstancePerDependency();

            containerBuilder.RegisterType<MainView>().Named<Page>(ViewNames.MainView).As<MainView>().InstancePerDependency();
            containerBuilder.RegisterType<SecondView>().Named<Page>(ViewNames.SecondView).As<SecondView>().InstancePerDependency();

            containerBuilder.RegisterType<MainViewModel>().InstancePerDependency();
            containerBuilder.RegisterType<SecondViewModel>().InstancePerDependency();
        }
    }
}
