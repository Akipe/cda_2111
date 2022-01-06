using System.Text;

namespace POO_02_geometry.Geometry;

public class Segment2D
{
    private Point2D _firstPoint;
    private Point2D _secondPoint;

    public Segment2D(Point2D firstPoint, Point2D secondPoint)
    {
        FirstPoint = firstPoint;
        SecondPoint = secondPoint;
    }

    public Segment2D(int firstPointX, int firstPointY, int secondPointX, int secondPointY)
    {
        FirstPoint = new Point2D(firstPointX, firstPointY) ;
        SecondPoint = new Point2D(secondPointX, secondPointY);
    }

    public Point2D FirstPoint
    {
        get => _firstPoint;
        set => _firstPoint = value ?? throw new ArgumentNullException(nameof(value));
    }

    public Point2D SecondPoint
    {
        get => _secondPoint;
        set => _secondPoint = value ?? throw new ArgumentNullException(nameof(value));
    }

    public void ChangeCoordinatesPoints(
        int coordinateFirstPointX,
        int coordinateFirstPointY,
        int coordinateSecondPointX,
        int coordinateSecondPointY)
    {
        FirstPoint.SetCoordinates(coordinateFirstPointX, coordinateFirstPointY);
        FirstPoint.SetCoordinates(coordinateSecondPointX, coordinateSecondPointY);
    }

    public void AddToPointsCoordinates(int howManyToX = 0, int howManyToY = 0)
    {
        FirstPoint.AddToCoordinates(howManyToX, howManyToY);
        SecondPoint.AddToCoordinates(howManyToX, howManyToY);
    }

    public void MovePointToCoordinate(int x, int y, bool moveFirstPoint = true)
    {
        int distanceAddToX;
        int distanceAddToY;
        Point2D originPoint;
        Point2D otherPoint;
        
        if (moveFirstPoint)
        {
            originPoint = FirstPoint;
            otherPoint = SecondPoint;
        }
        else
        {
            originPoint = SecondPoint;
            otherPoint = FirstPoint;
        }
        
        originPoint.SetCoordinates(x, y);
        distanceAddToX = GetDistanceFromTwoCoordinates(x, FirstPoint.X);
        distanceAddToY = GetDistanceFromTwoCoordinates(y, FirstPoint.Y);
        otherPoint.AddToCoordinates(distanceAddToX, distanceAddToY);
    }

    private int GetDistanceFromTwoCoordinates(int origin, int destination)
    {
        return destination - origin;
    }

    public override string ToString()
    {
        StringBuilder messageInCreating = new StringBuilder();

        messageInCreating.Append("Information about the segment :\n");
        messageInCreating.Append($"Coordinates of first point : {FirstPoint}\n");
        messageInCreating.Append($"Coordinates of second point : {SecondPoint}");

        return messageInCreating.ToString();
    }
}