# FruitBucketApps
Aplikasi ini merupakan aplikasi keranjang buah sederhana yang dimana bisa menambahkan dan menghapus item yang berupa buah
## Fungsionalitas
- User dapat memilih/menambahkan buah kedalam keranjang
- User dapat menghapus buah dalam  keranjang
- User akan mendapat notifikasi jika keranjang penuh
## Cara Kerja
> Untuk menerapkan kosep MVC ini aku pecah menjadi 3 bagian. 
- Konsep Model aku letakkan pada folder Model yang berisikan class `Seller.cs`, `Fruit.cs`, `Bucket.cs`, dan `BucketEventListener.cs`
- Konsep View ada pada `MainWindow.xaml`
- Konsep Controoler aku letakkan pada folder Controller yang berisi class `BucketController.cs` dimana kamu bisa mengedit fungsionalitas dari program ini

Untuk melakukan inisiasi dan mengubah kapasitas keranjang bisa dilakukan di `MainWindow.xaml.cs`
```csharp
 public MainWindow()
        {
            InitializeComponent();
            Bucket keranjangBuah = new Bucket(4);
            BucketController bucketController = new BucketController(keranjangBuah, this);

            Jo = new Seller("Jo", bucketController);

            ListBoxBucket.ItemsSource = keranjangBuah.findAll();

        }
```
