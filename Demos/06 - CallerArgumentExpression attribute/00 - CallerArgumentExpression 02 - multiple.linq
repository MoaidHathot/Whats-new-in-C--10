<Query Kind="Program">
  <Namespace>System.Runtime.CompilerServices</Namespace>
</Query>

void Main()
{
	var merry = new Hobbit("Meriadoc", "Brandybuck");
	var pippin = new Hobbit("Peregrin", "Took");
	var sam = new Hobbit("Samwise", "Gamgee");
	
	Hobbit gollum = null;
	
	AreFriends(null, gollum);
}

bool AreFriends(Hobbit? first, Hobbit? second, [CallerArgumentExpression("first")] string? firstExpression = null, [CallerArgumentExpression("second")] string? secondExpression = null)
{
	if(first is null)
	{
		throw new ArgumentNullException(firstExpression);
	}
	
	if(second is null)
	{
		throw new ArgumentNullException(secondExpression);
	}
	
	return true;
}

record Hobbit(string FirstName, string LastName);