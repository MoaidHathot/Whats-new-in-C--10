<Query Kind="Program" />

void Main()
{
	var narya = new RingOfPower("Narya", "Ring of Fire");
	var nenya = new RingOfPower("Nenya", "Ring of water");
	
	var ruling = new RingOfPower("Ruling Ring", "Precious");
	
	var (name, title) = ruling;
}

public record RingOfPower(string Name, string Title);