<Query Kind="Program" />

void Main()
{
	var moaid = new Person("Moaid", "Hathot");
	var msftMoaid = new Dev("Moaid", "Hathot", ".NET");
	
	moaid.ToString().Dump();
	msftMoaid.ToString().Dump();
}

public record Person(string FirstName, string LastName)
{
	public sealed override string ToString()
		=> $"{FirstName} {LastName}";
}

public record Dev(string FirstName, string LastName, string Stack) : Person(FirstName, LastName);