using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04.Menus.Interfaces
{
	public class MenuItemInterface
	{
		private string m_Text;
		private int m_Level;
		private MenuItemInterface[] m_SubMenu;
		private IMethodInvoker m_Method;

		public MenuItemInterface(int i_NumOfItems, int i_Level)
		{
			if (i_NumOfItems == 0)
			{
				m_SubMenu = null;
			}
			else
			{
				m_SubMenu = new MenuItemInterface[i_NumOfItems];
			}

			m_Level = i_Level;
		}

		public int Level
		{
			get
			{
				return m_Level;
			}
		}

		public string Text
		{
			get
			{
				return m_Text;
			}

			set
			{
				m_Text = value;
			}
		}

		public MenuItemInterface[] SubMenu
		{
			get
			{
				return m_SubMenu;
			}
		}

		public void ShowMenu()
		{
			if (m_SubMenu == null)
			{
				invoke();
			}
			else
			{
				int index = 1;
				Console.WriteLine(m_Text);
				foreach (MenuItemInterface i in SubMenu)
				{
					Console.WriteLine("{0}. {1}", index, i.m_Text);
					index++;
				}

				Console.WriteLine();
				if (m_Level == 0)
				{
					Console.WriteLine("0. Exit");
				}
				else
				{
					Console.WriteLine("0. Back");
				}
			}
		}

		private void invoke()
		{
			m_Method.invoke();
			Console.WriteLine();
			Console.WriteLine("0. Back");
		}

		public IMethodInvoker Invoker
		{
			get
			{
				return m_Method;
			}

			set
			{
				m_Method = value;
			}
		}
	}
}
