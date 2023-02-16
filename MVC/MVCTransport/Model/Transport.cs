namespace MVCTransport.Model
{
    public class Transport
    {
        public Transport(int km, string timeOfDay)
        {
            this.Km = km;
            this.TimeOfDay = timeOfDay;
        }

        public int Km { get; set; }
        public string TimeOfDay { get; set; }

        public double CalculatedPrice()
        {
            double price = 0;
            if (Km < 20)
            {
                if (TimeOfDay == "day")
                {
                    price = (Km * 0.79) + 0.70;
                }
                else if (TimeOfDay == "night")
                {
                    price = (Km * 0.90) + 0.70;
                }
            }
            else if (Km < 100)
            {
                price = Km * 0.09;
            }
            else
            {
                price = Km * 0.06;

            }
            return price;
        }
    }
}
