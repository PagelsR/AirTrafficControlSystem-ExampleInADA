using System;
using System.Threading;

public class Program
{
    public static void Main()
    {
        var runway1 = new Runway();
        var controller1 = new Controller(runway1);
        // Instantiate airplanes and assign them to the controller
    }
}

public class Airplane
{
    public int ID { get; private set; }

    public Airplane(int id)
    {
        ID = id;
    }
}

/// <summary>
/// Represents a runway in an air traffic control system.
/// </summary>
public class Runway
{
    private bool clear = true;
    private object lockObject = new object();

    /// <summary>
    /// Assigns an aircraft to the runway.
    /// </summary>
    /// <param name="id">The ID of the aircraft.</param>
    public void AssignAircraft(int id)
    {
        lock (lockObject)
        {
            while (!clear)
            {
                Monitor.Wait(lockObject);
            }
            clear = false;
            Console.WriteLine($"{id} on runway");
        }
    }

    /// <summary>
    /// Notifies that the runway is cleared for the specified aircraft.
    /// </summary>
    /// <param name="id">The ID of the aircraft.</param>
    public void ClearedRunway(int id)
    {
        lock (lockObject)
        {
            clear = true;
            Monitor.PulseAll(lockObject);
        }
    }

    /// <summary>
    /// Waits until the runway is clear.
    /// </summary>
    public void WaitForClear()
    {
        lock (lockObject)
        {
            while (!clear)
            {
                Monitor.Wait(lockObject);
            }
        }
    }
}

public class Controller
{
    private Runway runway;

    public Controller(Runway myRunway)
    {
        runway = myRunway;
    }

    public void RequestTakeoff(int id)
    {
        runway.AssignAircraft(id);
    }

    public void RequestApproach(int id)
    {
        runway.WaitForClear();
        runway.AssignAircraft(id);
    }
}