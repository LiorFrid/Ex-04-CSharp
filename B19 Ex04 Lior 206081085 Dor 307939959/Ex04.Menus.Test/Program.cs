using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ex04.Menus.Interfaces;
using Ex04.Menus.Delegates;

namespace Ex04.Menus.Test
{
	public class Program
	{
		public static void Main()
		{
			Console.WriteLine("Interface Menu, Press any key to Continue:");
			Console.ReadLine();

			MenuInterface interfaceMenu = new MenuInterface(2);
			interfaceMenu.MainMenu.Text = "Main";
			interfaceMenu.MainMenu.SubMenu[0] = new MenuItemInterface(2, 1);
			interfaceMenu.MainMenu.SubMenu[0].Text = "Show Date/ Time";
			interfaceMenu.MainMenu.SubMenu[0].SubMenu[0] = new MenuItemInterface(0, 2);
			interfaceMenu.MainMenu.SubMenu[0].SubMenu[0].Text = "Show Time";
			interfaceMenu.MainMenu.SubMenu[0].SubMenu[0].Invoker = new Time();
			interfaceMenu.MainMenu.SubMenu[0].SubMenu[1] = new MenuItemInterface(0, 2);
			interfaceMenu.MainMenu.SubMenu[0].SubMenu[1].Text = "Show Date";
			interfaceMenu.MainMenu.SubMenu[0].SubMenu[1].Invoker = new Date();
		
			interfaceMenu.MainMenu.SubMenu[1] = new MenuItemInterface(2, 1);
			interfaceMenu.MainMenu.SubMenu[1].Text = "Version/ Count digits";
			interfaceMenu.MainMenu.SubMenu[1].SubMenu[0] = new MenuItemInterface(0, 2);
			interfaceMenu.MainMenu.SubMenu[1].SubMenu[0].Text = "Version";
			interfaceMenu.MainMenu.SubMenu[1].SubMenu[0].Invoker = new Version();
			interfaceMenu.MainMenu.SubMenu[1].SubMenu[1] = new MenuItemInterface(0, 2);
			interfaceMenu.MainMenu.SubMenu[1].SubMenu[1].Text = "Count Digits";
			interfaceMenu.MainMenu.SubMenu[1].SubMenu[1].Invoker = new CountDig();
			interfaceMenu.Show();

			Console.Clear();
			Console.WriteLine("Delegate Menu, Press any key to Continue:");
			Console.ReadLine();

			MenuDelegate delegateMenu = new MenuDelegate(2);
			delegateMenu.MainMenu.Text = "Main";
			delegateMenu.MainMenu.SubMenu[0] = new MenuItemDelegate(2, 1);
			delegateMenu.MainMenu.SubMenu[0].Text = "Show Date/ Time";
			delegateMenu.MainMenu.SubMenu[0].SubMenu[0] = new MenuItemDelegate(0, 2);
			delegateMenu.MainMenu.SubMenu[0].SubMenu[0].Text = "Show Time";
			delegateMenu.MainMenu.SubMenu[0].SubMenu[0].Choosed += Time.ShowTime;
			delegateMenu.MainMenu.SubMenu[0].SubMenu[1] = new MenuItemDelegate(0, 2);
			delegateMenu.MainMenu.SubMenu[0].SubMenu[1].Text = "Show Date";
			delegateMenu.MainMenu.SubMenu[0].SubMenu[1].Choosed += Date.ShowDate;

			delegateMenu.MainMenu.SubMenu[1] = new MenuItemDelegate(2, 1);
			delegateMenu.MainMenu.SubMenu[1].Text = "Version/ Count digits";
			delegateMenu.MainMenu.SubMenu[1].SubMenu[0] = new MenuItemDelegate(0, 2);
			delegateMenu.MainMenu.SubMenu[1].SubMenu[0].Text = "Version";
			delegateMenu.MainMenu.SubMenu[1].SubMenu[0].Choosed += Version.PrintVersion;
			delegateMenu.MainMenu.SubMenu[1].SubMenu[1] = new MenuItemDelegate(0, 2);
			delegateMenu.MainMenu.SubMenu[1].SubMenu[1].Text = "Count Digits";
			delegateMenu.MainMenu.SubMenu[1].SubMenu[1].Choosed += CountDig.DigCount;
			delegateMenu.Show();

			Console.Clear();
			Console.WriteLine("Bye Bye");





		}
	}
}
