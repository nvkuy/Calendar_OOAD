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
		public void ShowDGV()
		{
			if (txtuser.Text.Length > 0)
			{
				CalendarEntities db = new CalendarEntities();
				var q = db.NUser.Where(p => p.name == txtuser.Text).Select(p => p.idUser).FirstOrDefault();
				var s = db.Meeting.Where(p => (p.host == q || p.NUser1.Any(sv => sv.idUser == q)))
					.Select(p => new { ID = p.idMeeting, DETAIL = p.name, LOCATION = p.location, NGAYBATDAU = p.startTime, NGAYKETTHUC = p.endTime, REMINDERTIME = p.remind, HOST = p.NUser.name }); ;

				data.DataSource = s.ToList();
			}
		}
		public void setName(string name)
		{
			txtuser.Text = name;
			setTime();
		}
		public void setTime()
		{
			dateTimePicker1.Value = DateTime.Now;
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
			if (txtuser.Text.Length > 0)
			{
				AddNewMeetingForm f = new AddNewMeetingForm(txtuser.Text, dateTimePicker1.Value);
				f.d += new AddNewMeetingForm.MyDel(ShowDGV);
				f.Show();
			}
			else
			{
				MessageBox.Show("Thông tin tài khoản hiện đang trống, vui lòng nhập thông tin");
			}
		}

		private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
		{
			ShowDGV();
		}
	}
}
