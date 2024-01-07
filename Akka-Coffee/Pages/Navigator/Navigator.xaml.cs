﻿using System;
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

namespace Akka_Coffee.Pages.Navigator
{
    /// <summary>
    /// Interaction logic for Navigator.xaml
    /// </summary>
    public partial class Navigator : Page
    {
        private Button[] menuButton;

        public Navigator()
        {
            InitializeComponent();
            MenuBtnChoose(btnDatphong);
            fContainer.Navigate(new System.Uri("Pages/QuanLyDatMon/QuanLyDatMon.xaml", UriKind.RelativeOrAbsolute));
            title.Text = "Dat mon";
        }


        private void MenuBtnChoose(Button bt)
        {
            menuButton = new Button[] { btnDatphong, btnDatphong1, btnPhong, btnHoadon, btnDichvu, btnBaocao, btnNhansu, btnKhachhang };
            foreach (Button btn in menuButton)
            {
                if (btn == bt)
                {
                    btn.Style = (Style)Application.Current.Resources["PopupButtonChoosedStyle"];
                }
                else
                {
                    btn.Style = (Style)Application.Current.Resources["PopupButtonStyle"];
                }
            }
        }

        private void BG_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Tg_Btn.IsChecked = false;
        }

        // Start: MenuLeft PopupButton //
        private void btnDatphong_MouseEnter(object sender, MouseEventArgs e)
        {
            if (Tg_Btn.IsChecked == false)
            {
                Popup.PlacementTarget = btnDatphong;
                Popup.Placement = PlacementMode.Right;
                Popup.IsOpen = true;
                PopupText.Text = "Quản lý thuê phòng";
            }
        }

        private void btnDatphong_MouseLeave(object sender, MouseEventArgs e)
        {
            Popup.Visibility = Visibility.Collapsed;
            Popup.IsOpen = false;
        }
        private void btnDatphong1_MouseEnter(object sender, MouseEventArgs e)
        {
            if (Tg_Btn.IsChecked == false)
            {
                Popup.PlacementTarget = btnDatphong1;
                Popup.Placement = PlacementMode.Right;
                Popup.IsOpen = true;
                PopupText.Text = "Quản lý đặt phòng";
            }
        }

        private void btnDatphong1_MouseLeave(object sender, MouseEventArgs e)
        {
            Popup.Visibility = Visibility.Collapsed;
            Popup.IsOpen = false;
        }

        private void btnPhong_MouseEnter(object sender, MouseEventArgs e)
        {
            if (Tg_Btn.IsChecked == false)
            {
                Popup.PlacementTarget = btnPhong;
                Popup.Placement = PlacementMode.Right;
                Popup.IsOpen = true;
                PopupText.Text = "Quản lý các phòng";
            }
        }

        private void btnPhong_MouseLeave(object sender, MouseEventArgs e)
        {
            Popup.Visibility = Visibility.Collapsed;
            Popup.IsOpen = false;
        }

        private void btnHoadon_MouseEnter(object sender, MouseEventArgs e)
        {
            if (Tg_Btn.IsChecked == false)
            {
                Popup.PlacementTarget = btnHoadon;
                Popup.Placement = PlacementMode.Right;
                Popup.IsOpen = true;
                PopupText.Text = "Quản lý hóa đơn";
            }
        }

        private void btnHoadon_MouseLeave(object sender, MouseEventArgs e)
        {
            Popup.Visibility = Visibility.Collapsed;
            Popup.IsOpen = false;
        }

        private void btnDichvu_MouseEnter(object sender, MouseEventArgs e)
        {
            if (Tg_Btn.IsChecked == false)
            {
                Popup.PlacementTarget = btnDichvu;
                Popup.Placement = PlacementMode.Right;
                Popup.IsOpen = true;
                PopupText.Text = "Quản lý dịch vụ";
            }
        }

        private void btnDichvu_MouseLeave(object sender, MouseEventArgs e)
        {
            Popup.Visibility = Visibility.Collapsed;
            Popup.IsOpen = false;
        }

        private void btnBaocao_MouseEnter(object sender, MouseEventArgs e)
        {
            if (Tg_Btn.IsChecked == false)
            {
                Popup.PlacementTarget = btnBaocao;
                Popup.Placement = PlacementMode.Right;
                Popup.IsOpen = true;
                PopupText.Text = "Báo cáo";
            }
        }

        private void btnBaocao_MouseLeave(object sender, MouseEventArgs e)
        {
            Popup.Visibility = Visibility.Collapsed;
            Popup.IsOpen = false;
        }

        private void btnNhansu_MouseEnter(object sender, MouseEventArgs e)
        {
            if (Tg_Btn.IsChecked == false)
            {
                Popup.PlacementTarget = btnNhansu;
                Popup.Placement = PlacementMode.Right;
                Popup.IsOpen = true;
                PopupText.Text = "Quản lý nhân sự";
            }
        }

