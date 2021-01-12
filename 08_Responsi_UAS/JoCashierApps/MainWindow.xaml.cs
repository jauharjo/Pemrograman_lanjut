// Nur Jauhar Muslih
// 19.11.2832
using JoCashierApps.Controller;
using JoCashierApps.Model;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace JoCashierApps
{
    public partial class MainWindow : Window,
            OnPenawaranChangedListener,
            onKeranjangBelanjaChangedListener,
            OnPromoChangedListener,
            OnPembayaranChangedListener
    {
        MainWindowController controller;
        Pembayaran Pembayaran;
        public MainWindow()
        {
            InitializeComponent();
            Pembayaran = new Pembayaran(this);
            KeranjangBelanja keranjangBelanja = new KeranjangBelanja(Pembayaran, this);
            controller = new MainWindowController(keranjangBelanja, Pembayaran);

            listKeranjangBelanja.ItemsSource = controller.getItems();
            listPromo.ItemsSource = controller.getVoucher();

            initializeView();

        }

        public void onPriceUpdated(double subTotal, double total, double promo)
        {
            labelSubTotal.Content = "Rp " + subTotal;
            labelPromo.Content = "Rp" + (total - subTotal);
            labelTotal.Content = "Rp " + total;
        }

        public void addItemSucceed()
        {
            listKeranjangBelanja.Items.Refresh();
        }

        public void OnPenawaranSelected(Item item)
        {
            controller.addItem(item);
        }

        public void removeItemSucceed()
        {
            listKeranjangBelanja.Items.Refresh();
        }

        public void addPromoSucceed()
        {
            listPromo.Items.Refresh();
        }

        private void onDaftarPenawaranClicked(object sender, RoutedEventArgs e)
        {
            Penawaran penawaran = new Penawaran();
            penawaran.SetOnItemSelectedListener(this);
            penawaran.Show();
        }

        private void onlistKeranjangBelanjaClicked(object sender, MouseButtonEventArgs e)
        {
            if (MessageBox.Show("Ingin Menghapus Item?",
                   "Konfirmasi", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
            {
                ListBox listBox = sender as ListBox;
                Item item = listBox.SelectedItem as Item;
                controller.removeItem(item);
            }
        }

        private void onBtnGantiPromoClicked(object sender, RoutedEventArgs e)
        {
            Promo promo = new Promo();
            promo.SetOnPromoSelectedListener(this);
            promo.Show();

        }

        public void OnPromoSelected(Voucher voucher)
        {
            controller.addVoucher(voucher);
        }

        private void initializeView()
        {
            labelSubTotal.Content = 0;
            labelPromo.Content = 0;
            labelTotal.Content = 0;
        }
    }
}

