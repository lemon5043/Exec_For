using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exec_For02
{
	internal class isoscelesTriangle
	{
		static void Main(string[] args)
		{
			//等腰三角形
			for (int i = 0; i < 4; i++)
			{
				int a = 1 + 2 * i;
				int b = 3 - i;
				string star = new string('*', a);
				string space = new string(' ', b);
				Console.WriteLine(space + star);
			}
		}
	}
}
