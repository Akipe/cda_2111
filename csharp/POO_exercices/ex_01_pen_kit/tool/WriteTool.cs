using System.Text;

namespace ex_01_pen_kit.tool;

// OutilEcriture
public abstract class WriteTool : ITool
{
    public const int WRITE_CAPACITY_MAX = 255;
    public const int WRITE_CAPACITY_MIN = 0;
    public const int WHEN_DECREASE_WRITE_CAPACITY_AFTER_X_WORDS = 10;
    
    private ConsoleColor _color;
    private int _writeCapacity;

    public WriteTool()
    {
        Color = ConsoleColor.Black;
        WriteCapacity = WRITE_CAPACITY_MAX;
    }

    public void Use(string argument)
    {
        Write(argument);
    }

    public ConsoleColor Color
    {
        get => _color;
        set => _color = value;
    }

    public int WriteCapacity
    {
        get => _writeCapacity;
        protected set => _writeCapacity = value;
    }

    protected void Write(string sentence)
    {
        string[] words = sentence.Split(' ');
        StringBuilder toWrite = new StringBuilder();
        int counterWordBeforeDecreaseCapacityWrite 
            = WHEN_DECREASE_WRITE_CAPACITY_AFTER_X_WORDS;
        Console.ForegroundColor = Color;

        foreach (string word in words)
        {
            if (WriteCapacity <= WRITE_CAPACITY_MIN)
            {
                Console.WriteLine("No more capacity of write, please change me :(");
                return;
            }
            
            toWrite.Append(word);
            toWrite.Append(' ');
            counterWordBeforeDecreaseCapacityWrite--;
            
            if (counterWordBeforeDecreaseCapacityWrite == 0)
            {
                WriteCapacity -= 1;
            }
            counterWordBeforeDecreaseCapacityWrite
                = WHEN_DECREASE_WRITE_CAPACITY_AFTER_X_WORDS;
        }
    }
}