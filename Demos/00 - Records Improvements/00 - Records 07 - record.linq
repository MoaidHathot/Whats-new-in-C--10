<Query Kind="Program">
  <RuntimeVersion>5.0</RuntimeVersion>
</Query>

void Main()
{
	var bilbo = new Hobbit { FirstName = "Bilbo", LastName = "Baggins" };
	var frodo = new Hobbit { FirstName = "Frodo", LastName = "Baggins" };
	var frodo2 = new Hobbit { FirstName = "Frodo", LastName = "Baggins" };

	var set = new HashSet<Hobbit>();

	set.Add(bilbo);
	set.Add(frodo);

	bilbo.Equals(frodo);

	frodo.ToString().Dump();
	
	(frodo2 == frodo).Dump();
}


public record Hobbit
{
	public string? FirstName { get; init; }
	public string? LastName { get; init; }
}


