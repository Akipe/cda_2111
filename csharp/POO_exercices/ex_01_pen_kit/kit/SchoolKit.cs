using ex_01_pen_kit.tool;

namespace ex_01_pen_kit.kit;

// TrousseScolaire
public class SchoolKit : Kit
{
    // private List<WriteTool> _stuff;

    public SchoolKit(int volume) : base(volume)
    {
        // _stuff = new List<WriteTool>();
    }

    public void AddStuff(WriteTool writeTool)
    {
        base.AddStuff(writeTool);
    }

    public bool HasStuff(WriteTool writeTool)
    {
        return base.HasStuff(writeTool);
    }
    
    public void RemoveStuff(WriteTool writeTool)
    {
        base.RemoveStuff(writeTool);
    }

    // public void AddStuff(WriteTool writeTool)
    // {
    //     if (_stuff.Count <= Volume - 1)
    //     {
    //         _stuff.Add(writeTool);
    //     }
    // }
    //
    // public void RemoveStuff(WriteTool writeTool)
    // {
    //     if (_stuff.Contains(writeTool))
    //     {
    //         _stuff.Remove(writeTool);
    //     }
    // }
    //
    // public bool IsFull()
    // {
    //     return _stuff.Count == Volume;
    // }
}