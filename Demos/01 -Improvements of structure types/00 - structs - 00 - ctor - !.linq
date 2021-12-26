<Query Kind="Program" />

void Main()
{
	var peregrin = new Hobbit { FirstName = "Peregrin", LastName = "Took" };
}

public struct Hobbit
{
	public string? FirstName { get; init; }
	public string? LastName { get; init; }
	
	//Constructor
	public Hobbit()
	{
		FirstName = "Tom";
		LastName = "Bombadil";
	}
}
