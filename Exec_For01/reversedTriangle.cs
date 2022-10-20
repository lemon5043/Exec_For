using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1014HW
{
	internal class reversedTriangle
	{
		static void Main(string[] args)
		{
			for (int i = 5; i > 0; i--)
			{
				string star =new string('*', i);
				Console.WriteLine(star);
			}
		}
	}
}
