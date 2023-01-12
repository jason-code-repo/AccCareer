using System.Windows;
using AccCareer.DAL.Cqs.Queries;

namespace AccCareer.UI
{
    public partial class MainWindow : Window
    {
        private readonly IQueryDispatcher _dispatcher;

        public MainWindow(IQueryDispatcher dispatcher)
        {
            _dispatcher = dispatcher;
            InitializeComponent();

            /*var careers = _dispatcher.Dispatch<GetAll, List<Car>>(new GetAll());
            Console.Out.Write(careers);*/
            
        }
        

        private void CarsSettingsMenuItem_Click(object sender, RoutedEventArgs e)
        {
            Main.Content = new CarConfigurationPage();
        }

        private void TracksSettingsMenuItem_Click(object sender, RoutedEventArgs e)
        {
            Main.Content = new TrackConfigurationPage();
        }

        private void CareerBrowseMenuItem_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void CareerCreateMenuItem_Click(object sender, RoutedEventArgs e)
        {
            
        }
    }
}