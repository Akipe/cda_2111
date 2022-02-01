using System.Text;

namespace POO_02_geometry.Geometry;

public class Point3D : Point2D
{
    private int _z;

    public Point3D(int x, int y, int z) : base(x, y)
    {
        Z = z;
    }
    
    public int Z
    {
        get => _z;
        set => _z = value;
    }
    
    public void SetCoordinates(int x, int y, int z)
    {
        base.SetCoordinates(x, y);
        Z = z;
    }

    public override void SetCoordinates(int x, int y)
    {
        throw new Exception("debug");
    }

    public override string ToString()
    {
        StringBuilder pointStatusBuild = new StringBuilder();

        pointStatusBuild.Append("Point coordinates :\n");
        pointStatusBuild.Append($"- abscissa (x): {X}\n");
        pointStatusBuild.Append($"- ordinate (y): {Y}\n");
        pointStatusBuild.Append($"- height (z): {Z}");
        
        return pointStatusBuild.ToString();
    }
}