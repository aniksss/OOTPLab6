public class ShoppingCart
{
    private readonly List<Car> _items;

    public ShoppingCart()
    {
        Console.WriteLine("ShoppingCart created.");
        _items = new List<Car>();
    }

    public void AddItem(Car car)
    {
        Console.WriteLine($"Adding car to ShoppingCart: {car.Make} {car.Model}");
        _items.Add(car);
        // update the UI with the new item
    }

    public void RemoveItem(Car car)
    {
        Console.WriteLine($"Removing car from ShoppingCart: {car.Make} {car.Model}");
        _items.Remove(car);
        // update the UI by removing the item
    }
}