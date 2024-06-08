namespace _03_practice_patterns;

internal abstract class AbstractPizza
{
    public abstract double FullPrice { get; protected set; }
    public abstract void AddToPrice(double price);
}
