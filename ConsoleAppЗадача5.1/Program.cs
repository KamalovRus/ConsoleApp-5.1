using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppЗадача5._1
{
    class Program
    {
        static void Main(string[] args)
        {
			int[] A = new int[7];
			double Sum = 0;
			for (int i = 0; i < 7; i++)
			{
				A[i] = Convert.ToInt32(Console.ReadLine().ToString());
				
				Sum += A[i];
			}
			Console.WriteLine("Ans = {0}", Sum / 7);
			Console.ReadKey();
		}

    }
}
