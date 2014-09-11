namespace DesignPatterns.Demo
{
    using Caliburn.Micro;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.Composition;
    using System.ComponentModel.Composition.Hosting;
    using System.IO;
    using System.Linq;
    using System.Windows;

    public class AppBootstrapper : BootstrapperBase
    {
        private CompositionContainer container;

        public AppBootstrapper()
        {
            var config = new TypeMappingConfiguration
            {
                DefaultSubNamespaceForViews = "DesignPatterns.Demo.View",
                DefaultSubNamespaceForViewModels = "DesignPatterns.Demo.ViewModel"
            };

            ViewLocator.ConfigureTypeMappings(config);
            ViewModelLocator.ConfigureTypeMappings(config);

            Initialize();
        }

        protected override void Configure()
        {
            var aggregateCatalog = new AggregateCatalog();
            aggregateCatalog.Catalogs.Add(new DirectoryCatalog(".", "DesignPatterns.Demo.*.*"));

            if (Directory.Exists("Custom"))
                aggregateCatalog.Catalogs.Add(new DirectoryCatalog("./Custom/", "*.DLL"));

            container = new CompositionContainer(aggregateCatalog);

            var batch = new CompositionBatch();

            batch.AddExportedValue<IWindowManager>(new WindowManager());
            batch.AddExportedValue<IEventAggregator>(new EventAggregator());
            batch.AddExportedValue(container);

            container.Compose(batch);
        }

        protected override void OnStartup(object sender, StartupEventArgs e)
        {
            DisplayRootViewFor<ShellViewModel>();
        }

        protected override object GetInstance(Type serviceType, string key)
        {
            string contract = string.IsNullOrEmpty(key) ? AttributedModelServices.GetContractName(serviceType) : key;
            var exports = container.GetExportedValues<object>(contract);

            if (exports.Any())
                return exports.First();

            throw new Exception(string.Format("Could not locate any instances of contract {0}.", contract));
        }

        protected override IEnumerable<object> GetAllInstances(Type serviceType)
        {
            return container.GetExportedValues<object>(AttributedModelServices.GetContractName(serviceType));
        }

        protected override void BuildUp(object instance)
        {
            container.SatisfyImportsOnce(instance);
        }
    }
}