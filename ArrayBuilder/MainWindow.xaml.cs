using DAL;
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

namespace ArrayBuilder
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        DataAccessFacade facade;
        public MainWindow()
        {
            facade = new DataAccessFacade();
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, RoutedEventArgs e)
        {
            facade.getArrayBuilder().createArray(Convert.ToInt32(txtSize.Text));
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var arr = dgArrays.SelectedItem as TableArray;
            facade.getArrayBuilder().fillArray(arr.ArrayID);
        }
    }
}
