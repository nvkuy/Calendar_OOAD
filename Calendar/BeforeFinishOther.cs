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
	public partial class BeforeFinishOther : Form
	{
		public Meeting meeting { get; set; }
		public BeforeFinishOther(Meeting a)
		{
			meeting = a;
			InitializeComponent();
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
				db.SaveChanges();
			}
			this.Close();
		}

		private void btnJoin_Click(object sender, EventArgs e)
		{
			if (data.SelectedRows.Count == 1)
			{

			}
		}
	}
}
