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
			this.user = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.btnUser = new System.Windows.Forms.Button();
			this.btnAdd = new System.Windows.Forms.Button();
			this.cbRemind = new System.Windows.Forms.CheckBox();
			this.cbbTime = new System.Windows.Forms.ComboBox();
			this.cbbType = new System.Windows.Forms.ComboBox();
			((System.ComponentModel.ISupportInitialize)(this.data)).BeginInit();
			this.SuspendLayout();
			// 
			// dateTimePicker1
			// 
			this.dateTimePicker1.Location = new System.Drawing.Point(702, 11);
			this.dateTimePicker1.Name = "dateTimePicker1";
			this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
			this.dateTimePicker1.TabIndex = 0;
			// 
			// data
			// 
			this.data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.data.Location = new System.Drawing.Point(13, 51);
			this.data.Name = "data";
			this.data.RowHeadersWidth = 51;
			this.data.RowTemplate.Height = 24;
			this.data.Size = new System.Drawing.Size(1164, 544);
			this.data.TabIndex = 1;
			// 
			// user
			// 
			this.user.Enabled = false;
			this.user.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.user.Location = new System.Drawing.Point(123, 11);
			this.user.Name = "user";
			this.user.Size = new System.Drawing.Size(174, 27);
			this.user.TabIndex = 2;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(41, 14);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(45, 20);
			this.label1.TabIndex = 3;
			this.label1.Text = "User";
			// 
			// btnUser
			// 
			this.btnUser.Location = new System.Drawing.Point(330, 14);
			this.btnUser.Name = "btnUser";
			this.btnUser.Size = new System.Drawing.Size(75, 23);
			this.btnUser.TabIndex = 4;
			this.btnUser.Text = "Choose";
			this.btnUser.UseVisualStyleBackColor = true;
			// 
			// btnAdd
			// 
			this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAdd.Location = new System.Drawing.Point(45, 610);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(219, 35);
			this.btnAdd.TabIndex = 5;
			this.btnAdd.Text = "Add";
			this.btnAdd.UseVisualStyleBackColor = true;
			// 
			// cbRemind
			// 
			this.cbRemind.AutoSize = true;
			this.cbRemind.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbRemind.Location = new System.Drawing.Point(702, 610);
			this.cbRemind.Name = "cbRemind";
			this.cbRemind.Size = new System.Drawing.Size(103, 24);
			this.cbRemind.TabIndex = 6;
			this.cbRemind.Text = "Reminder";
			this.cbRemind.UseVisualStyleBackColor = true;
			// 
			// cbbTime
			// 
			this.cbbTime.FormattingEnabled = true;
			this.cbbTime.Location = new System.Drawing.Point(856, 610);
			this.cbbTime.Name = "cbbTime";
			this.cbbTime.Size = new System.Drawing.Size(121, 24);
			this.cbbTime.TabIndex = 7;
			// 
			// cbbType
			// 
			this.cbbType.FormattingEnabled = true;
			this.cbbType.Items.AddRange(new object[] {
            "Minute",
            "Hour",
            "Day"});
			this.cbbType.Location = new System.Drawing.Point(999, 610);
			this.cbbType.Name = "cbbType";
			this.cbbType.Size = new System.Drawing.Size(121, 24);
			this.cbbType.TabIndex = 8;
			this.cbbType.SelectedIndexChanged += new System.EventHandler(this.cbbType_SelectedIndexChanged);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1189, 657);
			this.Controls.Add(this.cbbType);
			this.Controls.Add(this.cbbTime);
			this.Controls.Add(this.cbRemind);
			this.Controls.Add(this.btnAdd);
			this.Controls.Add(this.btnUser);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.user);
			this.Controls.Add(this.data);
			this.Controls.Add(this.dateTimePicker1);
			this.Name = "MainForm";
			this.Text = "Form1";
			((System.ComponentModel.ISupportInitialize)(this.data)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DateTimePicker dateTimePicker1;
		private System.Windows.Forms.DataGridView data;
		private System.Windows.Forms.TextBox user;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnUser;
		private System.Windows.Forms.Button btnAdd;
		private System.Windows.Forms.CheckBox cbRemind;
		private System.Windows.Forms.ComboBox cbbTime;
		private System.Windows.Forms.ComboBox cbbType;
	}
}

