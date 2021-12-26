<Query Kind="Program" />

void Main()
{
	var moaid = new Person("Moaid", "Hathot");
	
	moaid.ToString().Dump();
}

public record Person(string FirstName, string LastName);