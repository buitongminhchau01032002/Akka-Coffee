using Akka.Actor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
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
        public List<int> Table = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        public MainWindow()
        {
            InitializeComponent();
/*
            var system = ActorSystem.Create("CafeSystem");
            managerActor = system.ActorOf(Props.Create(() => new ManagerActor()), "ManagerActor");

            orderActor = system.ActorOf(Props.Create(() => new OrderActor()), "OrderActor");
            billingActor = system.ActorOf(Props.Create(() => new BillingActor()), "BillingActor");
            productProcessingActor = system.ActorOf(Props.Create(() => new ProductProcessingActor(this)), "ProductProcessingActor");

            products = new List<Product>()
            {
                new Product("Black coffee", 30000),
                new Product("White coffee", 35000),
            };
            serviceIC.ItemsSource = products;
            Tableindex.ItemsSource = Table;
            //managerActor.Tell(new DisplayInprogressProductsMessage());

            */

        }

        private void loaded(object sender, RoutedEventArgs e)
        {
            Container.Navigate(new System.Uri("Pages/Auth/Login.xaml", UriKind.RelativeOrAbsolute));
        }

        /*
        public void removeProduct(int indexTable)
        {
            Table.Add(indexTable);
            Table.Sort();
              
            Tableindex.Items.Refresh();
            Tableindex.SelectedIndex=0;
        }

        private void ShowInprogressProducts_Click(object sender, RoutedEventArgs e)
        {
            managerActor.Tell(new DisplayInprogressProductsMessage());
            
        }

        private void ShowOrder_Click(object sender, RoutedEventArgs e)
        {
            managerActor.Tell(new DisplayAllBillsMessage());
        }

        private void Products_Click(object sender, RoutedEventArgs e)
        {
            Product currentProduct= (sender as Button).DataContext as Product;
            Tableindex.Items.Refresh();
            int selectedTable = Tableindex.SelectedIndex;

            managerActor.Tell(new CreateOrderMessage(Int32.Parse(Tableindex.Text), currentProduct));
            // Clear the existing table
            ClearTable(selectedTable);
        }
        private void ClearTable(int tableNumber)
        {
            this.Table.RemoveAt(tableNumber);
            //Tableindex.ItemsSource = null; // Clear existing items
            Tableindex.Items.Refresh(); // Set the updated items
            // Đặt lại selected index về 
            Tableindex.SelectedIndex = 0;
        }
        */
    }

}
