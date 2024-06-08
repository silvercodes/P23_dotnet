namespace _03_practice_patterns.Decoration;

internal abstract class Decorator: AbstractPizza
{
    private AbstractPizza item;
    public Decorator(AbstractPizza item)
    {
        this.item = item;
    }



}
