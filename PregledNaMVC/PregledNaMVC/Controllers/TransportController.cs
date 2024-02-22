using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

using CenaNaTransport.Model;
using CenaNaTransport.Views;

namespace CenaNaTransport.Controlers
{
    public class TransportController
    {
     private Display display;
        private Transport transport;
        public TransportController()
        {
            display = new Display();
            transport = new Transport();
            display.TotalPrice = transport.CalculatePrice();
            display.ShowPrice();
        }

        
    }
}
