namespace CashierApps
{
    class Item
    {
        private int id;
        public string title { get; set; }
        public int quantity { get; set; }
        public double price { get; set; }
        public double subtotal { get; set; }
        private string type;

        public Item(int id, string title, int quantity, double price, double subtotal, string type)
        {
            this.id = id;
            this.title = title;
            this.quantity = quantity;
            this.price = price;
            this.subtotal = subtotal;
            this.type = type;
        }

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
    }
}
