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
		public List<string> list = new List<string>();
		public List<int> index=new List<int>();
		public BeforeFinishSelf(List<int> index,List<string> list)
		{
			this.index = index;
			this.list = list;
			InitializeComponent();
			GUI();
		}
		public void GUI()
		{
			List<string> listview= new List<string>();
			listview.AddRange(list);
		}
		private void btnOK_Click(object sender, EventArgs e)
		{
			using (CalendarEntities db = new CalendarEntities())
			{
				List<Meeting> meeting = new List<Meeting>();
				foreach (int i in index)
				{
					meeting.Add(db.Meeting.Where(p => p.idMeeting == i).Select(p => p).FirstOrDefault());
				}
				foreach (Meeting i in meeting)
				{
					db.Meeting.Remove(i);
				}
				db.SaveChanges();
			}
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
