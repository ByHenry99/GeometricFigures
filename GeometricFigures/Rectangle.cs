namespace Backend;

public class Rectangle : Square
{
    // Fields
    private float _b;

    // Constructors
    public Rectangle(string name, float a, float b) : base(name, a)
    {
        B = b;
    }

    // Properties
    public float B 
    { 
        get => _b; 
        set => _b = ValidateB(value); 
    }

    // Public Methods
    public override float GetArea() => A * B;

    public override float GetPerimeter() => 2 * (A + B);

    // Private Methods
    private float ValidateB(float b)
    {
        if (b <= 0)
        {
            throw new Exception("The side length b must be a positive value.");
        }
        return b;
    }
}
