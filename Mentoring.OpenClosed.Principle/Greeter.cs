namespace Mentoring.OpenClosed.Principle
{
    public interface IGreeter
    {
        string Greet();
    }

    public class Greeter : IGreeter
    {
        public string Greet()
        {
            return "Hello";
        }
    }
}
