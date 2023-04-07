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
	public partial class BeforeFinishSelf : Form
	{
		public Meeting meeting { get; set; }
		public List<Meeting> index=new List<Meeting>();
		public BeforeFinishSelf(Meeting a)
		{
			meeting = a;
			InitializeComponent();
			GUI();
		}
		public void GUI()
		{
			using (CalendarEntities db = new CalendarEntities())
			{
				var s = db.Meeting.Where(p => (p.host == meeting.host || p.NUser1.Any(sv => sv.idUser == meeting.host)))
					.Select(p => p).ToList();
				foreach (var i in s)
				{
					if (meeting.startTime.Value >= i.endTime.Value || meeting.endTime.Value <= i.startTime)
					{
						continue;
					}
					else
					{
						index.Add(i);
						duplicateList.Items.Add(i.name) ;
					}
				}
				
				

			}
		}
		private void btnOK_Click(object sender, EventArgs e)
		{
			using (CalendarEntities db = new CalendarEntities())
			{
				List<Meeting> meeting = new List<Meeting>();
				foreach (Meeting i in index)
				{
					meeting.Add(db.Meeting.Where(p => p.idMeeting == i.idMeeting).Select(p => p).FirstOrDefault());
				}
				foreach (Meeting i in meeting)
				{
					db.Meeting.Remove(i);
				}
				db.SaveChanges();
				this.Close();
			}
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
