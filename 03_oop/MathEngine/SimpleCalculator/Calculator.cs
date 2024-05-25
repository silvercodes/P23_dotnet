

namespace MathEngine.SimpleCalculator;

public class Calculator
{
    public int Execute(int a, int b, Operation op) => op switch
    {
        Operation.Add => a + b,
        Operation.Subtract => a - b,
        Operation.Multiplicate => a * b,
        Operation.Divide => a / b,
    };
}
    
