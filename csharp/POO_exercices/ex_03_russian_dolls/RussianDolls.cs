namespace ex_03_russian_dolls;

public class RussianDolls
{
    private RussianDolls? _inRussianDolls;
    private RussianDolls? _containDolls;

    public RussianDolls(byte size)
    {
        Size = size;
        IsOpen = false;
        _inRussianDolls = null;
        _containDolls = null;
    }

    public bool IsOpen { get; private set; }

    public byte Size { get; init; }

    public void Open()
    {
        if (IsOpen)
        {
            throw new ApplicationException(
                "This Russian doll is already open.");
        }

        if (IsInRussianDools())
        {
            throw new ApplicationException(
                "You can't open this Russian doll because it is inside an other one.");
        }

        IsOpen = true;
    }

    public void Close()
    {
        if (!IsOpen)
        {
            throw new ApplicationException(
                "This Russian doll is already close.");
        }
        
        if (IsInRussianDools())
        {
            throw new ApplicationException(
                "You can't close this Russian doll because it is inside an other one.");
        }

        IsOpen = false;
    }

    public void PutIn(RussianDolls russianDolls)
    {
        if (IsOpen)
        {
            throw new ApplicationException(
                "You have to close this Russian doll before to put in an other.");
        }

        if (IsInRussianDools())
        {
            throw new ApplicationException(
                "This Russian doll is already in an other Russian doll.");
        }

        if (!russianDolls.IsOpen)
        {
            throw new ApplicationException(
                "The other Russian doll has to be open to put this Russian doll inside it.");
        }

        if (!(russianDolls.HasRussianDools()))
        {
            throw new ApplicationException(
                "The other Russian doll has already an other Russian doll inside it.");
        }
        
        if (IsSmallerThanRussianDools(russianDolls))
        {
            throw new ApplicationException(
                "The other Russian doll is smaller than this one.");
        }

        _inRussianDolls = russianDolls;
        russianDolls._containDolls = this;
    }

    public void GetOutOf(RussianDolls russianDolls)
    {
        if (!(_inRussianDolls == russianDolls))
        {
            throw new ApplicationException(
                "This Russian doll is not inside the other Russian doll.");
        }

        if (!_inRussianDolls.IsOpen)
        {
            throw new ApplicationException(
                "You have to open the other Russian doll to get out this.");
        }

        _inRussianDolls = null;
        russianDolls._containDolls = null;
    }

    public bool IsInRussianDools()
    {
        return _inRussianDolls is not null;
    }

    public bool HasRussianDools()
    {
        return _inRussianDolls is not null;
    }

    private bool IsSmallerThanRussianDools(RussianDolls russianDolls)
    {
        return Size > russianDolls.Size;
    }
}