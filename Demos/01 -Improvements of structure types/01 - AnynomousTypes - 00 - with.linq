<Query Kind="Program" />

void Main()
{
	var aragorn = new { Name = "Aragorn", Nickname = "Strider", Parent = "Arathorn II" };
	var elessar = aragorn with { Name = "Elessar"}
}

