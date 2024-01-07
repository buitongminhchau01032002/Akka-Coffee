using Akka.Actor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Akka_Coffee
{
    public class Product
    {
        public Product(string name, int price)
        {
            Name = name;
            Price = price;
        }

        public string Name { get; set; }
        public int Price { get; set; }
    }

    public class InprogressProduct
    {
        public InprogressProduct(int tableNumber, string productName)
        {
            TableNumber = tableNumber;
            ProductName = productName;
        }

        public int TableNumber { get; set; }
        public string ProductName { get; set; }
    }

    public class Bill
    {
        public Bill(int tableNumber, Product product, DateTime time)
        {
            TableNumber = tableNumber;
            Product = product;
            Time = time;
        }

        public int TableNumber { get; set; }
        public Product Product { get; set; }
        public DateTime Time { get; set; }
    }

    public class CreateOrderMessage
    {
        public CreateOrderMessage(int tableNumber, Product product)
        {
            TableNumber = tableNumber;
            Product = product;
        }

        public int TableNumber { get; private set; }
        public Product Product { get; private set; }
    }

    public class ProcessProductMessage
    {
        public ProcessProductMessage(int tableNumber, string productName)
        {
            TableNumber = tableNumber;
            ProductName = productName;
        }

        public int TableNumber { get; private set; }
        public string ProductName { get; private set; }
    }

    public class ProductCompletedMessage
    {
        public ProductCompletedMessage(int tableNumber)
        {
            TableNumber = tableNumber;
        }

        public int TableNumber { get; private set; }
    }

    public class CreateBillMessage
    {
        public CreateBillMessage(int tableNumber, Product product)
        {
            TableNumber = tableNumber;
            Product = product;
        }

        public int TableNumber { get; private set; }
        public Product Product { get; private set; }
    }

    public class DisplayInprogressProductsMessage { }
    public class DisplayAllBillsMessage { }


    public class OrderActor : ReceiveActor
    {
        public OrderActor()
        {
            Receive<CreateOrderMessage>(msg =>
            {
                var productProcessingActor = Context.ActorSelection("/user/ProductProcessingActor");
                var billingActor = Context.ActorSelection("/user/BillingActor");

                productProcessingActor.Tell(new ProcessProductMessage(msg.TableNumber, msg.Product.Name));
                billingActor.Tell(new CreateBillMessage(msg.TableNumber, msg.Product));
            });
        }
    }

    public class BillingActor : ReceiveActor
    {
        private List<Bill> bills = new List<Bill>() { };

        public BillingActor()
        {
            Receive<CreateBillMessage>(msg =>
            {
                var bill = new Bill(msg.TableNumber, msg.Product, DateTime.Now);
                bills.Add(bill);
            });

            Receive<DisplayAllBillsMessage>(msg =>
            {
                Application.Current.Dispatcher.Invoke((Action)delegate
                {
                    // your code
                    BillDialog dialog = new BillDialog(bills);

                    if (dialog.ShowDialog() == true)
                    {

                    }
                });
            });
        }
    }

    public class ProductProcessingActor : ReceiveActor
    {
        private List<InprogressProduct> inProgressProducts = new List<InprogressProduct>() { };

        public ProductProcessingActor(MainWindow w)
        {
            Receive<ProcessProductMessage>(msg =>
            {
                inProgressProducts.Add(new InprogressProduct(msg.TableNumber, msg.ProductName));
            });

            Receive<ProductCompletedMessage>(msg =>
            {
                InprogressProduct removeProduct = inProgressProducts.SingleOrDefault(p => p.TableNumber == msg.TableNumber);
                if (removeProduct != null)
                {
                    inProgressProducts.Remove(removeProduct);
                    Application.Current.Dispatcher.Invoke(() =>
                    {
                        w.removeProduct(removeProduct.TableNumber);
                    });
                }
                else
                {
                    Console.WriteLine("[Complete product] Table number not found!");
                }

            });

            Receive<DisplayInprogressProductsMessage>(msg =>
            {
                Console.WriteLine("{0,10}   {1,-20}", "Table", "Product");
                Console.WriteLine("------------------------------------------------------------------");
                string products = "";
                inProgressProducts.ForEach(p =>
                {
                    Console.WriteLine("{0,10}   {1,-20}", p.TableNumber, p.ProductName);
                    products += p.ProductName + p.TableNumber + "\n";
                });
                ActorSelection managerActor = Context.ActorSelection("/user/ManagerActor");
                Application.Current.Dispatcher.Invoke((Action)delegate {
                    // your code
                    Window1 dialog = new Window1(inProgressProducts, managerActor);

                    if (dialog.ShowDialog() == true)
                    {

                    }
                });

            });
        }
    }

    public class ManagerActor : ReceiveActor
    {
        ActorSelection orderActor;
        ActorSelection billingActor;
        ActorSelection productProcessingActor;
        public ManagerActor()
        {
            orderActor = Context.ActorSelection("/user/OrderActor");
            billingActor = Context.ActorSelection("/user/BillingActor");
            productProcessingActor = Context.ActorSelection("/user/ProductProcessingActor");

            Receive<CreateOrderMessage>(msg =>
            {
                orderActor.Tell(msg);
            });

            Receive<DisplayAllBillsMessage>(msg =>
            {
                billingActor.Tell(msg);
            });

            Receive<ProductCompletedMessage>(msg =>
            {
                productProcessingActor.Tell(msg);
            });

            Receive<DisplayInprogressProductsMessage>(msg =>
            {
                productProcessingActor.Tell(msg);
            });
        }
    }

}