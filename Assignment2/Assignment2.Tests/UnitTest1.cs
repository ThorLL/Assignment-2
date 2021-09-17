using System;
using Xunit;
using System.IO;

namespace Assignment2.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Main_prints_Hallo_World()
        {
            var writer = new StringWriter();
            Console.SetOut(writer);

            Class1.Main(new string[0]);

            var output = writer.GetStringBuilder().ToString().Trim();
            Assert.Equal("Hallo World",output);
        }
    }
}
