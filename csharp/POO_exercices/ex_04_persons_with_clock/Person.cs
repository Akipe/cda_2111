namespace ex_04_persons_with_clock;

public class Person
{
    public Person(string name)
     {
         Name = name;
         Watch = null;
         IsMakingChangeOnWatch = false;
     }

     public string Name { get; init; }
     
     public Watch? Watch
     {
         get;
         set;
     }

     private bool IsMakingChangeOnWatch { get; set; }

     public bool HasWatch()
     {
         return Watch is not null;
     }

     public void WearWatch(Watch watch)
     {
         if (!IsMakingChangeOnWatch)
         {
             if (HasWatch())
                 throw new ApplicationException($"{Name} wear already a watch.");

             if (watch.GetWearBy() is not null)
                 throw new ApplicationException("The wear is already wear.");

             IsMakingChangeOnWatch = true;
             watch.SetWearBy(this);
         }
         else
         {
             Watch = watch;
             IsMakingChangeOnWatch = false;
         }
     }

     public void RemoveWatch()
     {
         if (!IsMakingChangeOnWatch)
         {
             if (Watch is null)
                 throw new ApplicationException("You do not have a watch");

             IsMakingChangeOnWatch = true;
             Watch.RemoveWearBy();
         }
         else
         {
             Watch = null;
             IsMakingChangeOnWatch = false;
         }
     }

     public string AskTime(Person person)
     {
         if (person == this)
             throw new ApplicationException("You can't ask yourself the time");
         
         if (!person.HasWatch())
             throw new ApplicationException($"{person.Name} has not clock");
         
         return person.GiveTime();
     }

     public string GiveTime()
     {
         if (Watch is null)
             throw new ApplicationException("You do not have watch");
         
         return Watch.GetTime();
     }

     public void GiveWatchTo(Person person)
     {
         Watch tempWatchStorage;
         
         if (person == this)
             throw new ApplicationException("You can't give yourself a watch");
         
         if (Watch is null)
             throw new ApplicationException("You do not have a watch to give");

         if (person.HasWatch())
             throw new ApplicationException($"{person.Name} has already a watch");

         tempWatchStorage = Watch;
         RemoveWatch();
         person.WearWatch(tempWatchStorage);
     }
}