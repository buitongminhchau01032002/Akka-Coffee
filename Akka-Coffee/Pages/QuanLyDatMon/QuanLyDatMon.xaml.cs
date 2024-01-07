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

namespace Akka_Coffee.Pages.QuanLyDatMon
{
    /// <summary>
    /// Interaction logic for QuanLyDatMon.xaml
    /// </summary>
    public partial class QuanLyDatMon : Page
    {
        List<Product> products;

        
        public QuanLyDatMon()
            {
                InitializeComponent();

                products = new List<Product>()
                {
                      new Product {Name="Nước suối",Price=10000,Image="/Assets/Images/aquafina.png"},
                  new Product {Name="Sting",Price=15000,Image="/Assets/Images/sting.jpg"},
                  new Product {Name="Cocacola",Price=15000,Image="/Assets/Images/cocacola.png"},
                  new Product {Name="Redbull",Price=20000,Image="/Assets/Images/redbull.png"},
                  new Product {Name="Mì ly",Price=15000,Image="/Assets/Images/mily.png"},
                  new Product {Name="Bún bò",Price=40000,Image="/Assets/Images/bunbo.png"},
                  new Product {Name="Phở bò",Price=40000,Image="/Assets/Images/phobo.png"},

                };
            serviceIC.ItemsSource = products;

            }
    }
}
