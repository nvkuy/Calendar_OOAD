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
	public partial class Login : Form
	{
		public delegate void MyDel(string name);
		public MyDel d { get; set; }

		public Login()
		{
			InitializeComponent();
		}

		private void btnOK_Click(object sender, EventArgs e)
		{
			string s=txtEmail.Text;
			CalendarEntities db=new CalendarEntities();
			var q=db.NUser.Where(p=>p.gmail.CompareTo(s)==0).Select(p=>p).FirstOrDefault();
			if (q != null)
			{
				d(q.name);
				this.Close();
			}
			else
			{
				MessageBox.Show("Không tìm thấy tài khoản có email trên, vui lòng nhập lại ");
			}
			
		}
	}
}
