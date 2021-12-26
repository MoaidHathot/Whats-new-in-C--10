<Query Kind="Program">
  <RuntimeVersion>5.0</RuntimeVersion>
</Query>

void Main()
{
	var bilbo = new Hobbit { FirstName = "Bilbo", LastName = "Baggins" };
	var frodo = new Hobbit { FirstName = "Frodo", LastName = "Baggins" };
	
	var set = new HashSet<Hobbit>();
	
	set.Add(bilbo);
	set.Add(frodo);
	
	bilbo.Equals(frodo);
}

public class Hobbit
{
	public string? FirstName { get; init; }
	public string? LastName { get; init; }

	public override bool Equals(object? obj)
		=> obj is Hobbit other && string.Equals(FirstName, other.FirstName) && string.Equals(LastName, other.LastName);

	public override int GetHashCode()
		=> HashCode.Combine(FirstName, LastName);
}

