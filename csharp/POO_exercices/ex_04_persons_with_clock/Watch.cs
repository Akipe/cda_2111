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
    }

    public Watch(Watch anExistingWatch)
    {
        CurrentMinutesOfDay = anExistingWatch.CurrentMinutesOfDay;
        _wearBy = null;
    }

    public void IncrementOneMinute()
    {
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

    public void SetWearBy(Person person)
    {
        if (person.HasWatch())
            throw new ApplicationException();
        if (_wearBy is not null)
            throw new ApplicationException();
        
        _wearBy = person;
        _wearBy.WearWatch(this);
    }
    
    public void RemoveWearBy()
    {
        if (_wearBy is null)
            throw new AggregateException();

        _wearBy.RemoveWatch();
        _wearBy = null;
    }

    private void RemoveWearFromPerson()
    {
        _wearBy = null;
    }

    private int CurrentMinutesOfDay
    {
        get => _currentMinutesOfDay;
        set
        {
            _currentMinutesOfDay = value;
            
            while (_currentMinutesOfDay >= MaxMinutesInDay())
            {
                _currentMinutesOfDay -= MaxMinutesInDay();
            }
        }
    }

    private int MaxMinutesInDay()
    {
        return HOW_MANY_MINUTES_IN_HOURS * HOW_MANY_HOURS_IN_DAY;
    }
}