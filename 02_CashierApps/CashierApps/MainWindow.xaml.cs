using System;
using System.Windows;

namespace CashierApps
{

    public partial class MainWindow : Window
    {
        private Calculator calculator;
        public MainWindow()
        {
            InitializeComponent();
            calculator = new Calculator();
            listBox1.ItemsSource = calculator.GetListItem();
        }
  
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
    }
}
