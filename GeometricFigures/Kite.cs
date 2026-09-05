namespace Backend;

public class Kite : Rhombus
{
    // Fields
    private float _b;

    // Constructors
    public Kite(string name, float a, float d1, float d2, float b) : base(name, a, d1, d2)
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
    public override float GetArea() => (D1 * D2) / 2;

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
