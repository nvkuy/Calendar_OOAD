namespace Calendar
{
	partial class AddNewMeetingForm
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
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.btnConfirm = new System.Windows.Forms.Button();
			this.btnCancel = new System.Windows.Forms.Button();
			this.txtName = new System.Windows.Forms.TextBox();
			this.dateStart = new System.Windows.Forms.DateTimePicker();
			this.txtLocate = new System.Windows.Forms.TextBox();
			this.dateEnd = new System.Windows.Forms.DateTimePicker();
			this.cbRemind = new System.Windows.Forms.CheckBox();
			this.cbbHour = new System.Windows.Forms.ComboBox();
			this.cbbMinute = new System.Windows.Forms.ComboBox();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(69, 63);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(268, 38);
			this.label1.TabIndex = 4;
			this.label1.Text = "Add new meeting";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(69, 187);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(221, 38);
			this.label2.TabIndex = 5;
			this.label2.Text = "Meeting Topic";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(69, 258);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(140, 38);
			this.label3.TabIndex = 6;
			this.label3.Text = "Location";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(69, 329);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(167, 38);
			this.label4.TabIndex = 7;
			this.label4.Text = "Start Time";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(69, 401);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(156, 38);
			this.label5.TabIndex = 8;
			this.label5.Text = "End Time";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(69, 469);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(129, 38);
			this.label6.TabIndex = 9;
			this.label6.Text = "Remind";
			// 
			// btnConfirm
			// 
			this.btnConfirm.BackColor = System.Drawing.SystemColors.ControlText;
			this.btnConfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnConfirm.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.btnConfirm.Location = new System.Drawing.Point(583, 561);
			this.btnConfirm.Name = "btnConfirm";
			this.btnConfirm.Size = new System.Drawing.Size(235, 65);
			this.btnConfirm.TabIndex = 10;
			this.btnConfirm.Text = "OKAY";
			this.btnConfirm.UseVisualStyleBackColor = false;
			this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
			// 
			// btnCancel
			// 
			this.btnCancel.BackColor = System.Drawing.SystemColors.ControlText;
			this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCancel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.btnCancel.Location = new System.Drawing.Point(842, 561);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(235, 65);
			this.btnCancel.TabIndex = 11;
			this.btnCancel.Text = "CANCEL";
			this.btnCancel.UseVisualStyleBackColor = false;
			this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
			// 
			// txtName
			// 
			this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtName.Location = new System.Drawing.Point(408, 198);
			this.txtName.Name = "txtName";
			this.txtName.Size = new System.Drawing.Size(650, 27);
			this.txtName.TabIndex = 12;
			// 
			// dateStart
			// 
			this.dateStart.Location = new System.Drawing.Point(408, 342);
			this.dateStart.Name = "dateStart";
			this.dateStart.Size = new System.Drawing.Size(246, 22);
			this.dateStart.TabIndex = 14;
			// 
			// txtLocate
			// 
			this.txtLocate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtLocate.Location = new System.Drawing.Point(408, 269);
			this.txtLocate.Name = "txtLocate";
			this.txtLocate.Size = new System.Drawing.Size(650, 27);
			this.txtLocate.TabIndex = 12;
			// 
			// dateEnd
			// 
			this.dateEnd.Location = new System.Drawing.Point(408, 414);
			this.dateEnd.Name = "dateEnd";
			this.dateEnd.Size = new System.Drawing.Size(246, 22);
			this.dateEnd.TabIndex = 14;
			// 
			// cbRemind
			// 
			this.cbRemind.AutoSize = true;
			this.cbRemind.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbRemind.Location = new System.Drawing.Point(398, 480);
			this.cbRemind.Name = "cbRemind";
			this.cbRemind.Size = new System.Drawing.Size(146, 24);
			this.cbRemind.TabIndex = 15;
			this.cbRemind.Text = "Have Remind ?";
			this.cbRemind.UseVisualStyleBackColor = true;
			// 
			// cbbHour
			// 
			this.cbbHour.FormattingEnabled = true;
			this.cbbHour.Location = new System.Drawing.Point(575, 480);
			this.cbbHour.Name = "cbbHour";
			this.cbbHour.Size = new System.Drawing.Size(70, 24);
			this.cbbHour.TabIndex = 16;
			// 
			// cbbMinute
			// 
			this.cbbMinute.FormattingEnabled = true;
			this.cbbMinute.Location = new System.Drawing.Point(720, 481);
			this.cbbMinute.Name = "cbbMinute";
			this.cbbMinute.Size = new System.Drawing.Size(63, 24);
			this.cbbMinute.TabIndex = 17;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(651, 484);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(46, 20);
			this.label7.TabIndex = 18;
			this.label7.Text = "Hour";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.Location = new System.Drawing.Point(789, 486);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(59, 20);
			this.label8.TabIndex = 19;
			this.label8.Text = "Minute";
			// 
			// AddNewMeetingForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1155, 684);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.cbbMinute);
			this.Controls.Add(this.cbbHour);
			this.Controls.Add(this.cbRemind);
			this.Controls.Add(this.dateEnd);
			this.Controls.Add(this.dateStart);
			this.Controls.Add(this.txtLocate);
			this.Controls.Add(this.txtName);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.btnConfirm);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "AddNewMeetingForm";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Button btnConfirm;
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.TextBox txtName;
		private System.Windows.Forms.DateTimePicker dateStart;
		private System.Windows.Forms.TextBox txtLocate;
		private System.Windows.Forms.DateTimePicker dateEnd;
		private System.Windows.Forms.CheckBox cbRemind;
		private System.Windows.Forms.ComboBox cbbHour;
		private System.Windows.Forms.ComboBox cbbMinute;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
	}
}