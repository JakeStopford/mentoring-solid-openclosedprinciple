namespace Mentoring.OpenClosed.Principle
{
    public interface IGreeter
    {
        string Greet(Language language);
    }
    public class Greeter : IGreeter
    {
        public string Greet(Language language)
        {
            switch (language)
            {
                case Language.French:
                    return "Bonjour";
                case Language.Spanish:
                    return "Hola";
                case Language.Italian:
                    return "Ciao";
                default:
                    return "Hello";
            }
        }
    }
}
