namespace _03_practice_patterns;

internal class Pizza: AbstractPizza
{
    public string Title { get; } = "no_title";
    public double BasePrice { get; protected set; } = 0.0;
    public override double FullPrice { get; protected set; } = 0.0;
    public PizzaSize Size { get; init; } = PizzaSize.Medium;

    public Pizza(string title, double basePrice, PizzaSize size = PizzaSize.Medium)
    {
        Title = title;
        BasePrice = basePrice;
        FullPrice = BasePrice;
        Size = size;
    }
    public override void AddToPrice(double price) => FullPrice += price;
    public void Render()
    {
        Console.WriteLine($"Title: {Title}");
        Console.WriteLine($"Full price: {FullPrice}");
    }
}
