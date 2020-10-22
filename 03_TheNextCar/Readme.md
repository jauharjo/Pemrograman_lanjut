# The Next Car
- Aplikasi ini merupakan sebuah program yang menerapkan konsep MVC (Model View Controller)
- Mobil hanya dapat dihidupkan ketika kondisi "pintu sudah tertutup, pintu sudah terkunci dan Aki sudah menyala"

## Fungsionalitas
-  User bisa menekan tombol `STARTED/STOPPED`, `OPENED/CLOSED`, `LOCKED/UNCLOCKED`, dan `ON/OFF`
-  User hanya bisa menekan started ketika kondisi yang disebutkan telah terpenuhi
-  User tidak bisa mengutak-atik GPS karena itu hanya gambar pemanis semata

## Cara Kerja
> Untuk menerapkan kosep MVC ini aku pecah menjadi 3 bagian. 
- Konsep Model aku letakkan pada folder Model yang berisikan class `Door.cs` dan `AccuBattery.cs`
- Konsep View ada pada `MainWindow.xaml`
- Konsep Controoler aku letakkan pada folder Controller yang berisi class `AccuBatteryController.cs` `DoorController.cs` dan `Car.cs`
- Dan untuk Function terdapat pada class `MainWindow.xaml.cs`
