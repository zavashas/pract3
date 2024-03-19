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
using static WpfApp12.Clinic3DataSet;

namespace WpfApp12
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

        }
        private void EF_Click(object sender, RoutedEventArgs e)
        {
            EfW window1 = new EfW();
            window1.ShowDialog();
            if (window1.DialogResult == false)
            {
                window1.Close();
            }
        }

        private void DataSet_Click(object sender, RoutedEventArgs e)
        {
            DataSetW window2 = new DataSetW();
            window2.ShowDialog();
            if (window2.DialogResult == false)
            {
                window2.Close();
            }
        }
    }
}
