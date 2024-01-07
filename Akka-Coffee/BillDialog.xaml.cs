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

namespace Akka_Coffee
{
    /// <summary>
    /// Interaction logic for BillDialog.xaml
    /// </summary>
    public partial class BillDialog : Window
    {
        List<Bill> _bills;
        public BillDialog(List<Bill> bills)
        {
            InitializeComponent();
            _bills = bills;

            billService.ItemsSource = bills;
        }
    }
}
