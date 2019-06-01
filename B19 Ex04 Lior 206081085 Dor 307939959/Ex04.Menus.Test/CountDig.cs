using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ex04.Menus.Interfaces;
namespace Ex04.Menus.Test
{
	public class CountDig : MethodInvoker
	{
		public void invoke()
		{
			DigCount();
		}
		public static void DigCount()
		{
			Console.WriteLine("please enter a string");
			string userInput = Console.ReadLine();
			int counter = 0;
			foreach (char ch in userInput)
			{
				if (char.IsDigit(ch))
				{
					counter++;
				}
			}
			Console.WriteLine("There are {0} digit in your string", counter);
		}
	}
}
