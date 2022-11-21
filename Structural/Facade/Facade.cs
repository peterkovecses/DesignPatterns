using Structural.Facade.Subsystems;

namespace Structural.Facade
{
    public class Facade
    {
        private readonly EmailService _emailService = new();
        private readonly SmsService _smsService = new();
        private readonly TelegraphService _telegraphService = new();

        public void SendMessageOnAllChannel(string message)
        {
            _emailService.Send(message);
            _smsService.Send(message);
            _telegraphService.Send(message);
        }
    }
}
