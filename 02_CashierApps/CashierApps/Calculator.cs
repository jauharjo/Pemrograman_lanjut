using System.Collections.Generic;

namespace CashierApps
{
    class Calculator
    {
        private List<Item> listItem;
        private double total = 0;

        public Calculator()
        {
            this.listItem = new List<Item>();
        }

        public void AddItem(Item item)
        {
            this.listItem.Add(item);
            this.total += item.GetSubTotal();
        }

        public double GetTotal()
        {
            return total;
        }

        public List<Item> GetListItem()
        {
            return listItem;
        }
    }
}
