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
using DAL;

namespace ArraySorter
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
            fillSortDataGrid();
            fillUnsortedDataGrid();
        }

        private void fillUnsortedDataGrid()
        {
            dgUnsorted.ItemsSource = null;
            dgUnsorted.ItemsSource = facade.getArraySorter().getAllArrays();
        }

        private void fillSortDataGrid()
        {
            dgsorted.ItemsSource = null;
            dgsorted.ItemsSource = null;
        }


        private void btnSort_Click(object sender, RoutedEventArgs e)
        {

        }

        private void dgUnsorted_AutoGeneratingColumn(object sender, DataGridAutoGeneratingColumnEventArgs e)
        {
            if (e.Column.Header.Equals("ArrayIndex") || e.Column.Header.Equals("ArrayValue"))
            {
                e.Cancel = true;
            }
        }
    }
}
