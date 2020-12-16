using MVC_OrderApps.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Security.RightsManagement;
using System.Text;
using System.Threading.Tasks;

namespace MVC_OrderApps.Controller
{
    class MainWindowController
    {
        Keranjang keranjang;

        public MainWindowController (Keranjang keranjang)
        {
            this.keranjang = keranjang;
        }

        public void addItem(Item item)
        {
            this.keranjang.addItem(item);
        }

        public List<Item> getSelectedItems()
        {
            return this.keranjang.GetItems();
        }

        public void deleteSelectedItem(Item item)
        {
            this.keranjang.removeItemS(item);
        }
    }
}
