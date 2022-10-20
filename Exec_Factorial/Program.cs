using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exec_Factorial
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//階乘定義 小於等於該數的正整數的積，ex: 5!=1*2*3*4*5
			int result = 1;
			for (int i = 1; i <= 5; i++)
			{
				result *= i;
			}
			Console.WriteLine(result);
		}
	}
}
