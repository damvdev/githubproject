using System;
namespace Activities
{
	public class Program
	{
		public static int SumaIt(int n)
		{
			int num = 0;
			for (int i = 0; i <= n; i++)
			{
				num += i;
			}
			return num;
		}

		public static int SumaRec(int n)
		{
			if (n == 0) return 0;
			return n + SumaRec(n - 1);
		}
		public static void Main()
		{
			//Exemples suma iterativa i recursiva
			Console.WriteLine(SumaIt(4));
			Console.WriteLine(SumaRec(4));
		}
	}
}