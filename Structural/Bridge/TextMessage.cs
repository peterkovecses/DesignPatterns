namespace BridgeExample;

// Implementation interface
public interface IMessageSender
{
    void SendMessage(string urgency, string message);
}

// Implementation class
public class SmsSender : IMessageSender
{
    public void SendMessage(string urgency, string message)
    {
        Console.WriteLine($"Sending SMS with {urgency} urgency: {message}");
    }
}

// Implementation class
public class EmailSender : IMessageSender
{
    public void SendMessage(string urgency, string message)
    {
        Console.WriteLine($"Sending E-mail with {urgency} urgency: {message}");
    }
}

// Abstraction class (basic operation)
public abstract class Message
{
    protected IMessageSender _messageSender;
    protected string _urgency;

    public Message(IMessageSender messageSender, string urgency)
    {
        _messageSender = messageSender;
        _urgency = urgency;
    }

    public abstract void Send(string message);
}

// Extended abstraction class
public class StandardMessage : Message
{
    public StandardMessage(IMessageSender messageSender) : base(messageSender, "standard")
    {
    }

    public override void Send(string message)
    {
        _messageSender.SendMessage(_urgency, message);
    }
}

// Extended abstraction class
public class UrgentMessage : Message
{
    public UrgentMessage(IMessageSender messageSender) : base(messageSender, "urgent")
    {
    }

    public override void Send(string message)
    {
        _messageSender.SendMessage(_urgency, message);
    }
}

public static class ClientCode
{
    public static void Test()
    {
        IMessageSender smsSender = new SmsSender();
        IMessageSender emailSender = new EmailSender();

        Message standardSmsMessage = new StandardMessage(smsSender);
        standardSmsMessage.Send("Hello!");

        Message urgentEmailMessage = new UrgentMessage(emailSender);
        urgentEmailMessage.Send("Hello!");
    }
}

