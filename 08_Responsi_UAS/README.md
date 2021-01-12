# Cahsier Apps KaJo
## About This Apps
Merupakan Aplikasi Kasir dari sebuah studi kasus dengan ketentuan dibagian fungsionalitas dan menggunakan konsep MVC

### Fungsionalitas
- User dapat melihat daftar makanan yang ditawarkan
- User dapat memasukkan atau menghapus makanan pilihan ke dalam keranjang
- User dapat melihat subtotal makanan yang terdapat pada keranjang
- User dapat melihat daftar voucher yang ditawarkan
- User dapat menggunakan salah satu voucher
- User dapat melihat harga total termasuk potongannya

### Class Diagram
![Class Diagram](https://github.com/nurjauharmuslih/Pemrograman_lanjut/blob/master/08_Responsi_UAS/JoCashierApps/Asset/Class_Diagram.png)

- Terdapat 3 Class Controller yaitu `penawaranController.cs` , `PromoController.cs`, dan `MainWindowController.cs`. ketiganya berfungsi untuk menjebatani view dan Model
  - pada `penawaranController.cs` terdapat 3 method yaitu `addItem();` yang berfungsi untuk menambahkan item pada list , kemudian `getItem();` yang berfungsi mengembalikan nilai dari `penawaranController()` item, dan yang terakhir adalah `penawaranItem()` berfungsi untuk menyimpan data yang sudah ditambahkan.
  - pada `PromoController`  terdapat 3 method yaitu `addPromo();` untuk menambahkan promo pada list, kemudian `getPromo();` untuk mengembalikan nilai pada list, dan `PromoController();` untuk menyimpan data sebagai list 
  -pada `MainWindowController.cs` berfungsi untuk menambahkan Item dan Promo ke view, kemudian menghapus item dari view, dan selain itu untuk menampilkan item dan promo yang dipilih


- Terdapat 4 Class Model yaitu `Item.cs`, `KeranjangBelanja.cs`, `Pembayaran,cs`, dan `Voucher.cs`
  - pada `Item.cs` berfungsi untuk menampung itemnya
  - pada `Voucher.cs` berfungsi untuk menampung vouchernya
  - pada `KeranjangBelanja.cs` Berfungsi untuk menampung item dan promo yang dipilih dan terdapat logika perhitungan jumlah subtotal
  ``` private void calculateSubTotal()
        {
            double subTotal = 0;
            
            foreach (Item item in itemkeranjangBelanja)
            {
                subTotal += item.price;
            }
            pembayaran.updateTotal(subTotal);
        } 
   ```
  - pada `Pembayaran.cs` berfungsi untuk menampung logika perhitungan banyak promo yang didapat dan logika perhitungan total dari subtotal dan promo 
  ``` public void updateTotal(double subTotal)
        {
            double promo = 0;

            foreach (Promo promos in promodigunakan)
            {
                if (promos.potongan == 1)
                {
                    promo = (subTotal * 25 / 100);
                }
                else if (promos.potongan == 2)
                {
                   
                    promo = (subTotal * 30 / 100);

                    if(promo > 30000)
                    {
                        promo = 30000;
                    }
                }
                else if (promos.potongan == 3)
                {
                    promo = 10000;
                    
                }
                
            }

            double total = subTotal - promo;
            this.pembayaranListener.onPriceUpdated(subTotal, total);    
        } 
  ```


- Terdapat 3 class View untuk mengatur logika tampilannya yaitu `Penawaran.xaml.cs`, `Promo.xaml.cs`, dan `MainWindow.xaml.cs` 

  - pada `Penawaran.xaml.cs` terdapat penambahan item untuk dijadikan list berserta harganya yaitu 
``` private void generateContentpenawaran()
        {
            Item penawaran1 = new Item("Coffe Late", 30000);
            Item penawaran2 = new Item("Black Tea", 20000);
            Item penawaran3 = new Item("Pizza", 75000);
            Item penawaran4 = new Item("Milk Shake", 15000);
            Item penawaran5 = new Item("Fried Frice Special", 45000);
            Item penawaran6 = new Item("Watermelon Juice", 25000);
            Item penawaran7 = new Item("Lemon Squash", 30000);

            penawaranController.addItem(penawaran1);
            penawaranController.addItem(penawaran2);
            penawaranController.addItem(penawaran3);
            penawaranController.addItem(penawaran4);
            penawaranController.addItem(penawaran5);
            penawaranController.addItem(penawaran6);
            penawaranController.addItem(penawaran7);

            listpenawaran.Items.Refresh();

        }
```
  - pada `Promo.xaml.cs` terdapat penambahan promo untuk dijadikan list yaitu pada
  
  ```  private void generateContentPromo()
        {
            Model.Promo promo1 = new Model.Promo("Promo Awal tahun Diskon 25 % ", 1);
            Model.Promo promo2 = new Model.Promo("Promo Tebus Murah Diskon 30 % atau maksimal 30.000", 2);
            Model.Promo promo3 = new Model.Promo("Promo Natal Potongan 10000", 3);

            promoController.addPromo(promo1);
            promoController.addPromo(promo2);
            promoController.addPromo(promo3);

            listBoxDaftarPromo.Items.Refresh();
        } 
  ```
 - pada `MainWindow.xaml.cs`terdapat logika dari event misalkan penghapusan item yang sudah dipilih terdapat pada
 ```
 private void onlistKeranjangBelanjaDoubleClicked(object sender, MouseButtonEventArgs e)
        {
            if (MessageBox.Show("Ingin menghapus item ini?",
                   "Konfirmasi", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
            {
                ListBox listBox = sender as ListBox;
                Item item = listBox.SelectedItem as Item;
                controller.removeItem(item);
            }
        }
 ```

### Running Program

- Running  
![Running](https://github.com/nurjauharmuslih/Pemrograman_lanjut/blob/master/08_Responsi_UAS/JoCashierApps/Asset/Running.png) 
- Simulasi 1  
![Simulasi 1](https://github.com/nurjauharmuslih/Pemrograman_lanjut/blob/master/08_Responsi_UAS/JoCashierApps/Asset/Simulasi_1.png) 
- Simulasi 2  
![Simulasi 2](https://github.com/nurjauharmuslih/Pemrograman_lanjut/blob/master/08_Responsi_UAS/JoCashierApps/Asset/Simulasi_2.png)   
- Simulasi 3  
![Simulasi 3](https://github.com/nurjauharmuslih/Pemrograman_lanjut/blob/master/08_Responsi_UAS/JoCashierApps/Asset/Simulasi_3.png)  

