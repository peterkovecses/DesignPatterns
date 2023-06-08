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

    public class TextPrinter
    {
        private ITextFormatter _formatter;

        public TextPrinter(ITextFormatter formatter)
        {
            _formatter = formatter;
        }

        public void SetFormatter(ITextFormatter formatter)
        {
            _formatter = formatter;
        }

        public void Print(string input)
        {
            var formattedInput = _formatter.Format(input);
            Console.WriteLine(formattedInput);
        }
    }
    
    public static class Test
    {
        public static void UsePattern()
        {
            string sampleText = "Sample Text";

            var printer = new TextPrinter(new UpperCaseFormatter());
            printer.Print(sampleText); // SAMPLE TEXT

            printer.SetFormatter(new LowerCaseFormatter());
            printer.Print(sampleText); // sample text
        }
    }
}


