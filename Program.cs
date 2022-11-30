using System;

public static class Globals
{
	internal static void Main()
	{
		Console.Write("Determinati daca numarul N este prim");
		Console.Write("\n");
		int n;

		Console.Write("N = ");
		n = Convert.ToInt32(Console.ReadLine());

		int radical = (int)Math.Sqrt(n);
		int numarDivizori = 0;
		for (int d = 1; d <= radical; d++)
		{
			if (n % d == 0)
			{ //Am găsit divizorul d, dar considerăm și perechea acestuia
				int dprim = n / d; //d' = n / d
				if (dprim != d)
				{
					numarDivizori += 2;
				}
				else
				{ //Dacă d' == d, atunci perechea lui d este el însuși, deci îl numărăm doar o dată
					numarDivizori++;
				}
			}
		}
		if (numarDivizori == 2)
		{
			Console.Write("DA");
		}
		else
		{
			Console.Write("NU");
		}
	}
}
