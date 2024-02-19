using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ConsoleApp1.Model;
using ConsoleApp1.Views;

namespace ConsoleApp1.Controlers
{
    public class TipCalculatorControler
    {
        private Tip tip;
        private Display display;

        public TipCalculatorControler()
        {
            display = new Display();
            tip = new Tip(display.Amount, display.Percent);
            display.TipAmount = tip.CalculateTip();
            display.Total = tip.CalculateTotal();
            display.ShowTipeAndTotal();
        }
    }
}
