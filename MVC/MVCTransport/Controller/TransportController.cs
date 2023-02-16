using MVCTransport.Model;
using MVCTransport.View;

namespace MVCTransport.Controller
{
    public class TransportController
    {
        private Display display;
        private Transport transport;
        public TransportController()
        {
            Display display = new Display();
            Transport transport = new Transport(display.Km, display.TimeOfDay);
            display.Total = transport.CalculatedPrice();
            display.ShowResults();
        }
    }
}
