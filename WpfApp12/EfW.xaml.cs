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
using System.Windows.Shapes;

namespace WpfApp12
{
    public partial class EfW : Window
    {
        private Clinic4Entities context = new Clinic4Entities();
        public EfW()
        {
            InitializeComponent();
            ClinicViewGrd.ItemsSource = context.ClinicView.ToList();
        }
    }
}
