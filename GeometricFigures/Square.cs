namespace Backend;

public class Square : GeometricFigure
{
    //Fields
    private float _a;
    // Constructors
    public Square(string name, float a) : base(name)
    {
        A = a;
    }

    // Properties
    public float A
    {
        get => _a;
        set => _a = value;
    }

    // Public Methods
    public override float GetArea() => A * A;

    public override float GetPerimeter() => 4 * A;

    // Private Methods
    private float ValidateA(float a)
    {
        if (a <= 0)
        {
            throw new Exception("The side length must be a positive value.");
        }
        return a;
    }
}