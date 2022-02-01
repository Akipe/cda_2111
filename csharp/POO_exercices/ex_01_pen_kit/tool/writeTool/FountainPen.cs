namespace ex_01_pen_kit.tool.writeTool;

// StyloPlume
public class FountainPen : WriteTool
{
    public FountainPen(ConsoleColor color) : base()
    {
        Color = color;
    }
    
    public void ReplaceInkCartidge(ConsoleColor color)
    {
        WriteCapacity = WRITE_CAPACITY_MAX;
    }
}