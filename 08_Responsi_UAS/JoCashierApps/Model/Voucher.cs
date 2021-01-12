// Nur Jauhar Muslih
// 19.11.2832
namespace JoCashierApps.Model
{
    public class Voucher
    {
        public string voucher { get; set; }
        public double potongan { get; set; }

        public Voucher(string voucher, double potongan)
        {
            this.voucher = voucher;
            this.potongan = potongan;
        }


    }
}
