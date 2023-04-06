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
		public void setName(string name)
		{
			txtuser.Text = name;
		}

		

		private void btnUser_Click(object sender, EventArgs e)
		{
			Login f = new Login();
			f.d += new Login.MyDel(setName);
			f.Show();
		}

		private void user_TextChanged(object sender, EventArgs e)
		{
			//data
		}

		private void btnAdd_Click(object sender, EventArgs e)
		{
			AddNewMeetingForm f=new AddNewMeetingForm(txtuser.Text);

			f.Show();
		}
	}
}
