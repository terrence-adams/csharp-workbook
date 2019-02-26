using System;
using System.Collections.Generic;

/// <summary>
/// Using an interface called IActivity a.k.a contract so that we can use it as a type instead of a concrete class type
/// </summary>
public class Program
{
    // Fields
    static Engine _engine;
    static Workflow _workflow;

    // Properties
    // n/a

    // Constructor(s)
    static Program()
    {
        _engine = new Engine();
        _workflow = new Workflow();
    }

    // Methods
    public static void Main()
    {
        _engine.Run(_workflow);
    }
}

public class Engine
{
    // Fields
    // n/a

    // Properties
    // n/a

    // Constructor(s)
    public Engine()
    {
        // not used
    }

    // Methods
    public void Run(Workflow workflow)
    {
        foreach (var activity in workflow.GetActivities())
        {
            activity.Execute();
        }
    }
}

public class Workflow
{
    // Fields
    List<IActivity> _activities;

    // Properties
    // n/a

    // Constructor
    public Workflow()
    {
        _activities = new List<IActivity>
        {
            { new SportActivity{Message = "Running..." } },
            { new SportActivity{Message = "Batting..." } },
            { new SportActivity{Message = "Kicking..." } },
            { new SportActivity{Message = "Dribbling..." } },
            { new OutdoorActivity{Message = "Fishing..." } },
            { new OutdoorActivity{Message = "Camping..." } },
            { new OutdoorActivity{Message = "Grilling..." } },
            {new WeightLiftingActivity{Message = "Powerlifting..."}}
        };
    }

    // Methods
    public List<IActivity> GetActivities()
    {
        return _activities;
    }
}

public class SportActivity : IActivity
{
    // Fields
    // n/a

    // Properties
    public string Message { get; set; }

    // Constructor(s)
    public SportActivity()
    {
        // not used
    }

    // Methods
    public void Execute()
    {
        Console.WriteLine("Performing Sport Activity: {0}", Message);
    }
}

public class OutdoorActivity : IActivity
{
    public string Message { get; set; }

    public void Execute()
    {
        Console.WriteLine("Performing Outdoor Activity: {0}", Message);
    }
}

public class WeightLiftingActivity:ActivityBase,IActivity 
{
    public string Message{
        get
        {
            return "I am lifting weights!";

        }
        set
        {
            ;
        }
    }

    public void Execute()
    {
        Console.WriteLine(Message);

    }

    override public void endActivity()
    {

        Console.WriteLine("My workout is over!");
    }


}

//Here is an example of an interface
public interface IActivity
{
    // Properties
    string Message { get; set; }

    // Methods
    void Execute();
}

abstract public class ActivityBase
{

   abstract public void endActivity();
   public string endWorkout;


}