namespace Backend;

public abstract class GeometricFigure
{
    // Constructors
    protected GeometricFigure(string name)
    {
        Name = name;
    }

    //  Properties
    public string Name { get; set; } = null!;

    //  Public Methods
    public abstract float GetArea();

    public abstract float GetPerimeter();

    public override string ToString() => $"{Name,-15} => Area.....: {GetArea(),15:N5}\t Perimeter: {GetPerimeter(),15:N5}";
    
}
