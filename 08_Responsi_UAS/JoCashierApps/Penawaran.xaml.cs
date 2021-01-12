// Nur Jauhar Muslih
// 19.11.2832
using JoCashierApps.Controller;
using JoCashierApps.Model;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace JoCashierApps
{
    public partial class Penawaran : Window
    {
        PenawaranController penawaranController;
        OnPenawaranChangedListener listener;
        public Penawaran()
        {
            InitializeComponent();
            penawaranController = new PenawaranController();
            listPenawaran.ItemsSource = penawaranController.getItems();
            generateContentItem();
        }

        public void SetOnItemSelectedListener(OnPenawaranChangedListener listener)
        {
            this.listener = listener;
        }
        private void OnlistPenawaranClicked(object sender, MouseButtonEventArgs e)
        {
            ListBox listbox = sender as ListBox;
            Item item = listbox.SelectedItem as Item;
            this.listener.OnPenawaranSelected(item);
        }

        private void generateContentItem()
        {
            Item Item1 = new Item("Coffe Late", 30000);
            Item Item2 = new Item("Black Tea", 20000);
            Item Item3 = new Item("Pizza", 75000);
            Item Item4 = new Item("Milk Shake", 15000);
            Item Item5 = new Item("Fried Frice Special", 45000);
            Item Item6 = new Item("Watermelon Juice", 25000);
            Item Item7 = new Item("Lemon Squash", 30000);

            penawaranController.addItem(Item1);
            penawaranController.addItem(Item2);
            penawaranController.addItem(Item3);
            penawaranController.addItem(Item4);
            penawaranController.addItem(Item5);
            penawaranController.addItem(Item6);
            penawaranController.addItem(Item7);

            listPenawaran.Items.Refresh();
        }
    }

    public interface OnPenawaranChangedListener
    {
        void OnPenawaranSelected(Item item);
    }
}
