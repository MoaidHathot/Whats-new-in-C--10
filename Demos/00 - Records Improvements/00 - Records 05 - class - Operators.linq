<Query Kind="Program">
  <RuntimeVersion>5.0</RuntimeVersion>
</Query>

void Main()
{
	var bilbo = new Hobbit { FirstName = "Bilbo", LastName = "Baggins" };
	var frodo = new Hobbit { FirstName = "Frodo", LastName = "Baggins" };
	var frodo2 = new Hobbit { FirstName = "Frodo", LastName = "Baggins" };

	bilbo.Equals(frodo);
	
	(bilbo != frodo).Dump();
	(frodo == frodo2).Dump();
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

	public static bool operator ==(Hobbit first, Hobbit second)
		=> object.ReferenceEquals(first, second) || (first is { } && first.Equals(second));
		
	public static bool operator !=(Hobbit first, Hobbit second)
		=> !(first == second);
}

