public class Shape
{
    private string color;

    public Shape(string color)
    {
        this.color = color;
    }

    public string Color
    {
        get { return color; }
        set { color = value; }
    }

    public virtual double GetArea()
    {
        return 0.0;
    }
}