<Query Kind="Program" />

void Main()
{
	var moaid = new Person("Moaid", "Hathot");
	var wifu = moaid with { FirstName = "Haneeni" };
}


public record Person(string FirstName, string LastName);