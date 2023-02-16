namespace LeetCodeTasks;

public abstract class Abstraction
{
	public Abstraction(string name)
	{
		Name = name;
	}

    public Abstraction()
    {}

    public abstract string Name { get; set; }

	public void Move() 
	{
        Console.WriteLine("Abstraction is moving.");
    }

	public virtual void Speak(string message)
	{
		Console.WriteLine(message);
	}
}

public class AbstractionChild : Abstraction
{
	public AbstractionChild()
	{
		Name = string.Empty;
	}
    public override string Name { get; set;}
	public void Move()
	{
		Console.WriteLine("Child is moving.");
	}

    public override void Speak(string message)
    {
        Console.WriteLine(message);
    }
}

public interface IPlyaing
{
	void Play();
}

public class Player : IPlyaing
{
    public void Play()
    {
        throw new NotImplementedException();
    }
}


