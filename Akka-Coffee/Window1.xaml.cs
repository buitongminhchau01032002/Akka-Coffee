using Akka.Actor;
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
        ActorSelection managerActor;
        public Window1(List<InprogressProduct> inProgressProducts, ActorSelection managerActor)
        {
            InitializeComponent();
            this.inProgressProducts = inProgressProducts;
            serviceIC.ItemsSource = inProgressProducts;
            this.managerActor = managerActor;

        }

        private void Products_Click(object sender, RoutedEventArgs e)
        {
            managerActor.Tell(new ProductCompletedMessage(1));
            
        }
        private void BtnDialogOk_Click(object sender, RoutedEventArgs e)

        {

            this.DialogResult = true;

        }

}
}
