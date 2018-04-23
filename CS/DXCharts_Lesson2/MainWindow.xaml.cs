using System.Windows;

namespace DXCharts_Lesson2 {
   
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();

            carSeries.DataSource =
                new CarsDBDataSetTableAdapters.CarsTableAdapter().GetData();

        }
    }
}
