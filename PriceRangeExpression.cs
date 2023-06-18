public class PriceRangeExpression : IExpression
{
    private decimal _minPrice;
    private decimal _maxPrice;

    public PriceRangeExpression(decimal minPrice, decimal maxPrice)
    {
        Console.WriteLine($"PriceRangeExpression created with range: {minPrice}-{maxPrice}");
        _minPrice = minPrice;
        _maxPrice = maxPrice;
    }

    public bool Interpret(Car car)
    {
        Console.WriteLine($"Interpreting Price for car: {car.Price}");
        return car.Price >= _minPrice && car.Price <= _maxPrice;
    }
}