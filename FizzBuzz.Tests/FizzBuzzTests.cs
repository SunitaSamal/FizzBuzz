using Xunit;

namespace FizzBuzz.Tests
{
    public class FizzBuzzTests
    { 
        [Fact] 
        public void GetFizzBuzzOutput_Returns_Fizz_When_Number_Is_Divisible_By_Only_3()
        {
            Assert.Equal("Fizz", FizzBuzzOuput.GetFizzBuzzOutput(-3));
            Assert.Equal("Fizz", FizzBuzzOuput.GetFizzBuzzOutput(3));
            Assert.Equal("Fizz", FizzBuzzOuput.GetFizzBuzzOutput(6));
            Assert.Equal("Fizz", FizzBuzzOuput.GetFizzBuzzOutput(9));
        }

        [Fact]
        public void FizzBuzz_GetOutput_Method_Returns_Buzz_When_Number_Is_Divisible_By_Only_5()
        {
            Assert.Equal("Buzz", FizzBuzzOuput.GetFizzBuzzOutput(-5));
            Assert.Equal("Buzz", FizzBuzzOuput.GetFizzBuzzOutput(5));
            Assert.Equal("Buzz", FizzBuzzOuput.GetFizzBuzzOutput(10));
            Assert.Equal("Buzz", FizzBuzzOuput.GetFizzBuzzOutput(20));
        }

        [Fact]
        public void FizzBuzz_GetOutput_Method_Returns_FizzBuzz_When_Number_Is_Divisible_By_3_And_5()
        {
            Assert.Equal("FizzBuzz", FizzBuzzOuput.GetFizzBuzzOutput(-15));
            Assert.Equal("FizzBuzz", FizzBuzzOuput.GetFizzBuzzOutput(0));
            Assert.Equal("FizzBuzz", FizzBuzzOuput.GetFizzBuzzOutput(15));
            Assert.Equal("FizzBuzz", FizzBuzzOuput.GetFizzBuzzOutput(30)); 
        }
    }
}
