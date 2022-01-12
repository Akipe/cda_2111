using System.Text;

namespace ex_01_pen_kit.tool.writeTool;

// Crayon
public abstract class Pencil : WriteTool
{
    private bool _minePointToBeCut;

    public Pencil() : base()
    {
        MinePointToBeCut = false;
    }

    public bool MinePointToBeCut
    {
        get => _minePointToBeCut;
        private set => _minePointToBeCut = value;
    }

    public void Sharpen()
    {
        MinePointToBeCut = false;
        WriteCapacity -= 1;
    }

    protected new void Write(string sentence)
    {
        if (!MinePointToBeCut)
        {
            Console.ForegroundColor = Color;
            
            Console.WriteLine(sentence);

            MinePointToBeCut = true;
        }
        else
        {
            Console.WriteLine("Please cut your mine point!");
        }
    }
}