namespace ex_03_russian_dolls;

public class RussianDoll
{
    private RussianDoll? _inRussianDoll;
    private RussianDoll? _containDoll;

    public RussianDoll(byte size)
    {
        Size = size;
        IsOpen = false;
        _inRussianDoll = null;
        _containDoll = null;
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

        IsOpen = false;
    }

    public void PutIn(RussianDoll russianDoll)
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

        if (!russianDoll.IsOpen)
        {
            throw new ApplicationException(
                "The other Russian doll has to be open to put this Russian doll inside it.");
        }

        if (russianDoll.HasRussianDools())
        {
            throw new ApplicationException(
                "The other Russian doll has already an other Russian doll inside it.");
        }
        
        if (IsSmallerThanRussianDools(russianDoll))
        {
            throw new ApplicationException(
                "The other Russian doll is smaller than this one.");
        }

        _inRussianDoll = russianDoll;
        russianDoll._containDoll = this;
    }

    public void GetOutOf(RussianDoll russianDoll)
    {
        if (_inRussianDoll != russianDoll)
        {
            throw new ApplicationException(
                "This Russian doll is not inside the other Russian doll.");
        }

        if (!_inRussianDoll.IsOpen)
        {
            throw new ApplicationException(
                "You have to open the other Russian doll to get out this.");
        }

        _inRussianDoll = null;
        russianDoll._containDoll = null;
    }

    public bool IsInRussianDools()
    {
        return _inRussianDoll is not null;
    }

    public bool HasRussianDools()
    {
        return _containDoll is not null;
    }

    private bool IsSmallerThanRussianDools(RussianDoll russianDoll)
    {
        return Size > russianDoll.Size;
    }
}