<Query Kind="Program" />

void Main()
{
	string wizard = "Mithrandir"

	if (wizard is { Length: > 3 })
	{
		"The length larger than 3".Dump();
	}
}