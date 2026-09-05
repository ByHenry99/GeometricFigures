namespace Backend;

public class Triangle : Rectangle
{
    // Fields
    private float _c;
    private float _h;

    // Constructors
    public Triangle(string name, float a, float b, float c, float h) : base(name, a, b)
    {
        C = c;
        H = h;
    }

    // Properties
    public float C 
    { 
        get => _c; 
        set => _c = ValidateC(value); 
    }

    public float H 
    { 
        get => _h; 
        set => _h = ValidateH(value); 
    }

    // Public Methods
    public override float GetArea() => (B * H) / 2;

    public override float GetPerimeter() => A + B + C;

    // Private Methods
    private float ValidateC(float c)
    {
        if (c <= 0)
            throw new ArgumentException("The side length must be a positive number.");
        return c;
    }

    private float ValidateH(float h)
    {
        if (h <= 0)
            throw new ArgumentException("The height must be a positive number.");
        return h;
    }
}
