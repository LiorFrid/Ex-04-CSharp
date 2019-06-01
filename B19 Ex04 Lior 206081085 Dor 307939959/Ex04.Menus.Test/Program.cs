using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ex04.Menus.Interfaces;
namespace Ex04.Menus.Test
{
	public class Program
	{
		public static void Main()
		{
			MenuInterface menu = new MenuInterface(2);
			menu.MainMenu.Text = "Main";
			menu.MainMenu.SubMenu[0] = new MenuItemInterface(2, 1);
			menu.MainMenu.SubMenu[0].Text = "Show Date/ Time";
			menu.MainMenu.SubMenu[0].SubMenu[0] = new MenuItemInterface(0, 2);
			menu.MainMenu.SubMenu[0].SubMenu[0].Text = "Show Time";
			menu.MainMenu.SubMenu[0].SubMenu[0].Invoker = new Time();
			menu.MainMenu.SubMenu[0].SubMenu[1] = new MenuItemInterface(0, 2);
			menu.MainMenu.SubMenu[0].SubMenu[1].Text = "Show Date";
			menu.MainMenu.SubMenu[0].SubMenu[1].Invoker = new Date();
		
			menu.MainMenu.SubMenu[1] = new MenuItemInterface(2, 1);
			menu.MainMenu.SubMenu[1].Text = "Version/ Count digits";
			menu.MainMenu.SubMenu[1].SubMenu[0] = new MenuItemInterface(0, 2);
			menu.MainMenu.SubMenu[1].SubMenu[0].Text = "Version";
			menu.MainMenu.SubMenu[1].SubMenu[0].Invoker = new Version();
			menu.MainMenu.SubMenu[1].SubMenu[1] = new MenuItemInterface(0, 2);
			menu.MainMenu.SubMenu[1].SubMenu[1].Text = "Count Digits";
			menu.MainMenu.SubMenu[1].SubMenu[1].Invoker = new CountDig();
			menu.Show();


		}
	}
}
