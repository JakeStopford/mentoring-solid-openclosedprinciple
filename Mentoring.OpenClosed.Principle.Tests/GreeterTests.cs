using NUnit.Framework;

namespace Mentoring.OpenClosed.Principle.Tests
{
    public class GreeterTests
    {
        [Test]
        public void Greeter_ReturnsHello()
        {
            // Arrange 
            var greeter = new Greeter();
            
            // Act
            var result = greeter.Greet();
            
            // Assert
            Assert.AreEqual("Hello", result);
        }

        [Test]
        public void Greeter_InFrench_ReturnsHello()
        {
            // Arrange 
            var greeter = new FrenchGreeter();

            // Act
            var result = greeter.Greet();

            // Assert
            Assert.AreEqual("Bonjour", result);
        }

        [Test]
        public void Greeter_InSpanish_ReturnsHello()
        {
            // Arrange 
            var greeter = new SpanishGreeter();

            // Act
            var result = greeter.Greet();

            // Assert
            Assert.AreEqual("Hola", result);
        }

        [Test]
        public void Greeter_InItalian_ReturnsHello()
        {
            // Arrange 
            var greeter = new ItalianGreeter();

            // Act
            var result = greeter.Greet();

            // Assert
            Assert.AreEqual("Ciao", result);
        }
    }
}