# The Cashier Apps

Aplikasi ini merupakan aplikasi kasir sederhana yang berfungsi untuk melakukan perhitungan transaksi barang/jasa dengan cara menginputkan jumlah dan harganya.

## Fungsionalitas
- User dapat memasukkan Nama
- User dapat memilih Tipe Barang/Jasa
- User dapat Menambahkan Jumlah dan Harga
- Pada bagian jumlah dan harga User harus mengisikan berupa angka (Tidak boleh karakter/huruf)
- Tampilan Total dari yang diinputkan Berada pada Label Total dipaling bawah

### Cara Kerja
- Diawali dari Method `MainWindow` pada class `MainWindow.xaml.cs` kita mendeklarasikan 
``` csharp
private Calculator calculator;
    public MainWindow()
    {
        InitializeComponent();
        calculator = new Calculator();
        listBox1.ItemsSource = calculator.GetListItem();
    }
```

- Inisiasi List dan Perhitungaan Barang/Jasa terdapat pada class `Item.cs` :
``` csharp
public string GetTitle()
{
    return title;
}
public int GetQuantity()
{
    return quantity;
}
public double GetPrice()
{
    return price;
}
public double GetSubTotal()
{
    subtotal = price * quantity;
    return subtotal;
}
public string GetType()
{
    return type;
}
```

- Logika Perhitungan Total Suluruh Barang/Jasa yg telah diinput berada di Class `Calculator.cs` :
``` csharp
public void AddItem(Item item)
    {
        this.listItem.Add(item);
        this.total += item.GetSubTotal();
    }
```

- Cara menampilkan apa yang telah diinput Ke dalam ListBox(Ketika Menekan Button Tambahkan)
``` csharp
private void AddButton_Click(object sender, RoutedEventArgs e)
{
    string title = itemNameBox.Text;
    int quantity = int.Parse(quantityBox.Text);
    string type = typeBox.Text;
    double price = double.Parse(priceBox.Text);

    Item item = new Item(new Random().Next(), title, quantity, price, price, type);
    calculator.AddItem(item);
    double total = calculator.GetTotal();

    totalLabel.Content = String.Format("Rp {0}", total);
    listBox1.Items.Refresh();
}
```