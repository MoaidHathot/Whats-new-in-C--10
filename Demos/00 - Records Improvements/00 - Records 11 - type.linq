<Query Kind="Program" />

void Main()
{
	var moaid = new Person("Moaid", "Hathot");
	var wifu = moaid with { FirstName = "Haneeni" };
	
	var clone = moaid with { };
}


//What is the type of Person?
public record Person(string FirstName, string LastName);