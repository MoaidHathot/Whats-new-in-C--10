<Query Kind="Program" />

void Main()
{
	var gandalf = new Wizard("Mithrandir", "Whtie");

	if (gandalf is { Name: { Length: > 3 } name })
	{
		"The length larger than 3".Dump();
	}
}

public record Wizard(string Name, string Color);