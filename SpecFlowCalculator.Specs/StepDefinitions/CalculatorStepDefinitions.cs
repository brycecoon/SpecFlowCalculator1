using FluentAssertions;
using TechTalk.SpecFlow;

namespace SpecFlowCalculator.Specs.StepDefinitions
{
    [Binding]
    public sealed class CalculatorStepDefinitions
    {
        //private readonly ScenarioContext _scenarioContext;
        private readonly Calculator _calculator = new Calculator();
        private int _result;

        [Given("the first number is (.*)")]
        public void GivenTheFirstNumberIs(int number)
        {
            _calculator.FirstNumber = number;
        }

        [Given("the second number is (.*)")]
        public void GivenTheSecondNumberIs(int number)
        {
            _calculator.SecondNumber = number;
        }

        [When("the two numbers are added")]
        public void WhenTheTwoNumbersAreAdded()
        {
            _result = _calculator.Add();
        }

        [When(@"the two numbers are subtracted")]
        public void WhenTheTwoNumbersAreSubtracted()
        {
            _result = _calculator.Subtract();
        }

        [When(@"the two numbers are multiplied")]
        public void WhenTheTwoNumbersAreMultiplied()
        {
            _result = _calculator.Multiply();
        }

        [When(@"operation \+ is done to the number (.*)")]
        public void WhenOperation1IsDoneToTheNumber(int p0)
        {
            _result = _calculator.AddNum(p0);
        }

        [When(@"operation / is done to the number (.*)")]
        public void WhenOperation2IsDoneToTheNumber(int p0)
        {
            _result = _calculator.DivideNum(p0);
        }

        [When(@"operation % is done to the number (.*)")]
        public void WhenOperation3IsDoneToTheNumber(int p0)
        {
            _result = _calculator.ModuloNum(p0);
        }

        [When(@"operation - is done to the number (.*)")]
        public void WhenOperation4IsDoneToTheNumber(int p0)
        {
            _result = _calculator.SubtractNum(p0);
        }


        [Then("the result should be (.*)")]
        public void ThenTheResultShouldBe(int result)
        {
            _result.Should().Be(result);
        }
    }
}