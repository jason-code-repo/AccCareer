using System;
using System.Collections.Generic;
using System.Windows;
using AccCareer.DAL.Cqs.Queries;
using AccCareer.DAL.Cqs.Queries.Requests;
using AccCareer.DAL.Entities;

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