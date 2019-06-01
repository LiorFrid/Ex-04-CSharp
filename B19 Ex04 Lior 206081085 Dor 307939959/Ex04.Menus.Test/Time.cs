﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ex04.Menus.Interfaces;

namespace Ex04.Menus.Test
{
	public class Time : IMethodInvoker
	{
		public static void ShowTime()
		{
			DateTime today = new DateTime();
			today = DateTime.Now;
			System.Console.WriteLine(today.ToShortTimeString());
		}

		public void invoke()
		{
			ShowTime();
		}
	}
}
