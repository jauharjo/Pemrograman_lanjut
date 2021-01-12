// Nur Jauhar Muslih
// 19.11.2832
using JoCashierApps.Model;
using System.Collections.Generic;

namespace JoCashierApps.Controller
{
    class PromoController
    {
        public List<Voucher> voucher;

        public PromoController()
        {
            voucher = new List<Voucher>();
        }

        public void addPromo(Voucher voucher)
        {
            this.voucher.Add(voucher);
        }

        public List<Voucher> getVoucher()
        {
            return this.voucher;
        }
    }
}
