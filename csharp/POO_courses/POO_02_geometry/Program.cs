// See https://aka.ms/new-console-template for more information

using POO_02_geometry.Geometry;

Point2D p1 = new Point2D();
Point2D p2 = new Point2D(4, 8);

p1.X = 7;
p1.Y = 14;

Console.WriteLine("P1");
Console.WriteLine(p1 + "\n");

Console.WriteLine("P2");
Console.WriteLine(p2 + "\n");

Point3D p3 = new Point3D(5, 6, 2);
Console.WriteLine("P3");
Console.WriteLine(p3 + "\n");

Segment2D s1 = new Segment2D(p1, p2);
Segment2D s2 = new Segment2D(
    new Point2D(1, 2),
    new Point2D(3, 4)
    );
    
Console.WriteLine("S1");
Console.WriteLine(s1 + "\n");

Console.WriteLine("S2");
Console.WriteLine(s2 + "\n");

// Console.WriteLine("S2");
// s2.FirstPoint = null;
// Console.WriteLine(s2 + "\n");
//
// Segment2D s3 = new Segment2D(p1, null);
// Console.WriteLine("S3");
// Console.WriteLine(s3 + "\n");

p3.SetCoordinates(1, 1);