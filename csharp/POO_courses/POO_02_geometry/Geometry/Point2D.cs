using System.Text;

namespace POO_02_geometry.Geometry;

public class Point2D
{
    private int _x;
    private int _y;

    public Point2D(int x = 0, int y = 0)
    {
        SetCoordinates(x, y);
    }

    /// <summary>
    /// Coordinates of the abscissa
    /// </summary>
    public int X
    {
        get => _x;
        set => _x = value;
    }

    /// <summary>
    /// Coordinates of ordinate
    /// </summary>
    public int Y
    {
        get => _y;
        set => _y = value;
    }

    public virtual void SetCoordinates(int x, int y)
    {
        X = x;
        Y = y;
    }

    public void AddToCoordinates(int howManyToX, int howManyToY)
    {
        SetCoordinates(X += howManyToX, Y += howManyToY);
    }
    
    public override string ToString()
    {
        StringBuilder pointStatusBuild = new StringBuilder();

        pointStatusBuild.Append("Point coordinates :\n");
        pointStatusBuild.Append($"- abscissa (x): {X}\n");
        pointStatusBuild.Append($"- ordinate (y): {Y}");
        
        return pointStatusBuild.ToString();
    }
}