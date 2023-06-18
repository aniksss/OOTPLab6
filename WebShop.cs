public class WebShop
{
    private readonly CarCatalogMediator _mediator;
    private readonly ShoppingCart _cart;

    public WebShop(List<Car> cars)
    {
        Console.WriteLine("WebShop created.");
        _mediator = new CarCatalogMediator(cars);
        _cart = new ShoppingCart();
    }

    public void FilterByMake(string make)
    {
        Console.WriteLine($"Filtering by Make: {make}");
        _mediator.AddExpression(new MakeExpression(make));
        _mediator.Notify(this, "FilterChanged");
    }

    public void FilterByModel(string model)
    {
        Console.WriteLine($"Filtering by Model: {model}");
        _mediator.AddExpression(new ModelExpression(model));
        _mediator.Notify(this, "FilterChanged");
    }

    public void FilterByYear(int year)
    {
        Console.WriteLine($"Filtering by Year: {year}");
        _mediator.AddExpression(new YearExpression(year));
        _mediator.Notify(this, "FilterChanged");
    }

    public void FilterByPriceRange(decimal minPrice, decimal maxPrice)
    {
        Console.WriteLine($"Filtering by Price Range: {minPrice}-{maxPrice}");
        _mediator.AddExpression(new PriceRangeExpression(minPrice, maxPrice));
        _mediator.Notify(this, "FilterChanged");
    }

    public void AddToCart(Car car)
    {
        Console.WriteLine($"Adding car to cart: {car.Make} {car.Model}");
        _cart.AddItem(car);
    }

    public void RemoveFromCart(Car car)
    {
        Console.WriteLine($"Removing car from cart: {car.Make} {car.Model}");
        _cart.RemoveItem(car);
    }
}