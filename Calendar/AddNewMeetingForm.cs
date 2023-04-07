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
	public partial class AddNewMeetingForm : Form
	{
		public delegate void MyDel();
		public MyDel d { get; set; }
		public string NameUser { get; set; }
		public DateTime date_choice { get; set; }
		public AddNewMeetingForm(string name, DateTime date_choice)
		{
			NameUser = name;
			this.date_choice = date_choice;
			InitializeComponent();
			this.Text = "AddForm";
			setup();
			
		}
		public void setup()
		{
				dateStart.Format = DateTimePickerFormat.Custom;
				dateStart.CustomFormat = "dd MM yyyy	 hh:mm:ss  tt";
				dateEnd.Format = DateTimePickerFormat.Custom;
				dateEnd.CustomFormat = "dd MM yyyy		 hh:mm:ss  tt";
				cbbHour.Items.Clear();
				cbbMinute.Items.Clear();
				for(int i = 0; i <= 60; i++)
				{
					cbbHour.Items.Add(i);
				}
				for (int i = 0; i <= 59; i++)
				{
					cbbMinute.Items.Add(i);
				}
				dateStart.Value= date_choice;
				dateEnd.Value= date_choice;
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void btnConfirm_Click(object sender, EventArgs e)
		{
			CalendarEntities db= new CalendarEntities();
			Meeting a=new Meeting();
			a.name= txtName.Text;
			a.location=txtLocate.Text;
			a.startTime = Convert.ToDateTime(dateStart.Text.ToString());
			a.endTime=Convert.ToDateTime(dateEnd.Text.ToString());
			if (cbRemind.Checked)
			{
				a.remind = Convert.ToInt32(cbbHour.SelectedItem.ToString()) * 60 + Convert.ToInt32(cbbMinute.SelectedItem.ToString());
			}
			else
			{
				a.remind = -1;
			}
			a.host=db.NUser.Where(p=>p.name==NameUser).Select (p=>p.idUser).FirstOrDefault();

			if (a.startTime <= a.endTime &&(a.name.Length>0&&a.location.Length>0))
			{
				if (check_duplicate_time(a) == false && check_duplicate_group(a) == false)
				{
					db.Meeting.Add(a);
					db.SaveChanges();
					d();
					this.Close();
				}
				else
				{
					if (check_duplicate_time(a))
					{
						BeforeFinishSelf f = new BeforeFinishSelf(a);
						f.Show();
						
					}
					else
					{
						BeforeFinishOther f = new BeforeFinishOther(a);
						f.Show();
					}
				}
			}
			else
			{
				MessageBox.Show("Your information is not valid, please input a correct form");
			}

		}

		private void cbAllDay_CheckedChanged(object sender, EventArgs e)
		{
			if (cbAllDay.Checked)
			{
				dateStart.Format = DateTimePickerFormat.Long;
				dateEnd.Format = DateTimePickerFormat.Long;
				dateStart.Value = date_choice;
				dateEnd.Value = date_choice;
			}
			else
			{
				dateStart.Format = DateTimePickerFormat.Custom;
				dateStart.CustomFormat = "dd MM yyyy	 hh:mm:ss  tt";
				dateEnd.Format = DateTimePickerFormat.Custom;
				dateEnd.CustomFormat = "dd MM yyyy		 hh:mm:ss  tt";
				dateStart.Value = date_choice;
				dateEnd.Value = date_choice;
			}
		}
		public void list_duplicate_time(Meeting a) 
		{
			
		}
		private bool check_duplicate_time(Meeting a)
		{
			
			using(CalendarEntities db=new CalendarEntities())
			{
				var q = db.NUser.Where(p => p.name == NameUser).Select(p => p.idUser).FirstOrDefault();
				var s = db.Meeting.Where(p => (p.host == q || p.NUser1.Any(sv => sv.idUser == q)))
					.Select(p=>p).ToList() ;
				foreach(var i in s)
				{
					if (a.startTime.Value>=i.endTime.Value ||a.endTime.Value<=i.startTime)
					{
						continue;
					}
					else
					{
						return true;
					}
				}
				return false;
			}
		}
		private bool check_duplicate_group(Meeting a)
		{
			using (CalendarEntities db = new CalendarEntities())
			{
				var q = db.NUser.Where(p => p.name == NameUser).Select(p => p.idUser).FirstOrDefault();
				var s = db.Meeting.Where(p => (p.host == q || p.NUser1.Any(sv => sv.idUser == q)))
					.Select(p => p).ToList();
				foreach (var i in s)
				{
					if (a.name==i.name &&(a.startTime.Value==i.startTime.Value && a.endTime.Value == i.endTime.Value))
					{
						return true;
						
					}
				}
				return false;
			}
		}
	}
}
