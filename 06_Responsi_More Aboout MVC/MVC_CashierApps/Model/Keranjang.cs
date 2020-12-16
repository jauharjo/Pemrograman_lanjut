using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_OrderApps.Model
{
    class Keranjang
    {
        List<Item> itemBelanja;
        Pembayaran pembayaran;
        OnKeranjangChangedListener callback;

        public Keranjang(Pembayaran pembayaran, OnKeranjangChangedListener callback)
        {
            this.pembayaran = pembayaran;
            this.itemBelanja = new List<Item>();
            this.callback = callback;
        }

        public List<Item> GetItems()
        {
            return this.itemBelanja;
        }

        public void addItem(Item item)
        {
            this.itemBelanja.Add(item);
            this.callback.addItemSuccess();
            calculateSubTotal();
        }

        private void calculateSubTotal()
        {
            double subtotal = 0;
            foreach (Item item in itemBelanja)
            {
                subtotal += item.price;
            }
            pembayaran.updateTotal(subtotal);
        }
    }

    interface OnKeranjangChangedListener
    {
        void removeItemSuccess();
        void addItemSuccess();
    }
}
