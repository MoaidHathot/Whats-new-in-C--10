<Query Kind="Program" />

void Main()
{
	var func = () => DateTime.Now.Day > 21 ? new A() : new B();
}

interface I
{
	
}

class A : I
{
	
}

class B : I
{
	
}

