namespace ex_03_russian_dolls;

public class RussianDolls
{
    private bool _isOpen;
    private short _size;
    private RussianDolls? _inRussianDolls;
    private RussianDolls? _containDolls;

    public RussianDolls()
    {
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
    }

    public void Close()
    {
    }

    public void PutInt(RussianDolls russianDolls)
    {
    }

    public void GetOutOf(RussianDolls russianDolls)
    {
        
    }

    private bool IsInRussianDools()
    {
        
    }

    private bool HasRussianDools()
    {
        
    }
}