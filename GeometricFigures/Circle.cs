namespace Backend;

public class Circle : GeometricFigure
{
    // Fields
    private float _r;

    // Constructors
    public Circle(string name, float r) : base(name)
    {
        R = r;
    }

    //  Properties
    public float R 
    { 
        get => _r; 
        set => _r = ValidateR(value); 
    }

    // Public Methods
    public override float GetArea() => (float)Math.PI * _r * _r;

    public override float GetPerimeter() => 2 * (float)Math.PI * _r;

    // Private Methods
    private float ValidateR(float r)
    {
        if (r <= 0)
        {
            throw new Exception("The radius must be a positive value.");
        }

        return r;
    }

}
