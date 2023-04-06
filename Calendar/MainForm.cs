using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calendar
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
		}

		private void cbbType_SelectedIndexChanged(object sender, EventArgs e)
		{
			cbbTime.Items.Clear();
			if (cbbType.SelectedIndex == 0)
			{
				for(int i = 1; i <= 60; i++)
				{
					cbbTime.Items.Add(i);
				}
			}
			else if(cbbType.SelectedIndex == 1)
			{
				for (int i = 1; i <= 24; i++)
				{
					cbbTime.Items.Add(i);
				}
			}
			else if (cbbType.SelectedIndex == 2)
			{
				cbbTime.Items.Add(1);
				cbbTime.Items.Add(2);
				cbbTime.Items.Add(3);
				cbbTime.Items.Add(5);
				cbbTime.Items.Add(7);
				cbbTime.Items.Add(10);
				cbbTime.Items.Add(15);
				cbbTime.Items.Add(20);
				cbbTime.Items.Add(30);
				cbbTime.Items.Add(45);
				cbbTime.Items.Add(60);
				cbbTime.Items.Add(90);
				cbbTime.Items.Add(120);
			}
		}
	}
}
