// See https://aka.ms/new-console-template for more information

using ex_04_persons_with_clock;

Watch w1 = new Watch(2, 20);

int seconds = 0;

do
{
    Thread.Sleep(1000);
    seconds++;
    Console.WriteLine($"S: {seconds}; M: {w1.CurrentMinutesOfDay}");
    seconds = seconds == 60 ? 0 : seconds;
} while (true);