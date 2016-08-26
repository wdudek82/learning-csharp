using System;

namespace Project_1
{
	class MainClass
	{
		// First attemt to use recursion in C#
		static int gauss(int num) {
			if (num < 1) {
				return 0;
			} else if (num == 1) {
				return 1;
			} else {
				return gauss(num - 1) + num;
			}
		}


		/* Testing...
		Testing... */
		static void greet(string name) {
			Console.WriteLine("Hello {0}!", name);
		}

		public static void Main (string[] args)
		{
			Console.WriteLine ("Hello World!");

			Console.WriteLine ("Type a name: ");
			string name = Console.ReadLine();
			greet(name);

			Console.WriteLine ("Type a number: ");
			int num = Convert.ToInt32(Console.ReadLine());
			int gauss_sum = gauss(num);
			Console.WriteLine ("Gauss sum of {0} is {1}", num, gauss_sum);

			Console.WriteLine ("\n\n\n");

			// playing with for-loops
			for(int i = 0; i < 1000; i++) {
				if (i % 3 == 0) {
					Console.Write("{0} ", i);
				}
			}
		}
	}
}
