using calculator.Services;

namespace calculatorTest;

public class UnitTest1
{

    public Calculator constructorClass()
    {
        string date = "02/02/2020";
        Calculator calc = new Calculator(date);
        return calc;
    }

    [Theory]
    [InlineData (1, 2, 3)]
    [InlineData (4, 5, 9)]
    public void TestSum(int numb1, int numb2, int result)
    {
        Calculator calc = constructorClass();
        int resultCalc = calc.sum(numb1, numb2);

        Assert.Equal(result, resultCalc);
    }

    [Theory]
    [InlineData (4, 2, 2)]
    [InlineData (100, 5, 95)]
    public void TestSub(int numb1, int numb2, int result)
    {
        Calculator calc = constructorClass();
        int resultCalc = calc.substract(numb1, numb2);

        Assert.Equal(result, resultCalc);
    }

    [Theory]
    [InlineData (1, 2, 2)]
    [InlineData (4, 5, 20)]
    public void TestMult(int numb1, int numb2, int result)
    {
        Calculator calc = constructorClass();
        int resultCalc = calc.multiply(numb1, numb2);

        Assert.Equal(result, resultCalc);
    }

    [Theory]
    [InlineData (4, 2, 2)]
    [InlineData (50, 5, 10)]
    public void TestDiv(int numb1, int numb2, int result)
    {
        Calculator calc = constructorClass();
        int resultCalc = calc.divider(numb1, numb2);

        Assert.Equal(result, resultCalc);
    }

    [Fact]
    public void TestDividerZero()
    {
        Calculator calc = constructorClass();
        Assert.Throws<DivideByZeroException>(
            () => calc.divider(3,0)
        );
    }

    [Fact]
    public void TestHistory()
    {
        Calculator calc = constructorClass();
        calc.sum(1,2);
        calc.substract(2,8);
        calc.divider(8,4);
        calc.multiply(3,4);

        var list = calc.history();

        Assert.NotEmpty(calc.history());
        Assert.Equal(3, list.Count);
    }

    // [Fact]
    // public void Test2()
    // {
    //     Calculator calc = new Calculator();
    //     int result = calc.sum(2,3);

    //     Assert.Equal(5, result);
    // }
}
