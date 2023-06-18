public class CarCatalogMediator : IMediator
{
    private readonly List<Car> _cars;
    private readonly List<IExpression> _expressions;

    public CarCatalogMediator(List<Car> cars)
    {
        Console.WriteLine("CarCatalogMediator created.");
        _cars = cars;
        _expressions = new List<IExpression>();
    }

    public void AddExpression(IExpression expression)
    {
        Console.WriteLine("Expression added to CarCatalogMediator.");
        _expressions.Add(expression);
    }

    public void Notify(object sender, string eventName)
    {
        Console.WriteLine($"CarCatalogMediator notified of event: {eventName}");
        if (eventName == "FilterChanged")
        {
            var filteredCars = _cars.Where(car => _expressions.All(exp => exp.Interpret(car)));
            CarCatalog.Update(filteredCars.ToList());
        }
    }
}