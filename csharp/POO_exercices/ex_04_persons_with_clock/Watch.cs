namespace ex_04_persons_with_clock;

public class Watch
{
    public const int HOW_MANY_HOURS_IN_DAY = 24;
    public const int HOW_MANY_MINUTES_IN_HOURS = 60;
    private int _currentMinutesOfDay;
    private Person? _wearBy;

    public Watch(int initialHours, int initialMinutes)
    {
        CurrentMinutesOfDay = initialMinutes + initialHours * HOW_MANY_MINUTES_IN_HOURS;
        _wearBy = null;
        AutomaticallyIncrementMinutes();
    }

    public Watch(Watch anExistingWatch)
    {
        CurrentMinutesOfDay = anExistingWatch.CurrentMinutesOfDay;
        
        _wearBy = null;
    }

    public void IncrementOneMinute()
    {
        Console.WriteLine("test");
        CurrentMinutesOfDay++;
    }

    public int GetHours()
    {
        return (CurrentMinutesOfDay - GetMinutes()) / HOW_MANY_MINUTES_IN_HOURS;
    }

    public int GetMinutes()
    {
        return CurrentMinutesOfDay % HOW_MANY_MINUTES_IN_HOURS;
    }

    public Person? GetWearBy()
    {
        return _wearBy;
    }

    public string GetTime()
    {
        return $"{GetHours()}H {GetMinutes()}m";
    }

    private void SetWearBy(Person person)
    {
        _wearBy = person;
    }

    private void RemoveWearFromPerson()
    {
        _wearBy = null;
    }

    public int CurrentMinutesOfDay
    {
        get => _currentMinutesOfDay;
        set
        {
            while (_currentMinutesOfDay >= MaxMinutesInDay())
            {
                _currentMinutesOfDay -= MaxMinutesInDay();
            }
            _currentMinutesOfDay = value;
        }
    }

    private void AutomaticallyIncrementMinutes()
    {
        Task
            .Run(IncrementOneMinute)
            .Wait(TimeSpan.FromMinutes(1));
    }

    private int MaxMinutesInDay()
    {
        return HOW_MANY_MINUTES_IN_HOURS * HOW_MANY_HOURS_IN_DAY;
    }
}