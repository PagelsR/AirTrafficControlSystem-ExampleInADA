using System;
using System.Threading;

public class Program
{
    public static void Main()
    {
        Runway runway1 = new Runway();
        Controller controller1 = new Controller(runway1);
        controller1.Start();
    }
}

public class Runway
{
    public bool IsClear { get; private set; } = true;

    public void AssignAircraft(int id)
    {
        lock (this)
        {
            while (!IsClear)
            {
                Monitor.Wait(this);
            }

            IsClear = false;
            Console.WriteLine($"Airplane {id} on runway");
        }
    }

    public void ClearedRunway(int id)
    {
        lock (this)
        {
            IsClear = true;
            Console.WriteLine($"Airplane {id} cleared runway");
            Monitor.PulseAll(this);
        }
    }
}

public class Controller
{
    private Runway runway;

    public Controller(Runway runway)
    {
        this.runway = runway;
    }

    public void Start()
    {
        for (int i = 1; i <= 10; i++)
        {
            int id = i;
            Thread airplaneThread = new Thread(() => Airplane(id));
            airplaneThread.Start();
        }
    }

    private void Airplane(int id)
    {
        runway.AssignAircraft(id);

        // Simulate the airplane taking off or landing
        Thread.Sleep(1000);

        runway.ClearedRunway(id);
    }
}