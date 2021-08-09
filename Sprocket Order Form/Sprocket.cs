using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprocket_Order_Form
{
    public abstract class Sprocket
    {
        public Sprocket()
        {

        }

        public Sprocket(int itemID, int numItems, int numTeeth )
        {
            ItemID = itemID;

            NumItems = numItems;

            NumTeeth = numTeeth;
        }

        public int NumItems;

        public int NumTeeth;

        private decimal price;
        public decimal Price
        {
            get { return price; }
            set { price = value; }
        }

        readonly int ItemID;

        protected abstract void Calc();

        public override string ToString()
        {
            return "Order Number:" + ItemID + " Number of Items:" + NumItems + " Number of Teeth:" + NumTeeth + "Price:" + price;
        }
    }
}
