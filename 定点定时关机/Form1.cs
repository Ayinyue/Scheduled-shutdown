using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace 定点定时关机
{
    // Token: 0x02000002 RID: 2
    public partial class Form1 : Form
    {
        // Token: 0x06000001 RID: 1 RVA: 0x00002050 File Offset: 0x00000250
        public Form1()
        {
            InitializeComponent();
        }

        // Token: 0x06000002 RID: 2 RVA: 0x00002060 File Offset: 0x00000260
        private void timer1_Tick(object sender, EventArgs e)
        {

            // 获取当前日期时间并格式化为年月日时分秒
            DateTime currentDateTime = DateTime.Now;

            label_nowTime.Text = currentDateTime.ToString("yyyy年  M月dd日  HH    时   mm    分  ss    秒");

        }

        // Token: 0x06000003 RID: 3 RVA: 0x00002098 File Offset: 0x00000298
        private void Form1_Load(object sender, EventArgs e)
        {
            // 启动计时器
            timer1.Start();

            // 获取当前时间
            DateTime currentTime = DateTime.Now;

            // 为ComboBox添加选项
            for (int i = 0; i <= 59; i++)
            {
                // 小时选项 (0-23)
                if (i < 24)
                {
                    comboBox1.Items.Add(i.ToString("D2"));
                }

                // 分钟选项 (0-59)
                comboBox2.Items.Add(i.ToString("D2"));

                // 秒钟选项 (0-59)
                comboBox3.Items.Add(i.ToString("D2"));
                comboBox4.Items.Add(i.ToString("D2"));
                comboBox5.Items.Add(i.ToString("D2"));
                comboBox6.Items.Add(i.ToString("D2"));
            }

            // 设置ComboBox显示当前时间
            comboBox1.SelectedItem = currentTime.Hour.ToString("D2");
            comboBox2.SelectedItem = currentTime.Minute.ToString("D2");
            comboBox3.SelectedItem = currentTime.Second.ToString("D2");

            // 如果需要，可以禁用编辑功能，只允许选择
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox3.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox5.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox6.DropDownStyle = ComboBoxStyle.DropDownList;
        }


        // Token: 0x06000004 RID: 4 RVA: 0x00002178 File Offset: 0x00000378
        private void buttonCountdownTime_Click(object sender, EventArgs e)
        {
            int num = Convert.ToInt32(comboBox4.Text) * 3600;
            int num2 = Convert.ToInt32(comboBox5.Text) * 60;
            int num3 = Convert.ToInt32(comboBox6.Text);
            shutdown("shutdown -s -t " + (num + num2 + num3).ToString());
        }

        // Token: 0x06000005 RID: 5 RVA: 0x000021E0 File Offset: 0x000003E0
        /// <summary>
        /// 执行系统关机命令
        /// </summary>
        /// <param name="command">关机命令字符串，例如"shutdown -s -t 3600"</param>
        /// <returns>返回执行结果</returns>
        private bool shutdown(string command)
        {
            try
            {
                using (Process process = new Process())
                {
                    process.StartInfo.FileName = "cmd.exe";
                    process.StartInfo.UseShellExecute = false;
                    process.StartInfo.RedirectStandardInput = true;
                    process.StartInfo.RedirectStandardOutput = true;
                    process.StartInfo.RedirectStandardError = true;
                    process.StartInfo.CreateNoWindow = true;

                    process.Start();
                    process.StandardInput.WriteLine(command);
                    process.StandardInput.WriteLine("exit");

                    process.WaitForExit();
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("执行关机命令失败: " + ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }


        // Token: 0x06000006 RID: 6 RVA: 0x0000226D File Offset: 0x0000046D
        private void buttonCancel_Click(object sender, EventArgs e)
        {
            try
            {
                // 执行取消关机命令
                shutdown("shutdown -a");
                MessageBox.Show("已取消定时关机", "操作成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("取消关机失败: " + ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonSetShutdownTime_Click(object sender, EventArgs e)
        {
            try
            {
                // 获取用户选择的时间
                int hours = int.Parse(comboBox1.Text);
                int minutes = int.Parse(comboBox2.Text);
                int seconds = int.Parse(comboBox3.Text);

                // 获取用户选择的日期
                DateTime selectedDate = dateTimePicker1.Value.Date;

                // 构建完整的日期时间
                DateTime scheduledTime = new DateTime(
                    selectedDate.Year,
                    selectedDate.Month,
                    selectedDate.Day,
                    hours,
                    minutes,
                    seconds);

                // 获取当前时间
                DateTime currentTime = DateTime.Now;

                // 检查设定时间是否已过
                if (scheduledTime <= currentTime)
                {
                    MessageBox.Show("设定的时间已过，请重新设置！", "错误：", MessageBoxButtons.OKCancel, MessageBoxIcon.Hand);
                    return;
                }

                // 计算时间差并执行关机命令
                TimeSpan timeSpan = scheduledTime - currentTime;
                int totalSeconds = (int)timeSpan.TotalSeconds;

                shutdown("shutdown -s -t " + totalSeconds.ToString());

                // 可选：显示成功消息
                MessageBox.Show($"系统将在 {scheduledTime:yyyy-MM-dd HH:mm:ss} 关机",
                               "定时关机已设置",
                               MessageBoxButtons.OK,
                               MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("时间设置出错: " + ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
