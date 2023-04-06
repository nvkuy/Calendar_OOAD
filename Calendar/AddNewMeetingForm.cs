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
		public string NameUser { get; set; }
		public AddNewMeetingForm(string name)
		{
			NameUser = name;
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

			if (a.startTime < a.endTime &&(a.name.Length>0&&a.location.Length>0))
			{
				db.Meeting.Add(a);
				db.SaveChanges();
				this.Close();
			}
			else
			{
				MessageBox.Show("Your information is not valid, please input a correct form");
			}

		}
	}
}
