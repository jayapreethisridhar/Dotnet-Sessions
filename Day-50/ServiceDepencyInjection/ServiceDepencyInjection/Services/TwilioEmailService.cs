namespace ServiceDepencyInjection.Services
{
    public class TwilioEmailService:IRRdEmailService
    {
        public TwilioEmailService() 
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("TwilioEmailService created");
            Console.ResetColor();

        }
        public Task SendEmailAsync(string to,string subject,string body)
        {
            return Task.Run(() =>
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"Sending Email via Twilio Services to user {to} subject {subject} body{body}");
                Console.ResetColor();
            }
            );

        }
    }
}
