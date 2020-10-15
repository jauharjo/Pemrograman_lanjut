# Currency Apps

Aplikasi ini berfungsi untuk mengkonversi dari mata uang US Dollar ke Rupiah dengan $1 = Rp. 15000

## Fungsionalitas
- User dapat memasukkan Angka
- User dapat menyentuh button Konversi
- User mendapat Info "Input Hatus Angka" Jika memasukkan karakter selain angka (huruf, simbol ,dsb)

### Cara Kerja
 Diawali dari Method `MainWindow` pada class `MainWindow.xaml.cs` kita mendeklarasikan 
``` csharp
public MainWindow()
        {
            InitializeComponent();
            currency = new CurrencyController();
        }
```
Logika perhitungan terdapat pada class `CurrencyController.cs` sbb :
```csharp
public string UsdToIdr(string nominal)
        {
            var nominalDouble = Convert.ToDouble(nominal);
            var result = nominalDouble * 15000;
            return Convert.ToString(result);
        }

        public Boolean IsAllowed(string nominal)
        {
            Regex regex = new Regex("[^0-9.-]+");
            return !regex.IsMatch(nominal);
        }
```
