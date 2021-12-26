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
	
	frodo.ToString().Dump();
}

public class Hobbit : IEquatable<Hobbit>
{
	public string? FirstName { get; init; }
	public string? LastName { get; init; }

	public override bool Equals(object? obj)
		=> Equals(obj as Hobbit);

	public override int GetHashCode()
		=> HashCode.Combine(FirstName, LastName);

	public bool Equals(Hobbit? other)
		=> other is { } && (FirstName, LastName) == (other.FirstName, other.LastName);

	public override string ToString()
		=> $"Person {{ FirstName: '{FirstName}', LastName: '{LastName}' }}";
}

