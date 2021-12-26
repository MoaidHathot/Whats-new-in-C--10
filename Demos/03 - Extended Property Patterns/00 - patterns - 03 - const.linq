<Query Kind="Program" />

void Main()
{
	string wizard = "Mithrandir"

	if (wizard is { Length: 10 })
	{
		"The length is 10".Dump();
	}
}