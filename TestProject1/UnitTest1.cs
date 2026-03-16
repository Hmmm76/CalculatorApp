using CalculatorApp;

namespace TestProject1;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {   
        Calculator calc = new CalculatorApp.Calculator();
        
        int result = calc.Sum(2, 3);
        
        Assert.Equal(5, result);
    }
}