namespace ex_01_pen_kit;

// Trousse
public abstract class Kit
{
    private int _volume;
    private bool _isOpen;
    private List<ITool> _tools;

    public Kit(int volume)
    {
        Volume = volume;
        IsOpen = false;
        _tools = new List<ITool>();
    }

    public int Volume
    {
        get => _volume;
        private set => _volume = value;
    }

    public void Open()
    {
        if (!IsOpen)
        {
            IsOpen = true;
        }
    }

    public void Close()
    {
        if (IsOpen)
        {
            IsOpen = false;
        }
    }
    
    public bool IsOpen
    {
        get => _isOpen;
        private set => _isOpen = value;
    }
    
    protected void AddStuff(ITool tool)
    {
        if (IsFull())
        {
            throw new ApplicationException("The kit is full");
        }

        if (_tools.Contains(tool))
        {
            throw new ApplicationException("The tool is already store in the kit");
        }
        
        if (!IsOpen)
        {
            throw new ApplicationException("The kit is close, open it before add a tool");
        }
        
        _tools.Add(tool);
    }

    protected bool HasStuff(ITool tool)
    {
        return _tools.Contains(tool);
    }

    protected void RemoveStuff(ITool tool)
    {
        if (!IsOpen)
        {
            throw new ApplicationException("The kit is close, open it before remove a tool");
        }

        if (!_tools.Contains(tool))
        {
            throw new ApplicationException("The tool can't be add to the kit");
        }
        
        _tools.Remove(tool);
    }

    public bool IsFull()
    {
        return _tools.Count == Volume;
    }
}