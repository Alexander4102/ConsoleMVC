using ConsoleApp1.Model;

namespace ConsoleApp1.Views
{
    public class Display
    {
        public double Percent {  get; set; }
        public double Amount { get; set; }
        public double Total { get; set; }
        public double TipAmount { get; set; }

        public Display() 
        {
            Percent = 0;
            Amount = 0;
            Total = 0;
            TipAmount = 0;
            GetValues();
        }
        public void GetValues()
        {
            Console.WriteLine("Enter the amount of the meal: " );
            Amount = double.Parse( Console.ReadLine() );
            Console.WriteLine("Enter the percent you want to tip");
            Percent = double.Parse( Console.ReadLine() );
        }
        public void ShowTipeAndTotal()
        {
            Console.WriteLine("Your Tip is :{0:C} ", TipAmount);
            Console.WriteLine("Your total will be {0:C}", Total );
        }
       
    }
}
