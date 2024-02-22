using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CenaNaTransport.Views
{
    public class Display
    {
       public Display() 
        {
            this.Kilometers = 0;
            this.TimeOfDay = " ";
            this.TotalPrice = 0;
            this.GetValues();
        }
        public int Kilometers { get; set; }
        public string TimeOfDay { get; set; }
        public double TotalPrice { get; set; }
        public void GetValues()
        {
            Console.WriteLine("Enter km:");
            this.Kilometers = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter time of day: ");
            this.TimeOfDay = Console.ReadLine();
        }
        public void ShowPrice()
        {
            Console.WriteLine($"The cheapest price is: {TotalPrice:f2}");
        }
    }
}
