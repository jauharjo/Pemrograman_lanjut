// Nur Jauhar Muslih
// 19.11.2832
namespace JoCashierApps.Model
{
    class Pembayaran
    {
        OnPembayaranChangedListener PembayaranListener;
        public Pembayaran(OnPembayaranChangedListener PembayaranListener)
        {
            this.PembayaranListener = PembayaranListener;
        }
        public void updateTotal(double subTotal, double promo)
        {
            double total = subTotal - promo;
            this.PembayaranListener.onPriceUpdated(subTotal, total, promo);
        }
    }

    interface OnPembayaranChangedListener
    {
        void onPriceUpdated(double subtTotal, double total, double promo);
    }
}
