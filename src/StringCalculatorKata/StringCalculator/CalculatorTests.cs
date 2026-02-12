

namespace StringCalculator;
public class CalculatorTests
{
    [Fact]
    public void EmptyStringReturnsZero()
    {
        var calculator = new Calculator();

        var result = calculator.Add("");

        Assert.Equal(0, result);
    }

    [Theory]
    [InlineData("5", 5)]
    [InlineData("15", 15)]
    [InlineData("7", 7)]
    [InlineData("103", 103)]

    public void SingleIntReturnsSingleInt(string Snumber, int Inumber)
    {
        var calculator = new Calculator();

        var result = calculator.Add(Snumber);

        Assert.Equal(Inumber, result);
    }

    [Theory]
    [InlineData("5,2", 7)]
    [InlineData("6,2", 8)]
    [InlineData("1,0", 1)]
    public void AddTwoNumbers(string num, int sum)
    {
        var calculator = new Calculator();

        var result = calculator.Add(num);

        Assert.Equal(sum, result);
    }

    [Theory]
    [InlineData("1\n2,3",6)]
    public void AddNumbersEscapeChar(string num, int sum)
    {
        var calculator = new Calculator();

        var result = calculator.Add(num);

        Assert.Equal(sum, result);
    }

    [Theory]
    [InlineData("//#\n1#2#3", 6)]
    public void AddNumbersCustomDelim(string num, int sum)
    {
        var calculator = new Calculator();

        var result = calculator.Add(num);

        Assert.Equal(sum, result);
    }
}
