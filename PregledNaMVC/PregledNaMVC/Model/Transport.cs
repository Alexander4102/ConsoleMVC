using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CenaNaTransport.Model
{
    public class Transport
    {

        public Transport(int kilometers, string timeOfDay) 
        {
        this.TimeOfDay = timeOfDay;
        this.Kilometers = kilometers;
        }

        public int Kilometers { get; set; }
        public string TimeOfDay { get; set; }

        public Transport() : this(0, "")
        {

        }
        public double CalculatePrice()
        {
            double taksa = 0;
            double tarifa = 0;
            if (this.Kilometers < 20)
            {
                taksa = 0.70;
                if (this.TimeOfDay == "day")
                {
                    tarifa = 0.79;
                }
                else
                {
                    tarifa = 0.9;
                }
            }
            else if (this.Kilometers < 100)
            {
                {
                    tarifa = 0.09;
                }
            }
            else
            {
                tarifa = 0.6;
            }
            return taksa + tarifa * this.Kilometers;
        }
    }
}
