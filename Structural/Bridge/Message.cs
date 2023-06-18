namespace BridgeExample;

// Abstraction class (basic operation)
public abstract class Message
{
    protected IMessageService _messageSender;

    public Message(IMessageService messageSender, IEnumerable<string> recipients)
    {
        _messageSender = messageSender;
        Recipients = recipients;
    }

    public string Sender { get; set; } = default!;
    public string? Subject { get; set; }
    public string? Body { get; set; }
    public IEnumerable<string> Recipients { get; set; }

    public abstract void Send();
}

// Extended abstraction class
public class SystemMessage : Message
{
    public SystemMessage(IMessageService messageSender, IEnumerable<string> recipients) 
        : base(messageSender, recipients)
    {
        Sender = "System";
    }

    public override void Send()
    {
        _messageSender.SendMessage(Sender, Subject, Body, Recipients);
    }
}

// Extended abstraction class
public class UserMessage : Message
{
    public UserMessage(IMessageService messageSender, string sender, IEnumerable<string> recipients) 
        : base(messageSender, recipients)
    {
        Sender = sender;
    }

    public override void Send()
    {
        _messageSender.SendMessage(Sender, Subject, Body, Recipients);
    }
}

// Implementation interface
public interface IMessageService
{
    void SendMessage(string sender, string? subject, string? body, IEnumerable<string> recipients);
}

// Implementation class
public class TeamsService : IMessageService
{
    public void SendMessage(string sender, string? subject, string? body, IEnumerable<string> recipients)
    {
        // sending Teams message
    }
}

// Implementation class
public class EmailService : IMessageService
{
    public void SendMessage(string sender, string? subject, string? body, IEnumerable<string> recipients)
    {
        // sending e-mail message
    }
}

public static class ClientCode
{
    public static void Test()
    {
        IMessageService smsSender = new TeamsService();
        IMessageService emailSender = new EmailService();

        Message systemTeamsMessage = new SystemMessage(smsSender, new List<string> { "tom@gmail.com" }) 
            { Subject = "Important!", Body = "message" };
        systemTeamsMessage.Send();

        Message userEmailMessage = new UserMessage(emailSender, "tim@gmail.com", new List<string> { "tom@gmail.com" }) 
            { Subject = "Important!", Body = "message" };
        userEmailMessage.Send();
    }
}

