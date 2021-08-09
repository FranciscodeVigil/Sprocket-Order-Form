using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprocket_Order_Form
{
    public class Address
    {
        public string City = "";

        public string State = "";

        public string Street = "" ;

        public string ZipCode = "";

        public override string ToString()
        {
            return Street + ", " + City + ", " + State + " " + ZipCode;
        }
    }
}
