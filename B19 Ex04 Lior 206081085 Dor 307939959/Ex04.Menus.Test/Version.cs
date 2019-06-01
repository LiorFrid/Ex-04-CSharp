﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ex04.Menus.Interfaces;

namespace Ex04.Menus.Test
{
	public class Version : IMethodInvoker
	{
		public static void PrintVersion()
		{
			System.Console.WriteLine("Version: 19.2.4.32");
		}

		public void invoke()
		{
			PrintVersion();
		}
	}
}
