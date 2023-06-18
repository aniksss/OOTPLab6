public class MakeExpression : IExpression
{
    private string _make;

    public MakeExpression(string make)
    {
        Console.WriteLine($"MakeExpression created with make: {make}");
        _make = make;
    }

    public bool Interpret(Car car)
    {
        Console.WriteLine($"Interpreting Make for car: {car.Make}");
        return car.Make.Equals(_make, StringComparison.OrdinalIgnoreCase);
    }
}