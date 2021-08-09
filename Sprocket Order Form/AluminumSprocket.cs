using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprocket_Order_Form
{
    class AluminumSprocket : Sprocket
    {
        public AluminumSprocket(int itemID, int numItems, int numTeeth) : base()
        {

        }
        //Type specific calc
        override protected void Calc()
        {
            Price = Convert.ToDecimal((0.04) * NumTeeth * NumItems);
        }

        public override string ToString()
        {
            return base.ToString() + " Material: Aluminum";
        }
    }
}
