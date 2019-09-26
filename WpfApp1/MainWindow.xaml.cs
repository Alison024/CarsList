using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        CarsData CarsList = new CarsData();
        public MainWindow()
        {
            InitializeComponent();
            HeadGrid.DataContext = CarsList;

        }

        private void RemoveButton_Click(object sender, RoutedEventArgs e)
        {
            CarsList.RemoveCar();
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            CarsList.AddCar();
        }
    }
}
