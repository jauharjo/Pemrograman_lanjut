// Nur Jauhar Muslih
// 19.11.2832
using JoCashierApps.Model;
using System.Collections.Generic;

namespace JoCashierApps.Controller
{
    class PenawaranController
    {
        private List<Item> penawaranItem;

        public PenawaranController()
        {
            penawaranItem = new List<Item>();
        }

        public void addItem(Item item)
        {
            this.penawaranItem.Add(item);
        }

        public List<Item> getItems()
        {
            return this.penawaranItem;
        }
    }
}
