using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprocket_Order_Form
{
    class SteelSprocket : Sprocket
    {

        public SteelSprocket(int itemID, int numItems, int numTeeth) : base()
        {

        }
        //Type specific calc
        override protected void Calc()
        {
            Price = Convert.ToDecimal((0.05) * NumTeeth * NumItems);
        }

        public override string ToString()
        {
            return base.ToString() + " Material: Steel";
        }

    }
}
