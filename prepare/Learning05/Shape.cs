public abstract class Shape
{
    private string _color;

    public Shape(string color)
    {
        _color = color;
    }

    // Getter
    public string GetColor()
    {
        return _color;
    }

    // Setter
    public void SetColor(string color)
    {
        _color = color;
    }

    public abstract double GetArea();
}