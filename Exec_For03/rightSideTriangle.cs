using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exec_For03
{
	internal class rightSideTriangle
	{
		static void Main(string[] args)
		{
			for (int i = 0; i <= 5; i++)
			{
				int a = i;
				int b = 5 - i;
				string star = new string('*', a);
				string space = new string(' ', b);
				Console.WriteLine(space + star);
			}
		}
	}
}
