using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ex04.Menus.Interfaces;

namespace Ex04.Menus.Test
{
	public class Date : IMethodInvoker
	{
		#region Methods
		public static void ShowDate()
		{
			DateTime today = new DateTime();
			today = DateTime.Now;
			System.Console.WriteLine(today.ToShortDateString());
		}

		public void invoke()
		{
			ShowDate();
		}
		#endregion  Methods
	}
}
