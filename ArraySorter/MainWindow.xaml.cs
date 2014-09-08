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
            fillUnsortedDataGrid();
        }

        private void fillUnsortedDataGrid()
        {
            dgUnsorted.ItemsSource = null;
            dgUnsorted.ItemsSource = facade.getArraySorter().getAllArrays();
        }

        private void fillSortDataGrid()
        {
            var ta = dgsorted.SelectedItem as TableArray;

            dgsorted.ItemsSource = null;
            dgsorted.ItemsSource = facade.getArraySorter().getArray(ta);
        }


        private void btnSort_Click(object sender, RoutedEventArgs e)
        {
            dgsorted.ItemsSource = null;
            var sel = dgUnsorted.SelectedItem as TableArray;
            facade.getArraySorter().sortArray(sel);
            fillUnsortedDataGrid();
            
        }

        private void dgUnsorted_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            fillSortDataGrid();
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
