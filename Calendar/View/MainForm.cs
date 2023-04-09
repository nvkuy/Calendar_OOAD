using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Objects;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Calendar
{
	public partial class MainForm : Form
	{
		[Obsolete]
		public MainForm()
		{
			InitializeComponent();
			
		}
		public void ShowDGV()
		{
			if (txtuser.Text !="")
			{
				CalendarEntities db = new CalendarEntities();
				var q = db.NUser.Where(p => p.name == txtuser.Text).Select(p => p.idUser).FirstOrDefault();
				var s = db.Meeting
					.Select(p => new ShowDATA { ID = p.idMeeting, DETAIL = p.name, LOCATION = p.location, NGAYBATDAU = p.startTime, NGAYKETTHUC = p.endTime, REMINDERTIME = p.remind, HOST = p.NUser.name }); ;
				List<ShowDATA> s1=new List<ShowDATA>();
				foreach(var i in s)
				{
					if(i.NGAYBATDAU.Value.Date==dateTimePicker1.Value.Date || i.NGAYKETTHUC.Value.Date == dateTimePicker1.Value.Date)
					{
						if (checklist(i))
						{
							s1.Add(i);
						}
					}
				}
				data.DataSource = s1.ToList();
			}
		}
		private bool checklist(ShowDATA m)
		{
			CalendarEntities db = new CalendarEntities();
			var q = db.NUser.Where(p => p.name == txtuser.Text).Select(p => p.idUser).FirstOrDefault();
			var ds = db.User_Meeting.Where(p => p.idUser == q).Select(p => p.idMeeting).ToList();
			foreach( var i in ds)
			{
				if (m.ID == i)
				{
					return true;
				}
			}
			return false;
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

		[Obsolete]
		private void date_ValueChanged(object sender, EventArgs e)
		{
			ShowDGV();
		}

		private void btnShow_Click(object sender, EventArgs e)
		{
			Reminder f = new Reminder(txtuser.Text,dateTimePicker1.Value.Date);
			f.Show();
		}
	}
}
