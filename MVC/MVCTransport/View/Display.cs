using System;

namespace MVCTransport.View
{
    public class Display
    {
        public Display()
        {
            this.Km = 0;
            this.TimeOfDay = string.Empty;
            this.Total = 0;
            this.GetValues();
        }
        public int Km { get; set; }
        public string TimeOfDay { get; set; }
        public double Total { get; set; }
        public void GetValues()
        {
            this.Km = int.Parse(Console.ReadLine());
            this.TimeOfDay = Console.ReadLine();
        }
        public void ShowResults()
        {
            Console.WriteLine($"{this.Total:f2}");
        }
    }
}
