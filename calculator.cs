class Calculator
{
	static void Main(string[]args)
	{
		int a=10;
		int b=6;
		
		Console.WriteLine("hasil {0} + {1} = {2}", a,b,penambahan(a,b));
		Console.WriteLine("hasil {0} - {1} = {2}",a,b,pengurangan(a,b));
		Console.WriteLine("hasil {0} x {1} = {2}", a,b,perkalian(a,b));
		Console.WriteLine("hasil {0} : {1} = {2}",a,b,pembagian(a,b));
		
		Console.WriteLine("\nTekan sembarang. . .");
		Console.ReadKey();
	}
	static int penambahan(int a, int b)
	{
		return a+b;
	}
	static int pengurangan(int a,int b)
	{
		return a-b;
	}
	static int perkalian(int a,int b)
	{
		return a*b;
	}
	static int pembagian(int a,int b)
	{
		return a/b;
	}
	
}