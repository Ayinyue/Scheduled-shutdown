namespace 定点定时关机
{
	// Token: 0x02000002 RID: 2
	public partial class Form1 : global::System.Windows.Forms.Form
	{
		// Token: 0x06000009 RID: 9 RVA: 0x00002370 File Offset: 0x00000570
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x0600000A RID: 10 RVA: 0x00002390 File Offset: 0x00000590
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.comboBoxActionType = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label_sudTime = new System.Windows.Forms.Label();
            this.label_nowTime = new System.Windows.Forms.Label();
            this.label_curTime = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.comboBox6 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox5 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.nowTimer = new System.Windows.Forms.Timer(this.components);
            this.progressBarShutdown = new System.Windows.Forms.ProgressBar();
            this.labelRemainingTime = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(6);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(653, 242);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Transparent;
            this.tabPage1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPage1.Controls.Add(this.comboBoxActionType);
            this.tabPage1.Controls.Add(this.dateTimePicker1);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.comboBox3);
            this.tabPage1.Controls.Add(this.button3);
            this.tabPage1.Controls.Add(this.button4);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.comboBox2);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.comboBox1);
            this.tabPage1.Controls.Add(this.label_sudTime);
            this.tabPage1.Controls.Add(this.label_nowTime);
            this.tabPage1.Controls.Add(this.label_curTime);
            this.tabPage1.Location = new System.Drawing.Point(4, 41);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(6);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(6);
            this.tabPage1.Size = new System.Drawing.Size(645, 197);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "定点";
            // 
            // comboBoxActionType
            // 
            this.comboBoxActionType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxActionType.Font = new System.Drawing.Font("微软雅黑", 15F);
            this.comboBoxActionType.FormattingEnabled = true;
            this.comboBoxActionType.Location = new System.Drawing.Point(15, 136);
            this.comboBoxActionType.Name = "comboBoxActionType";
            this.comboBoxActionType.Size = new System.Drawing.Size(105, 40);
            this.comboBoxActionType.TabIndex = 20;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "yyyy年M月dd";
            this.dateTimePicker1.Location = new System.Drawing.Point(138, 74);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 40);
            this.dateTimePicker1.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(601, 77);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 32);
            this.label8.TabIndex = 19;
            this.label8.Text = "秒";
            // 
            // comboBox3
            // 
            this.comboBox3.Font = new System.Drawing.Font("微软雅黑", 15F);
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(541, 74);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(60, 40);
            this.comboBox3.TabIndex = 18;
            // 
            // button3
            // 
            this.button3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.button3.Location = new System.Drawing.Point(451, 130);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(150, 51);
            this.button3.TabIndex = 17;
            this.button3.Text = "取消倒计时";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.buttonCancelShutdown_Click);
            // 
            // button4
            // 
            this.button4.ForeColor = System.Drawing.Color.Red;
            this.button4.Location = new System.Drawing.Point(138, 130);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(150, 51);
            this.button4.TabIndex = 16;
            this.button4.Text = "开始倒计时";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.buttonSetActionTime_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(502, 77);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 32);
            this.label7.TabIndex = 7;
            this.label7.Text = "分";
            // 
            // comboBox2
            // 
            this.comboBox2.Font = new System.Drawing.Font("微软雅黑", 15F);
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(442, 74);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(60, 40);
            this.comboBox2.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(403, 77);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 32);
            this.label6.TabIndex = 5;
            this.label6.Text = "时";
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("微软雅黑", 15F);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(343, 74);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(60, 40);
            this.comboBox1.TabIndex = 4;
            // 
            // label_sudTime
            // 
            this.label_sudTime.AutoSize = true;
            this.label_sudTime.Location = new System.Drawing.Point(9, 74);
            this.label_sudTime.Name = "label_sudTime";
            this.label_sudTime.Size = new System.Drawing.Size(139, 32);
            this.label_sudTime.TabIndex = 3;
            this.label_sudTime.Text = "动作时间：";
            // 
            // label_nowTime
            // 
            this.label_nowTime.AutoSize = true;
            this.label_nowTime.Font = new System.Drawing.Font("微软雅黑", 15F);
            this.label_nowTime.Location = new System.Drawing.Point(134, 16);
            this.label_nowTime.Name = "label_nowTime";
            this.label_nowTime.Size = new System.Drawing.Size(123, 32);
            this.label_nowTime.TabIndex = 2;
            this.label_nowTime.Text = "nowTime";
            // 
            // label_curTime
            // 
            this.label_curTime.AutoSize = true;
            this.label_curTime.Location = new System.Drawing.Point(9, 16);
            this.label_curTime.Name = "label_curTime";
            this.label_curTime.Size = new System.Drawing.Size(139, 32);
            this.label_curTime.TabIndex = 0;
            this.label_curTime.Text = "当前时间：";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Transparent;
            this.tabPage2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.comboBox6);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.comboBox5);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.comboBox4);
            this.tabPage2.Controls.Add(this.button2);
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Location = new System.Drawing.Point(4, 41);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(6);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(6);
            this.tabPage2.Size = new System.Drawing.Size(645, 197);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "定时";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(164, 32);
            this.label3.TabIndex = 22;
            this.label3.Text = "动作倒计时：";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label9.Location = new System.Drawing.Point(570, 42);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(39, 32);
            this.label9.TabIndex = 21;
            this.label9.Text = "秒";
            // 
            // comboBox6
            // 
            this.comboBox6.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.comboBox6.FormattingEnabled = true;
            this.comboBox6.Location = new System.Drawing.Point(494, 40);
            this.comboBox6.Name = "comboBox6";
            this.comboBox6.Size = new System.Drawing.Size(60, 40);
            this.comboBox6.TabIndex = 20;
            this.comboBox6.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(439, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 32);
            this.label1.TabIndex = 19;
            this.label1.Text = "分";
            // 
            // comboBox5
            // 
            this.comboBox5.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.comboBox5.FormattingEnabled = true;
            this.comboBox5.Location = new System.Drawing.Point(363, 39);
            this.comboBox5.Name = "comboBox5";
            this.comboBox5.Size = new System.Drawing.Size(60, 40);
            this.comboBox5.TabIndex = 18;
            this.comboBox5.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(308, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 32);
            this.label2.TabIndex = 17;
            this.label2.Text = "时";
            // 
            // comboBox4
            // 
            this.comboBox4.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(212, 39);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(80, 40);
            this.comboBox4.TabIndex = 16;
            // 
            // button2
            // 
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.button2.Location = new System.Drawing.Point(451, 115);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(150, 51);
            this.button2.TabIndex = 15;
            this.button2.Text = "取消倒计时";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.buttonCancelShutdown_Click);
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.Color.Red;
            this.button1.Location = new System.Drawing.Point(80, 115);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 51);
            this.button1.TabIndex = 14;
            this.button1.Text = "开始倒计时";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.buttonCountdownAction_Click);
            // 
            // nowTimer
            // 
            this.nowTimer.Enabled = true;
            this.nowTimer.Interval = 1000;
            this.nowTimer.Tick += new System.EventHandler(this.nowTimer_Tick);
            // 
            // progressBarShutdown
            // 
            this.progressBarShutdown.BackColor = System.Drawing.SystemColors.Control;
            this.progressBarShutdown.Location = new System.Drawing.Point(364, 244);
            this.progressBarShutdown.Name = "progressBarShutdown";
            this.progressBarShutdown.Size = new System.Drawing.Size(285, 40);
            this.progressBarShutdown.TabIndex = 21;
            // 
            // labelRemainingTime
            // 
            this.labelRemainingTime.AutoSize = true;
            this.labelRemainingTime.BackColor = System.Drawing.Color.Transparent;
            this.labelRemainingTime.Location = new System.Drawing.Point(-1, 244);
            this.labelRemainingTime.Name = "labelRemainingTime";
            this.labelRemainingTime.Size = new System.Drawing.Size(139, 32);
            this.labelRemainingTime.TabIndex = 22;
            this.labelRemainingTime.Text = "剩余时间：";
            this.labelRemainingTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(653, 287);
            this.Controls.Add(this.labelRemainingTime);
            this.Controls.Add(this.progressBarShutdown);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "系统定时工具";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		// Token: 0x04000003 RID: 3
		private global::System.ComponentModel.IContainer components;

		// Token: 0x04000004 RID: 4
		private global::System.Windows.Forms.TabControl tabControl1;

		// Token: 0x04000005 RID: 5
		private global::System.Windows.Forms.TabPage tabPage1;

		// Token: 0x04000006 RID: 6
		private global::System.Windows.Forms.TabPage tabPage2;

		// Token: 0x04000007 RID: 7
		private global::System.Windows.Forms.Button button2;

		// Token: 0x04000008 RID: 8
		private global::System.Windows.Forms.Button button1;

		// Token: 0x04000009 RID: 9
		private global::System.Windows.Forms.Label label_curTime;

		// Token: 0x0400000A RID: 10
		private global::System.Windows.Forms.Label label_nowTime;

		// Token: 0x0400000B RID: 11
		private global::System.Windows.Forms.Timer nowTimer;

		// Token: 0x0400000C RID: 12
		private global::System.Windows.Forms.Label label_sudTime;

		// Token: 0x0400000D RID: 13
		private global::System.Windows.Forms.Label label7;

		// Token: 0x0400000E RID: 14
		private global::System.Windows.Forms.ComboBox comboBox2;

		// Token: 0x0400000F RID: 15
		private global::System.Windows.Forms.Label label6;

		// Token: 0x04000010 RID: 16
		private global::System.Windows.Forms.ComboBox comboBox1;

		// Token: 0x04000011 RID: 17
		private global::System.Windows.Forms.Button button3;

		// Token: 0x04000012 RID: 18
		private global::System.Windows.Forms.Button button4;

		// Token: 0x04000013 RID: 19
		private global::System.Windows.Forms.Label label1;

		// Token: 0x04000014 RID: 20
		private global::System.Windows.Forms.ComboBox comboBox5;

		// Token: 0x04000015 RID: 21
		private global::System.Windows.Forms.Label label2;

		// Token: 0x04000016 RID: 22
		private global::System.Windows.Forms.ComboBox comboBox4;

		// Token: 0x04000017 RID: 23
		private global::System.Windows.Forms.Label label8;

		// Token: 0x04000018 RID: 24
		private global::System.Windows.Forms.ComboBox comboBox3;

		// Token: 0x04000019 RID: 25
		private global::System.Windows.Forms.Label label9;

		// Token: 0x0400001A RID: 26
		private global::System.Windows.Forms.ComboBox comboBox6;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ProgressBar progressBarShutdown;
        private System.Windows.Forms.Label labelRemainingTime;
        private System.Windows.Forms.ComboBox comboBoxActionType;
    }
}
