namespace ex_03_russian_dolls;

public class RussianDolls
{
    private bool _isOpen;
    private short _size;
    private RussianDolls? _inRussianDolls;
    private RussianDolls? _containDolls;

    public RussianDolls(short size)
    {
        Size = size;
    }

    public bool IsOpen
    {
        get => _isOpen;
        private set => _isOpen = value;
    }

    public short Size
    {
        get => _size;
        init => _size = value;
    }

    public void Open()
    {
        if (IsOpen)
        {
            throw new ApplicationException("You can't open an already open Russian dolls");
        }

        IsOpen = true;
    }

    public void Close()
    {
        if (!IsOpen)
        {
            throw new ApplicationException("You can't close an already close Russian dolls");
        }

        IsOpen = false;
    }

    public void PutInt(RussianDolls russianDolls)
    {
        if (IsOpen)
        {
            throw new ApplicationException("");
        }

        if (IsInRussianDools())
        {
            throw new ApplicationException();
        }

        if (!russianDolls.IsOpen)
        {
            throw new ApplicationException();
        }

        if (!russianDolls.HasRussianDools())
        {
            throw new ApplicationException();
        }
        
        if (IsSmallerThanRussianDools(russianDolls))
        {
            throw new ApplicationException("You can't put this russian dolls inside an other smaller russian dolls.");
        }

        _inRussianDolls = russianDolls;
    }

    public void GetOutOf(RussianDolls russianDolls)
    {
        
    }

    public bool IsInRussianDools()
    {
        
    }

    public bool HasRussianDools()
    {
        
    }

    private bool IsSmallerThanRussianDools(RussianDolls russianDolls)
    {
        return Size > russianDolls.Size;
    }
}