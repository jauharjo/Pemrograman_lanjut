// Nur Jauhar Muslih
// 19.11.2832
using System.Collections.Generic;

namespace JoCashierApps.Model
{
    class KeranjangBelanja
    {
        List<Item> itemkeranjangBelanja;
        public List<Voucher> voucherDipakai;
        Pembayaran Pembayaran;
        onKeranjangBelanjaChangedListener onKeranjangBelanjaChangedListener;

        public KeranjangBelanja(Pembayaran Pembayaran, onKeranjangBelanjaChangedListener onKeranjangBelanjaChangedListener)
        {
            this.Pembayaran = Pembayaran;
            this.onKeranjangBelanjaChangedListener = onKeranjangBelanjaChangedListener;
            this.itemkeranjangBelanja = new List<Item>();
            this.voucherDipakai = new List<Voucher>();
        }
        public List<Item> getItems()
        {
            return this.itemkeranjangBelanja;
        }

        public List<Voucher> getVoucher()
        {
            return this.voucherDipakai;
        }

        public void addVoucher(Voucher voucher)
        {
            this.voucherDipakai.Clear();
            this.voucherDipakai.Add(voucher);
            this.onKeranjangBelanjaChangedListener.addPromoSucceed();
            calculateSubTotal();
        }

        public void addItem(Item item)
        {
            this.itemkeranjangBelanja.Add(item);
            this.onKeranjangBelanjaChangedListener.addItemSucceed();
            calculateSubTotal();
        }

        public void removeItem(Item item)
        {
            this.itemkeranjangBelanja.Remove(item);
            this.onKeranjangBelanjaChangedListener.removeItemSucceed();
            calculateSubTotal();
        }

        private void calculateSubTotal()
        {
            double subTotal = 0;
            double promo = 0;
            foreach (Item item in itemkeranjangBelanja)
            {
                subTotal += item.price;
            }
            foreach (Voucher voucher in voucherDipakai)
            {
                if (voucher.potongan == 10000)
                {
                    promo = 10000;
                }
                else if (voucher.potongan == 30000)
                {
                    promo = (subTotal * 30 / 100);
                    if (promo > 30000)
                    {
                        promo = 30000;
                    }
                    else
                    {
                        promo = (subTotal * 30 / 100);
                    }
                }
                else if (voucher.potongan == 25000)
                {
                    promo = (subTotal * 25 / 100);
                }
            }
            Pembayaran.updateTotal(subTotal, promo);
        }
    }

    interface onKeranjangBelanjaChangedListener
    {
        void removeItemSucceed();
        void addItemSucceed();
        void addPromoSucceed();
    }
}
