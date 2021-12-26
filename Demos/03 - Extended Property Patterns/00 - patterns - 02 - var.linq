<Query Kind="Program" />

void Main()
{
	string wizard = "Mithrandir"

	if (wizard is { Length: var length })
	{
		$"The wizard has a name with length {length}".Dump();
	}
}