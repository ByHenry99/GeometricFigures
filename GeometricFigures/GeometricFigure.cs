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

    public override string ToString() => $"{Name} \t=> Area.....:\t{GetArea():F5}\tPerimeter:\t {GetPerimeter():F5}";

}
