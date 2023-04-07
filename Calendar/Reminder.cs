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
	public partial class Reminder : Form
	{
		public string username { get; set; }
		public DateTime date { get; set; }
		public Reminder(string username, DateTime date)
		{
			this.username = username;
			this.date = date;
			InitializeComponent();
			GUI();
		}
		public void GUI()
		{
			txtuser.Text = username;
			dateTimePicker1 = new DateTimePicker();
			ShowDGV();

		}
		public void ShowDGV()
		{
			if (txtuser.Text != "")
			{
				CalendarEntities db = new CalendarEntities();
				var q = db.NUser.Where(p => p.name == txtuser.Text).Select(p => p.idUser).FirstOrDefault();
				var s = db.Meeting.Where(p=>p.remind>-1)
					.Select(p => new ShowDATA { ID = p.idMeeting, DETAIL = p.name, LOCATION = p.location, NGAYBATDAU = p.startTime, NGAYKETTHUC = p.endTime, REMINDERTIME = p.remind, HOST = p.NUser.name }); ;
				List<ShowDATA> s1 = new List<ShowDATA>();
				foreach (var i in s)
				{
					if (i.NGAYBATDAU.Value.Date == dateTimePicker1.Value.Date || i.NGAYKETTHUC.Value.Date == dateTimePicker1.Value.Date)
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
			foreach (var i in ds)
			{
				if (m.ID == i)
				{
					return true;
				}
			}
			return false;
		}

	}
}
