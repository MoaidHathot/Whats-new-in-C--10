<Query Kind="Program">
  <Namespace>System.Runtime.CompilerServices</Namespace>
</Query>

void Main()
{
	var merry = new Hobbit("Meriadoc", "Brandybuck");
	var pippin = new Hobbit("Peregrin", "Took");
	Hobbit gollum = null;
	
	GetHobbitNickname(merry.FirstName).Dump();
	GetHobbitNickname(pippin.FirstName).Dump();
	GetHobbitNickname(gollum?.FirstName).Dump();
}

string GetHobbitNickname(string? name)
{
	return name switch
	{
		"Peregrin" => "Pippin",
		"Meriadoc" => "Merry",
		null => throw new ArgumentNullException(nameof(name))
	};
}

record Hobbit(string FirstName, string LastName);