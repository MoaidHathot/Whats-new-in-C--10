<Query Kind="Program" />

void Main()
{
	var narya = new RingOfPower("Narya", "Ring of Fire");
	var nenya = new RingOfPower("Nenya", "Ring of water");
	
	var ruling = new RingOfPower("Ruling Ring", "Precious");
	
	var (name, title) = ruling;
}

//public record RingOfPower(string Name, string Title);

public class RingOfPower
{
	public string Name { get; }
	public string Title { get; }
	
	public RingOfPower(string name, string title)
		=> (Name, Title) = (name, title);
		
	//public void Deconstruct(out string name, out string title)
	//	=> (name, title) = (Name, Title);
}

public static class Extensions
{
	public static void Deconstruct(this RingOfPower ring, out string name, out string title)
		=> (name, title) = (ring.Name, ring.Title);
}
