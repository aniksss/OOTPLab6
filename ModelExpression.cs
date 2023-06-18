public class ModelExpression : IExpression
{
    private string _model;

    public ModelExpression(string model)
    {
        Console.WriteLine($"ModelExpression created with model: {model}");
        _model = model;
    }

    public bool Interpret(Car car)
    {
        Console.WriteLine($"Interpreting Model for car: {car.Model}");
        return car.Model.Equals(_model, StringComparison.OrdinalIgnoreCase);
    }
}