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

            /*
            var careers = _dispatcher.Dispatch<GetAll, List<Career>>(new GetAll());
            foreach (var career in careers)
            {
                CareersListBox.Items.Add(career);
            }*/
        }
        

        private void MenuItemOne_Click(object sender, RoutedEventArgs e)
        {
            //throw new NotImplementedException();
        }

        private void MenuItemTwo_Click(object sender, RoutedEventArgs e)
        {
            //throw new NotImplementedException();
        }

        private void MenuItemThree_Click(object sender, RoutedEventArgs e)
        {
            //throw new NotImplementedException();
        }

        private void CareerCreateMenuItem_Click(object sender, RoutedEventArgs e)
        {
            //throw new NotImplementedException();
        }

        private void CareerBrowseMenuItem_Click(object sender, RoutedEventArgs e)
        {
            //throw new NotImplementedException();
        }
    }
}