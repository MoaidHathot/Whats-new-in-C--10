<Query Kind="Program" />

void Main()
{
	var bilbo = new Hobbit ("Bilbo", "Baggins" );
	var frodo = new Hobbit ("Frodo", "Baggins" );
	var frodo2 = new Hobbit ("Frodo", "Baggins" );

	var set = new HashSet<Hobbit>();

	set.Add(bilbo);
	set.Add(frodo);

	bilbo.Equals(frodo);

	frodo.ToString().Dump();
	
	(frodo2 == frodo).Dump();
	
	var (fristName, lastName) = frodo;
}


public record Hobbit(string FirstName, string LastName);