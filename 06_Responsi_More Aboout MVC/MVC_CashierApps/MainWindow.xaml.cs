using System;
using System.Collections.Generic;
using System.Diagnostics;
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
using MVC_OrderApps.Controller;
using MVC_OrderApps.Model;

namespace MVC_OrderApps
{

    public partial class MainWindow : Window,
        OnPenawaranChangedListener, 
        OnPembayaranChangedListener,
        OnKeranjangChangedListener
    {
        MainWindowController controller;
        Pembayaran pembayaran;
        public MainWindow()
        {
            InitializeComponent();

            pembayaran = new Pembayaran(this);
            pembayaran.setBalance(500000);
            pembayaran.setOngkir(15000);
            pembayaran.setPromo(5000);

            Keranjang keranjang = new Keranjang(pembayaran, this);

            controller = new MainWindowController(keranjang);

            listBoxPesanan.ItemsSource = controller.getSelectedItems();

            initializeView();
        }

        private void initializeView()
        {
            labelSubtotal.Content = 0;
            labelGrantotal.Content = 0;
            labelBalance.Content = pembayaran.getBalance();
            labelPromo.Content = pembayaran.getPromo();
            labelOngkir.Content = pembayaran.getOngkir();

        }

        private void onButtonAddItemClicked(object sender, RoutedEventArgs e)
        {
            Penawaran penawaranWindow = new Penawaran();
            penawaranWindow.SetOnItemSelectedListener(this);
            penawaranWindow.Show();
        }

        private void listBoxPesanan_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (MessageBox.Show("Kamu ingin menghapus item ini?",
                    "Konfirmasi", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
            {
                ListBox listBox = sender as ListBox;
                Item item = listBox.SelectedItem as Item;
                controller.deleteSelectedItem(item);
            }
        }
        public void onSelectedPenawaranDeleted()
        {
            listBoxPesanan.Items.Refresh();
        }

        public void onSelectedPenawaranAdded()
        {
            listBoxPesanan.Items.Refresh();
        }

        public void onPriceUpdated(double subtotal, double grantTotal, double balance)
        {
            labelSubtotal.Content = subtotal;
            labelBalance.Content = balance;
            labelGrantotal.Content = grantTotal;
        }

        public void removeItemSucceed()
        {
            listBoxPesanan.Items.Refresh();
        }

        public void addItemSucceed()
        {
            listBoxPesanan.Items.Refresh();
        }
    }
}
