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

		public static int PowIt(int n, int m)
		{
			int num = 1;
			for (int i = 0; i < m; i++)
			{
				num *= n;
			}
			return num;
		}
		public static int PowRec(int n, int m)
		{
			if (m == 0) return 1;
			return n * PowRec(n, m - 1);
		}

		public static int FactorialIt(int n)
		{
			int num = 1;
			for (int i = 1; i <= n; i++)
			{
				num *= i;
			}
			return num;
		}
		public static int FactorialRec(int n)
		{
			if (n == 0) return 1;
			return n * FactorialRec(n - 1);
		}

		public static void Main()
		{
			//Exemples suma iterativa i recursiva
			Console.WriteLine(SumaIt(4));
			Console.WriteLine(SumaRec(4));
			//Exemples potencia iterativa i recursiva
			Console.WriteLine(PowIt(2, 3));
			Console.WriteLine(PowRec(2, 3));
			//Exemples factorial iteratiu i recursiu
			Console.WriteLine(FactorialIt(4));
			Console.WriteLine(FactorialRec(4));
		}
	}
}