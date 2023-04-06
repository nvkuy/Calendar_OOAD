namespace Calendar
{
	partial class MainForm
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
			this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
			this.data = new System.Windows.Forms.DataGridView();
			this.label1 = new System.Windows.Forms.Label();
			this.btnUser = new System.Windows.Forms.Button();
			this.btnAdd = new System.Windows.Forms.Button();
			this.btnShow = new System.Windows.Forms.Button();
			this.btnDel = new System.Windows.Forms.Button();
			this.txtuser = new System.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.data)).BeginInit();
			this.SuspendLayout();
			// 
			// dateTimePicker1
			// 
			this.dateTimePicker1.Location = new System.Drawing.Point(604, 28);
			this.dateTimePicker1.Name = "dateTimePicker1";
			this.dateTimePicker1.Size = new System.Drawing.Size(246, 22);
			this.dateTimePicker1.TabIndex = 0;
			// 
			// data
			// 
			this.data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.data.Location = new System.Drawing.Point(45, 72);
			this.data.Name = "data";
			this.data.RowHeadersWidth = 51;
			this.data.RowTemplate.Height = 24;
			this.data.Size = new System.Drawing.Size(1132, 494);
			this.data.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(38, 12);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(87, 38);
			this.label1.TabIndex = 3;
			this.label1.Text = "User";
			// 
			// btnUser
			// 
			this.btnUser.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.btnUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnUser.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnUser.Location = new System.Drawing.Point(321, 9);
			this.btnUser.Name = "btnUser";
			this.btnUser.Size = new System.Drawing.Size(194, 47);
			this.btnUser.TabIndex = 4;
			this.btnUser.Text = "Choose";
			this.btnUser.UseVisualStyleBackColor = false;
			this.btnUser.Click += new System.EventHandler(this.btnUser_Click);
			// 
			// btnAdd
			// 
			this.btnAdd.BackColor = System.Drawing.SystemColors.ControlText;
			this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAdd.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.btnAdd.Location = new System.Drawing.Point(45, 572);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(235, 65);
			this.btnAdd.TabIndex = 5;
			this.btnAdd.Text = "Add Meeting";
			this.btnAdd.UseVisualStyleBackColor = false;
			this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
			// 
			// btnShow
			// 
			this.btnShow.BackColor = System.Drawing.SystemColors.ControlText;
			this.btnShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnShow.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.btnShow.Location = new System.Drawing.Point(604, 572);
			this.btnShow.Name = "btnShow";
			this.btnShow.Size = new System.Drawing.Size(246, 65);
			this.btnShow.TabIndex = 6;
			this.btnShow.Text = "Show Reminder";
			this.btnShow.UseVisualStyleBackColor = false;
			// 
			// btnDel
			// 
			this.btnDel.BackColor = System.Drawing.SystemColors.InfoText;
			this.btnDel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnDel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.btnDel.Location = new System.Drawing.Point(321, 572);
			this.btnDel.Name = "btnDel";
			this.btnDel.Size = new System.Drawing.Size(239, 65);
			this.btnDel.TabIndex = 7;
			this.btnDel.Text = "Delete Meeting";
			this.btnDel.UseVisualStyleBackColor = false;
			// 
			// txtuser
			// 
			this.txtuser.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtuser.Location = new System.Drawing.Point(131, 24);
			this.txtuser.Name = "txtuser";
			this.txtuser.Size = new System.Drawing.Size(165, 27);
			this.txtuser.TabIndex = 13;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1205, 687);
			this.Controls.Add(this.txtuser);
			this.Controls.Add(this.btnDel);
			this.Controls.Add(this.btnShow);
			this.Controls.Add(this.btnAdd);
			this.Controls.Add(this.btnUser);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.data);
			this.Controls.Add(this.dateTimePicker1);
			this.Name = "MainForm";
			this.Text = "AddNewMeetingForm";
			((System.ComponentModel.ISupportInitialize)(this.data)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DateTimePicker dateTimePicker1;
		private System.Windows.Forms.DataGridView data;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnUser;
		private System.Windows.Forms.Button btnAdd;
		private System.Windows.Forms.Button btnShow;
		private System.Windows.Forms.Button btnDel;
		private System.Windows.Forms.TextBox txtuser;
	}
}

