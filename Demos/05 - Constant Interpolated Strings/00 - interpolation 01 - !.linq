<Query Kind="Program" />

void Main()
{
	const string Prefix = "https://";
	const string Suffix = ".domain.com";

	const string globalSrvice = Prefix + "dotnetconf" + Suffix;

	const string localService = $"{Prefix}dotnetconf-israel{Suffix}";
}