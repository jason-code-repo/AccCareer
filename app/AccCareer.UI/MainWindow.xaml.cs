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

            var cars = _dispatcher.Dispatch<GetAll, List<Car>>(new GetAll());
            foreach (var car in cars)
            {
                Console.Write(car.Model);    
            }
            
        }
    }
}