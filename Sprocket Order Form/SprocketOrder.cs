using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprocket_Order_Form
{
    public class SprocketOrder
    {
        //Constructors
        public SprocketOrder()
        {

        }
        public SprocketOrder(Address address, string customerName, List<Sprocket> items, decimal price)
        {
            Address = address;
            CustomerName = customerName;
            Items = items;
            TotalPrice = price;
        }

        public List<Sprocket> Items = new();

        public Address Address;

        public string CustomerName;

        public decimal TotalPrice = 0m;
        //adds item to Items
        public void Add(Sprocket item)
        {
            Items.Add(item);
            Calc();
        }
        public void Remove(int index)
        {
            Items.RemoveAt(index);
        }
        //Adds the prices of each sprocket together
        private void Calc()
        {
            decimal tempPrice = 0M;
            foreach (Sprocket item in Items)
            {
                tempPrice += item.Price;
            }
            TotalPrice = tempPrice;
        }
        public override string ToString()
        {
            if (Address.Street != null)
            {
                return "Name:" + CustomerName + " Address:" + Address.ToString();
            }
            else
            {
                return "Name:" + CustomerName + "Local Pickup";
            }
        }
    }
}
