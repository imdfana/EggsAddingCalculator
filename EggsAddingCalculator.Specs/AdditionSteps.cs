using NUnit.Framework;
using System;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using TechTalk.SpecFlow;

namespace EggsAddingCalculator.Specs
{
    [Binding]
    public sealed class AdditionSteps
    {
        Process _realSut = Process.Start(new ProcessStartInfo(Path.Combine(AssemblyDirectory, "App.exe"))
        {
            UseShellExecute = false,
            RedirectStandardOutput = true,
            RedirectStandardInput = true
        });
        private int _result;

        public static string AssemblyDirectory
        {
            get
            {
                string codeBase = Assembly.GetExecutingAssembly().CodeBase;
                UriBuilder uri = new UriBuilder(codeBase);
                string path = Uri.UnescapeDataString(uri.Path);
                return Path.GetDirectoryName(path);
            }
        }

        [Given(@"I have entered (.*) into the calculator")]
        public void GivenIHaveEnteredIntoTheCalculator(int operand)
        {
            //Dropping lines...
            _realSut.StandardOutput.ReadLine();
            _realSut.StandardOutput.ReadLine();

            _realSut.StandardInput.WriteLine(operand);
        }

        [Given(@"I have also entered (.*) into the calculator")]
        public void GivenIHaveAlsoEnteredIntoTheCalculator(int operand)
        {
            _realSut.StandardInput.WriteLine(operand);
        }

        [When(@"I select Add")]
        public void WhenISelectAdd()
        {
            _realSut.StandardOutput.ReadLine();
            string resultLine = _realSut.StandardOutput.ReadLine();
            _result = int.Parse(resultLine.Replace("Result: ", ""));
        }

        [Then(@"the result should be (.*) on the screen")]
        public void ThenTheResultShouldBeOnTheScreen(int expectedResult)
        {
            Assert.That(_result, Is.EqualTo(expectedResult));
        }
    }
}
