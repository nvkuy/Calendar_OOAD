
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calendar
{
	public partial class BeforeFinishOther : Form
	{
		public Meeting meeting { get; set; }
		public BeforeFinishOther(Meeting a)
		{
			meeting = a;
			InitializeComponent();
			GUI();
		}
		public void GUI()
		{
			using(CalendarEntities db=new CalendarEntities())
			{
				var s=db.Meeting.Where(p=>p.name==meeting.name && (p.startTime==meeting.startTime &&p.endTime==meeting.endTime))
					.Select(p => new ShowDATA { ID = p.idMeeting, DETAIL = p.name, LOCATION = p.location, NGAYBATDAU = p.startTime, NGAYKETTHUC = p.endTime, REMINDERTIME = p.remind, HOST = p.NUser.name })
					.ToList();
				data.DataSource = s;
			}
		}
		private void btnCancel_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void btnAdd_Click(object sender, EventArgs e)
		{
			using(CalendarEntities db=new CalendarEntities())
			{
				db.Meeting.Add(meeting);
				User_Meeting cp = new User_Meeting();
				cp.idMeeting = meeting.idMeeting;
				cp.idUser = meeting.host;
				db.User_Meeting.Add(cp);
				db.SaveChanges();
				this.Close();
			}
			this.Close();
		}

		private void btnJoin_Click(object sender, EventArgs e)
		{
			if (data.SelectedRows.Count == 1)
			{
				using (CalendarEntities db = new CalendarEntities())
				{
					User_Meeting cp = new User_Meeting();
					var p = data.SelectedRows[0].Cells[0].Value;
					cp.idMeeting = Convert.ToInt32(p.ToString());
					cp.idUser = meeting.host;
					db.User_Meeting.Add(cp);
					db.SaveChanges();

					this.Close();
				}

				
			}
		}
	}
}
