namespace Backend;

public class Parallelogram : Rectangle
{
    // Fields
    private float _h;

    // Constructors
    public Parallelogram(string name, float a, float b, float h) : base(name, a, b)
    {
        H = h;
    }

    // Properties
    public float H
    {
        get => _h;
        set => _h = ValidateH(value);
    }

    // Public Methods
    public override float GetArea() => B * H;

    public override float GetPerimeter() => 2 * (A + B);

    // Private Methods
    private float ValidateH(float h)
    {
        if (h <= 0)
            throw new ArgumentException("Height must be a positive value.");
        return h;
    }
}
