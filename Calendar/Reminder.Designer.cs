namespace Calendar
{
	partial class Reminder
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.txtuser = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.data = new System.Windows.Forms.DataGridView();
			this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
			((System.ComponentModel.ISupportInitialize)(this.data)).BeginInit();
			this.SuspendLayout();
			// 
			// txtuser
			// 
			this.txtuser.BackColor = System.Drawing.SystemColors.Info;
			this.txtuser.Enabled = false;
			this.txtuser.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtuser.Location = new System.Drawing.Point(106, 12);
			this.txtuser.Name = "txtuser";
			this.txtuser.Size = new System.Drawing.Size(165, 27);
			this.txtuser.TabIndex = 18;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(13, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(87, 38);
			this.label1.TabIndex = 16;
			this.label1.Text = "User";
			// 
			// data
			// 
			this.data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.data.Location = new System.Drawing.Point(-73, 62);
			this.data.Name = "data";
			this.data.RowHeadersWidth = 51;
			this.data.RowTemplate.Height = 24;
			this.data.Size = new System.Drawing.Size(1132, 494);
			this.data.TabIndex = 15;
			// 
			// dateTimePicker1
			// 
			this.dateTimePicker1.Enabled = false;
			this.dateTimePicker1.Location = new System.Drawing.Point(652, 10);
			this.dateTimePicker1.Name = "dateTimePicker1";
			this.dateTimePicker1.Size = new System.Drawing.Size(246, 22);
			this.dateTimePicker1.TabIndex = 14;
			// 
			// Reminder
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1068, 560);
			this.Controls.Add(this.txtuser);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.data);
			this.Controls.Add(this.dateTimePicker1);
			this.Name = "Reminder";
			this.Text = "Reminder";
			((System.ComponentModel.ISupportInitialize)(this.data)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox txtuser;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DataGridView data;
		private System.Windows.Forms.DateTimePicker dateTimePicker1;
	}
}