namespace Backend;

public class Rhombus : Square
{
    // Fields
    private float _d1;
    private float _d2;

    // Constructors 
    public Rhombus(string name, float a, float d1, float d2) : base(name, a)
    {
        D1 = d1;
        D2 = d2;
    }

    // Properties
    public float D1 
    { 
        get => _d1; 
        set => _d1 = ValidateD1(value); 
    }
    public float D2 
    { 
        get => _d2; 
        set => _d2 = ValidateD2(value); 
    }

    // Public Methods
    public override float GetArea() => (D1 * D2) / 2;
    public override float GetPerimeter() => 4 * A;

    // Private Methods
    private float ValidateD1(float d1)
    {
        if (d1 <= 0)
        {
            throw new Exception("The diagonal d1 must be a positive value.");
        }
        return d1;
    }

    private float ValidateD2(float d2)
    {
        if (d2 <= 0)
        {
            throw new Exception("The diagonal d2 must be a positive value.");
        }
        return d2;
    }
}
