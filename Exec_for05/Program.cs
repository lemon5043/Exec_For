using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exec_for05
{
	internal class Program
	{
		static void Main(string[] args)
		{
			for (int i = 1; i <= 5; i++)
			{
				int a = 5 - i;
				//ASCII系統下的 1 - 9 為十進位制的49 - 57
				int b = i;
				char c = Convert.ToChar(i + 48);
				int limit = 4;
				if (b > limit)
				{
					b = limit;
				}
				string plus = new string('+', a);
				string number = new string(c, b);
				Console.WriteLine(plus + number);
			}
		}

	}
}