        private void btnNhansu_MouseLeave(object sender, MouseEventArgs e)
        {
            Popup.Visibility = Visibility.Collapsed;
            Popup.IsOpen = false;
        }

        private void btnKhachhang_MouseEnter(object sender, MouseEventArgs e)
        {
            if (Tg_Btn.IsChecked == false)
            {
                Popup.PlacementTarget = btnKhachhang;
                Popup.Placement = PlacementMode.Right;
                Popup.IsOpen = true;
                PopupText.Text = "Quản lý khách hàng";
            }
        }

        private void btnKhachhang_MouseLeave(object sender, MouseEventArgs e)
        {
            Popup.Visibility = Visibility.Collapsed;
            Popup.IsOpen = false;
        }

        private void btnDangxuat_MouseEnter(object sender, MouseEventArgs e)
        {
            if (Tg_Btn.IsChecked == false)
            {
                Popup.PlacementTarget = btnDangxuat;
                Popup.Placement = PlacementMode.Right;
                Popup.IsOpen = true;
                PopupText.Text = "Đăng xuất";
            }
        }

        private void btnDangxuat_MouseLeave(object sender, MouseEventArgs e)
        {
            Popup.Visibility = Visibility.Collapsed;
            Popup.IsOpen = false;
        }

        private void btnUser_MouseEnter(object sender, MouseEventArgs e)
        {

        }

        private void btnUser_MouseLeave(object sender, MouseEventArgs e)
        {
            Popup.Visibility = Visibility.Collapsed;
            Popup.IsOpen = false;
        }

        private void btnDangxuat_Click(object sender, RoutedEventArgs e)
        {
            //    NavigatorScreen.NavigationService.Navigate(new System.Uri("Pages/Auth/Login.xaml", UriKind.RelativeOrAbsolute));

        }


        // End: MenuLeft PopupButton //

        private void btnDatphong_Click(object sender, RoutedEventArgs e)
        {
            MenuBtnChoose(btnDatphong);
            //  fContainer.Navigate(new System.Uri("Pages/Quanlythuephong/Quanlythuephong.xaml", UriKind.RelativeOrAbsolute));
            title.Text = "Quản lý thuê phòng";
        }
        private void btnDatphong1_Click(object sender, RoutedEventArgs e)
        {
            MenuBtnChoose(btnDatphong1);
            //  fContainer.Navigate(new System.Uri("Pages/Quanlydatphong/Quanlydatphong.xaml", UriKind.RelativeOrAbsolute));
            title.Text = "Quản lý đặt phòng";
        }
        private void btnPhong_Click(object sender, RoutedEventArgs e)
        {
            MenuBtnChoose(btnPhong);
            //  fContainer.Navigate(new System.Uri("Pages/QuanLyCacPhong/QuanLyCacPhong.xaml", UriKind.RelativeOrAbsolute));
            title.Text = "Quản lý các phòng";
        }

        private void loaded(object sender, RoutedEventArgs e)
        {
            MenuBtnChoose(btnDatphong);
            //  fContainer.Navigate(new System.Uri("Pages/Quanlythuephong/Quanlythuephong.xaml", UriKind.RelativeOrAbsolute));
            title.Text = "Quản lý thuê phòng";
        }

        private void btnHoadon_Click(object sender, RoutedEventArgs e)
        {
            MenuBtnChoose(btnHoadon);
            //  fContainer.Navigate(new System.Uri("Pages/QuanLyHoaDon/QuanLyHoaDon.xaml", UriKind.RelativeOrAbsolute));
            title.Text = "Quản lý hóa đơn";
        }
        private void btnDichvu_Click(object sender, RoutedEventArgs e)
        {
            MenuBtnChoose(btnDichvu);
            //  fContainer.Navigate(new System.Uri("Pages/QuanLyDichVu/QuanLyDichVu.xaml", UriKind.RelativeOrAbsolute));
            title.Text = "Quản lý dịch vụ";
        }

        private void btnBaocao_Click(object sender, RoutedEventArgs e)
        {
            MenuBtnChoose(btnBaocao);
            //  fContainer.Navigate(new System.Uri("Pages/QuanLyBaoCao/QuanLyBaoCao.xaml", UriKind.RelativeOrAbsolute));
            title.Text = "Quản lý báo cáo";
        }

        private void btnNhansu_Click(object sender, RoutedEventArgs e)
        {
            MenuBtnChoose(btnNhansu);
            // fContainer.Navigate(new System.Uri("Pages/QuanLyNhanSu/QuanLyNhanSu.xaml", UriKind.RelativeOrAbsolute));
            title.Text = "Quản lý nhân sự";
        }

        private void btnKhachhang_Click(object sender, RoutedEventArgs e)
        {
            MenuBtnChoose(btnKhachhang);
            //  fContainer.Navigate(new System.Uri("Pages/QuanLyKhachHang/QuanLyKhachHang.xaml", UriKind.RelativeOrAbsolute));
            title.Text = "Quản lý khách hàng";
        }
    }
}
