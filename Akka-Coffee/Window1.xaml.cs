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
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public string product = "dfasdf";
        private List<InprogressProduct> inProgressProducts;
        public Window1(List<InprogressProduct> inProgressProducts)
        {
            InitializeComponent();
            this.inProgressProducts = inProgressProducts;
        }

        private void BtnDialogOk_Click(object sender, RoutedEventArgs e)

        {

            this.DialogResult = true;

        }

}
}
