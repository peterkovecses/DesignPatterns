namespace Structural.Bridge
{
    // Implementációs interfész
    public interface IPrinter
    {
        void Print(string text);
    }

    // Implementációs osztály 1
    public class ConsolePrinter : IPrinter
    {
        public void Print(string text)
        {
            Console.WriteLine("Konzol nyomtató: " + text);
        }
    }

    // Implementációs osztály 2
    public class FilePrinter : IPrinter
    {
        public void Print(string text)
        {
            // Itt lenne a fájlba írás logika
            Console.WriteLine("Fájl nyomtató: " + text);
        }
    }

    // Absztrakció osztály (alapvető működés)
    public abstract class Message
    {
        protected IPrinter _printer;

        public Message(IPrinter printer)
        {
            _printer = printer;
        }

        public abstract void SendMessage(string text);
    }

    // Kiterjesztett absztrakció osztály
    public class TextMessage : Message
    {
        public TextMessage(IPrinter printer) : base(printer) { }

        public override void SendMessage(string text)
        {
            _printer.Print(text);
        }
    }

    public class Test
    {
        public static void UsePattern()
        {
            IPrinter consolePrinter = new ConsolePrinter();
            IPrinter filePrinter = new FilePrinter();

            Message message = new TextMessage(consolePrinter);
            message.SendMessage("Szia Világ!");

            message = new TextMessage(filePrinter);
            message.SendMessage("Szia Világ!");
        }
    }
}
