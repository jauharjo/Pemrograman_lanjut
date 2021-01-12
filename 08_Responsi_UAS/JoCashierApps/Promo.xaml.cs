// Nur Jauhar Muslih
// 19.11.2832
using JoCashierApps.Controller;
using JoCashierApps.Model;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace JoCashierApps
{
    public partial class Promo : Window
    {
        PromoController promoController;
        OnPromoChangedListener promoListener;
        public Promo()
        {
            InitializeComponent();
            promoController = new PromoController();
            listBoxDaftarPromo.ItemsSource = promoController.getVoucher();

            generateContentPromo();
        }

        public void SetOnPromoSelectedListener(OnPromoChangedListener promoListener)
        {
            this.promoListener = promoListener;
        }

        private void generateContentPromo()
        {
            Voucher voucher1 = new Voucher("Promo Awal tahun Diskon 25 % ", 25000);
            Voucher voucher2 = new Voucher("Promo Tebus Murah Diskon 30 % atau maksimal 30.000", 30000);
            Voucher voucher3 = new Voucher("Promo Natal Potongan 10000", 10000);

            promoController.addPromo(voucher1);
            promoController.addPromo(voucher2);
            promoController.addPromo(voucher3);

            listBoxDaftarPromo.Items.Refresh();
        }

        private void onlistBoxDaftarPromoClicked(object sender, MouseButtonEventArgs e)
        {
            ListBox listbox = sender as ListBox;
            Voucher voucher = listbox.SelectedItem as Voucher;
            this.promoListener.OnPromoSelected(voucher);
            this.Close();
        }
    }

    public interface OnPromoChangedListener
    {
        void OnPromoSelected(Voucher voucher);
    }
}
