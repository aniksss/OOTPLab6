public class YearExpression : IExpression
{
    private int _year;

    public YearExpression(int year)
    {
        Console.WriteLine($"YearExpression created with year: {year}");
        _year = year;
    }

    public bool Interpret(Car car)
    {
        Console.WriteLine($"Interpreting Year for car: {car.Year}");
        return car.Year == _year;
    }
}