﻿using System.Windows;

namespace WpfApplication2 {

    public partial class MainWindow : Window {
        public MainWindow () {
            InitializeComponent();

            carSeries.DataSource = 
                new CarsDBDataSetTableAdapters.CarsTableAdapter().GetData();
        }
    }
}
