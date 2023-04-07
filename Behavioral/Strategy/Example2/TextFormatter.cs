namespace Behavioral.Strategy.Example2
{
    public interface ITextFormatter
    {
        string Format(string input);
    }

    public class UpperCaseFormatter : ITextFormatter
    {
        public string Format(string input)
        {
            return input.ToUpper();
        }
    }

    public class LowerCaseFormatter : ITextFormatter
    {
        public string Format(string input)
        {
            return input.ToLower();
        }
    }

    public class TextFormatter
    {
        private ITextFormatter _formatter;

        public TextFormatter(ITextFormatter formatter)
        {
            _formatter = formatter;
        }

        public void SetFormatter(ITextFormatter formatter)
        {
            _formatter = formatter;
        }

        public string Format(string input)
        {
            return _formatter.Format(input);
        }
    }
    
    public class Test
    {
        public static void UsePattern()
        {
            string sampleText = "Példa Szöveg";

            var formatter = new TextFormatter(new UpperCaseFormatter());
            Console.WriteLine("Nagybetűs formázás: " + formatter.Format(sampleText));

            formatter.SetFormatter(new LowerCaseFormatter());
            Console.WriteLine("Kisbetűs formázás: " + formatter.Format(sampleText));
        }
    }
}
