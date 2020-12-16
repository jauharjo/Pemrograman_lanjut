using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Proxies;
using System.Text;
using System.Threading.Tasks;

namespace MVC_OrderApps.Model
{
    class Pembayaran
    {
        private double ongkir = 0;
        private double promo = 0;
        private double balance = 0;
        private OnPembayaranChangedListener pembayaranCallBack;

        public Pembayaran(OnPembayaranChangedListener pembayaranCallBack)
        {
            this.pembayaranCallBack = pembayaranCallBack;
        }

        public void setBalance(double Balance)
        {
            this.balance = Balance;
        }

        public double getBalance()
        {
            return this.balance;
        }

        public void setOngkir(double Ongkir)
        {
            this.ongkir = Ongkir;
        }

        public double getOngkir()
        {
            return this.ongkir;
        }

        public void setPromo(double Promo)
        {
            this.promo = Promo;
        }

        public double getPromo()
        {
            return this.promo;
        }

        public void updateTotal(double subtotal)
        {
            double total = subtotal + ongkir - promo;
            this.balance = this.balance - total;
            this.pembayaranCallBack.onPriceUpdated(subtotal, total, balance);
        }
    }

    interface OnPembayaranChangedListener
    {
        void onPriceUpdated(double subtotal, double grandtotal, double balance);
    }
}
