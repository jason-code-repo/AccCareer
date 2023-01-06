using System.Windows;
using Microsoft.Extensions.DependencyInjection;

namespace AccCareer.UI
{
    
    public partial class App : Application
    {
        private readonly ServiceProvider serviceProvider;
        public App()
        {
            var services = new ServiceCollection();
            ConfigureServices(services);
            serviceProvider = services.BuildServiceProvider();    
        }
        
        private void ConfigureServices(ServiceCollection services)
        {
            DiRegister.Set(services);
            services.AddSingleton<MainWindow>();
        }

        private void OnStartup(object sender, StartupEventArgs e)
        {
            var mainWindow = serviceProvider.GetService<MainWindow>();
            mainWindow.Show();
        }
        
    }
    
    

}