using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Ex04.Menus.Interfaces
{
	public class MenuInterface
	{
		private Stack<MenuItemInterface> m_StackOfMenus = new Stack<MenuItemInterface>();
		private MenuItemInterface m_MainMenu;
		public MenuInterface(int i_NumOfOptions)
		{
			m_MainMenu = new MenuItemInterface(i_NumOfOptions, 0);
			m_StackOfMenus.Push(m_MainMenu);
		}
		public void Show()
		{
			bool finishLoop = false;
			int input = 0;
			while (!finishLoop)
			{
				Console.Clear();
				if (m_StackOfMenus.Peek().SubMenu == null)
				{
					m_StackOfMenus.Pop().ShowMenu();
					input = numOfOptionOfUser(0);
				}
				else
				{
					m_StackOfMenus.Peek().ShowMenu();
					input = numOfOptionOfUser(m_StackOfMenus.Peek().SubMenu.Length);
					if (input == 0)
					{
						if (m_StackOfMenus.Peek().Level == 0)
							finishLoop = true;
						else
							m_StackOfMenus.Pop();
					}
					else
					{
						m_StackOfMenus.Push(m_StackOfMenus.Peek().SubMenu[input - 1]);
					}
				}
			}
		}
		private int numOfOptionOfUser(int i_Options)
		{
			int userInput = 0;
			bool isValid = false;
			while (!isValid)
			{
				try
				{
					userInput = getInputFromUser(i_Options);
					isValid = true;
				}
				catch (Exception ex)
				{
					Console.WriteLine(ex.Message);
				}
			}
			return userInput;
		}
		private int getInputFromUser(int i_Options)
		{
			int userInputInt = 0;
			string userInput;
			bool valid;
			Console.WriteLine("please enter your choice: ");
			userInput = Console.ReadLine();
			valid = int.TryParse(userInput, out userInputInt);
			if (!valid)
			{
				throw new Exception("Invalid choice");
			}
			valid = userInputInt < 0 || userInputInt > i_Options;
			if (valid)
			{
				throw new Exception("Out of range");
			}
			return userInputInt;

		}
		public MenuItemInterface MainMenu
		{
			get
			{
				return m_MainMenu;
			}
		}
	}
}
