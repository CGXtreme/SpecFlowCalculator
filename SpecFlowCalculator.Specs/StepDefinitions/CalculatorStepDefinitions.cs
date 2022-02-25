//Caden Gardner
//2-24-2022
//Calculator Step Definitions for SpecFlow

using FluentAssertions;
using TechTalk.SpecFlow;

namespace SpecFlowCalculator.Specs.StepDefinitions
{
    [Binding]
    public sealed class CalculatorStepDefinitions
    {
        // For additional details on SpecFlow step definitions see https://go.specflow.org/doc-stepdef

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

        [When("the two numbers are subtracted")]
        public void WhenTheTwoNumbersAreSubtracted()
        {
            _result = _calculator.Subtract();
        }

        [When("the two numbers are multiplied")]
        public void WhenTheTwoNumbersAreMultiplied()
        {
            _result = _calculator.Multiply();
        }

        //Makes the result of the operation both _result && FirstNumber so operations can continue chaining
        [When("operation (.*) is done to the number (.*)")]
        public void WhenOperationIsDoneToNumber(char op, int num)
        {

            _calculator.FirstNumber = _calculator.Operation(op, num);
            _result = _calculator.FirstNumber;
        }

        [Then("the result should be (.*)")]
        public void ThenTheResultShouldBe(int result)
        {
            _result.Should().Be(result);

        }
    
    }
}