// See https://aka.ms/new-console-template for more information

using ex_04_persons_with_clock;

Watch w1;
Watch w2;
Watch w3;

Person p1;
Person p2;
Person p3;

w1 = new Watch(2, 20);

w1.IncrementOneMinute();
w1.IncrementOneMinute();
w1.IncrementOneMinute();
w1.IncrementOneMinute();
w1.IncrementOneMinute();

Console.WriteLine(w1.GetHours());
Console.WriteLine(w1.GetMinutes());
Console.WriteLine(w1.GetTime());

w2 = new Watch(50, 75);
Console.WriteLine(w2.GetTime());

w3 = new Watch(w1);

p1 = new Person("Toto");
p2 = new Person("Tata");
p3 = new Person("Titi");

p1.WearWatch(w1);
p2.WearWatch(w2);

p2.RemoveWatch();

p3.WearWatch(w2);

w2.RemoveWearBy();

p2.WearWatch(w2);

p2.GiveWatchTo(p3);

if (p3.Watch is not null)
{
    p3.Watch.IncrementOneMinute();
}
Console.WriteLine(p3.GiveTime());
Console.WriteLine(p2.AskTime(p3));
