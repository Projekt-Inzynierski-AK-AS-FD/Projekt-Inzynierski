using Abituria.controls;
using Abituria.datamodels;
using Abituria.viewmodel;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Navigation;
namespace Abituria
{
    public partial class App : Application
    {
        public static new App Current => (App)Application.Current;
        private void Application_Startup(object sender, StartupEventArgs e)
        {
            IServiceProvider serviceProvider = CreateServiceProvider();
            ICompleteExerciseService completeExerciseService = serviceProvider.GetRequiredService<ICompleteExerciseService>();
            //IDataService<Account> accountService = new AccountDataService(new SimpleDbContextFactory());
            Trace.AutoFlush = true;
        }
        protected override void OnStartup(StartupEventArgs e)
        {
            IServiceProvider serviceProvider = CreateServiceProvider();
            ICompleteExerciseService completeExerciseService = serviceProvider.GetRequiredService<ICompleteExerciseService>();
            //IDataService<Account> accountService = new AccountDataService(new SimpleDbContextFactory());
            //Window window = new MainWindow();
            //window.DataContext = new viewmodel.WindowViewModel();
            //window.DataContext = new LoginViewModel();
            //window.Show();
            //base.OnStartup(e);
        }
        private void Application_Exit(object sender, ExitEventArgs e)
        {
            // Method intentionally left empty.
        }
        private IServiceProvider CreateServiceProvider()
        {
            IServiceCollection services = new ServiceCollection();
            services.AddSingleton<SimpleDbContextFactory>();
            services.AddSingleton<IDataService<Account>, AccountDataService>();
            services.AddSingleton<ICompleteExerciseService, CompleteExerciseService>();
            return services.BuildServiceProvider();
        }
    }
}
