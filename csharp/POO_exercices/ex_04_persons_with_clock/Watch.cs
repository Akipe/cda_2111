namespace ex_04_persons_with_clock;

public class Watch
{
    public const ushort HOW_MANY_HOURS_IN_DAY = 24;
    public const ushort HOW_MANY_MINUTES_IN_HOURS = 60;
    private ushort _currentMinutesOfDay;
    private Person? _wearBy;

    public Watch(ushort initialHours, ushort initialMinutes)
    {
    }

    public Watch(Watch anExistingWatch)
    {
    }

    public void IncrementOneMinute()
    {
    }

    public ushort GetHours()
    {
    }

    public ushort GetMinutes()
    {
    }

    public Person? GetWearBy()
    {
    }

    public string GetTime()
    {
    }

    private void SetWearBy(Person person)
    {
    }

    private void RemoveWearFromPerson()
    {
        
    }

    private ushort CurrentMinutesOfDay
    {
        get => _currentMinutesOfDay;
        set => _currentMinutesOfDay = value;
    }

    private void AutomaticallyIncrementMinutes()
    {
        
    }
}