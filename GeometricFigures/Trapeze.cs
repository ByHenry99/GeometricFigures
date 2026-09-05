namespace Backend;

public class Trapeze : Triangle
{
    // Field
    private float _d;

    // Constructors
    public Trapeze(string name, float a, float b, float c, float h, float d) : base(name, a, b, c, h)
    {
        D = d;
    }

    // Properties
    public float D 
    { 
        get => _d; 
        set => _d = ValidateD(value); 
    }

    // Public Methods
    public override float GetArea() => ((B + D) * H) / 2;

    public override float GetPerimeter() => A + B + C + D;

    // Private Methods
    private float ValidateD(float d)
    {
        if (d <= 0)
            throw new ArgumentException("The side length must be a positive number.");
        return d;
    }
}
