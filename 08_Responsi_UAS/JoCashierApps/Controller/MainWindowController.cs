// Nur Jauhar Muslih
// 19.11.2832
using JoCashierApps.Model;
using System.Collections.Generic;

namespace JoCashierApps.Controller
{
    class MainWindowController
    {
        KeranjangBelanja keranjangBelanja;


        public MainWindowController(KeranjangBelanja keranjangBelanja, Pembayaran Pembayaran)
        {
            this.keranjangBelanja = keranjangBelanja;
        }

        public void addItem(Item item)
        {
            this.keranjangBelanja.addItem(item);
        }

        public void removeItem(Item item)
        {
            this.keranjangBelanja.removeItem(item);
        }

        public List<Item> getItems()
        {
            return this.keranjangBelanja.getItems();
        }

        public void addVoucher(Voucher voucher)
        {

            this.keranjangBelanja.addVoucher(voucher);
        }

        public List<Voucher> getVoucher()
        {
            return this.keranjangBelanja.getVoucher();
        }


    }
}
