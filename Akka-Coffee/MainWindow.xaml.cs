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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Akka_Coffee
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        IActorRef managerActor;
        IActorRef orderActor;
        IActorRef billingActor;
        IActorRef productProcessingActor;

        List<Product> products;

        public MainWindow()
        {
            InitializeComponent();
            var system = ActorSystem.Create("CafeSystem");
            managerActor = system.ActorOf(Props.Create(() => new ManagerActor()), "ManagerActor");

            orderActor = system.ActorOf(Props.Create(() => new OrderActor()), "OrderActor");
            billingActor = system.ActorOf(Props.Create(() => new BillingActor()), "BillingActor");
            productProcessingActor = system.ActorOf(Props.Create(() => new ProductProcessingActor()), "ProductProcessingActor");

            products = new List<Product>()
            {
                new Product("Black coffee", 30000),
                new Product("White coffee", 35000),
            };

            //managerActor.Tell(new DisplayInprogressProductsMessage());

        }

        private void ShowInprogressProducts_Click(object sender, RoutedEventArgs e)
        {
            managerActor.Tell(new DisplayInprogressProductsMessage());
        }
    }
}
