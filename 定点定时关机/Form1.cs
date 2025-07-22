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

        // Token: 0x06000003 RID: 3 RVA: 0x00002098 File Offset: 0x00000298
        private void Form1_Load(object sender, EventArgs e)
        {
            // 初始化倒计时定时器（1秒更新一次）
            actionTimer = new Timer();
            actionTimer.Interval = 1000; // 1秒
            actionTimer.Tick += ActionTimer_Tick;

            // 启动计时器
            nowTimer.Start();

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
            comboBox4.SelectedItem = 0.ToString("D2");
            comboBox5.SelectedItem = 0.ToString("D2");
            comboBox6.SelectedItem = 0.ToString("D2");

            // 如果需要，可以禁用编辑功能，只允许选择
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox3.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox5.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox6.DropDownStyle = ComboBoxStyle.DropDownList;

            comboBoxActionType.Items.Add(new ComboBoxItem("关机", "s"));
            comboBoxActionType.Items.Add(new ComboBoxItem("重启", "r"));
            comboBoxActionType.Items.Add(new ComboBoxItem("注销", "l"));
            comboBoxActionType.SelectedIndex = 0;
        }
        // Token: 0x06000002 RID: 2 RVA: 0x00002060 File Offset: 0x00000260
        private void nowTimer_Tick(object sender, EventArgs e)
        {
            label_nowTime.Text = DateTime.Now.ToString("yyyy年  M月dd日  HH    时   mm    分  ss    秒");
        }

        private void buttonSetActionTime_Click(object sender, EventArgs e)
        {
            ScheduleActionAtSpecificTime();
        }

        private void buttonCountdownAction_Click(object sender, EventArgs e)
        {
            ScheduleActionInCountdown();
        }

        private void ScheduleActionAtSpecificTime()
        {
            try
            {
                // 获取操作类型
                var selectedItem = (ComboBoxItem)comboBoxActionType.SelectedItem;
                string action = selectedItem.Value;

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
                    MessageBox.Show("设定的时间已过，请重新设置！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    return;
                }

                // 计算时间差并执行命令
                TimeSpan timeSpan = scheduledTime - currentTime;
                int totalSeconds = (int)timeSpan.TotalSeconds;

                // 执行命令
                if (action == "h")
                {
                    // 休眠：使用 powercfg 命令（Windows 10/11 支持）
                    shutdown("rundll32.exe powrprof.dll, SetSuspendState 0,0,0");
                }
                else
                {
                    shutdown($"shutdown -{action} -t {totalSeconds}");
                }

                // 设置倒计时变量
                totalSecondsSet = totalSeconds;
                totalSecondsRemaining = totalSeconds;

                // 设置进度条
                progressBarShutdown.Minimum = 0;
                progressBarShutdown.Maximum = totalSecondsSet;

                // 更新剩余时间显示
                UpdateDisplay();

                // 启动倒计时定时器
                actionTimer.Start();

                string actionName = GetActionDisplayName(action);
                MessageBox.Show(
                    $"系统将在 {scheduledTime:yyyy-MM-dd HH:mm:ss} {actionName}。",
                    $"定时{actionName}已设置",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            catch (FormatException)
            {
                MessageBox.Show("请输入有效的数字！", "格式错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("时间设置出错: " + ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ScheduleActionInCountdown()
        {
            int hours = 0, minutes = 0, seconds = 0;

            if (!int.TryParse(comboBox4.Text, out hours))
            {
                MessageBox.Show("请输入有效的小时数！", "输入错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!int.TryParse(comboBox5.Text, out minutes))
            {
                MessageBox.Show("请输入有效的分钟数！", "输入错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!int.TryParse(comboBox6.Text, out seconds))
            {
                MessageBox.Show("请输入有效的秒数！", "输入错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int totalSeconds = (hours * 3600) + (minutes * 60) + seconds;

            if (totalSeconds <= 0)
            {
                MessageBox.Show("请输入大于 0 的时间！", "无效时间", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 获取操作类型
            var selectedItem = (ComboBoxItem)comboBoxActionType.SelectedItem;
            string action = selectedItem.Value;

            // 设置倒计时变量
            totalSecondsSet = totalSeconds;
            totalSecondsRemaining = totalSeconds;

            // 设置进度条
            progressBarShutdown.Minimum = 0;
            progressBarShutdown.Maximum = totalSecondsSet;

            // 显示剩余时间
            UpdateDisplay();

            // 启动倒计时定时器
            actionTimer.Start();

            try
            {
                if (action == "h")
                {
                    shutdown("rundll32.exe powrprof.dll, SetSuspendState 0,0,0");
                }
                else
                {
                    shutdown($"shutdown -{action} -t {totalSeconds}");
                }

                string actionName = GetActionDisplayName(action);
                MessageBox.Show(
                    $"系统将在 {FormatTimeSpan(TimeSpan.FromSeconds(totalSeconds))} 后{actionName}。",
                    $"定时{actionName}已设置",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("执行命令失败：" + ex.Message);
            }
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
                MessageBox.Show("执行定时命令失败: " + ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private void ActionTimer_Tick(object sender, EventArgs e)
        {
            if (totalSecondsRemaining > 0)
            {
                totalSecondsRemaining--;

                // 计算已完成的百分比
                int percentComplete = (int)((double)(totalSecondsSet - totalSecondsRemaining) / totalSecondsSet * 100);
                progressBarShutdown.Value = percentComplete;

                // 更新剩余时间显示
                UpdateDisplay();
            }
            else
            {
                actionTimer.Stop();
                ResetCountdownUI(); // 重置 UI
                MessageBox.Show("系统即将关机...", "倒计时结束", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void UpdateDisplay()
        {
            TimeSpan timeSpan = TimeSpan.FromSeconds(totalSecondsRemaining);
            string displayTime;

            if (timeSpan.TotalHours >= 1)
            {
                displayTime = $"{(int)timeSpan.TotalHours} 小时 {timeSpan.Minutes} 分 {timeSpan.Seconds} 秒";
            }
            else
            {
                displayTime = $"{timeSpan.Minutes} 分 {timeSpan.Seconds} 秒";
            }

            labelRemainingTime.Text = $"剩余时间：{displayTime}";

            //int percentComplete = (int)((double)(totalSecondsSet - totalSecondsRemaining) / totalSecondsSet * 100);
            //Text = $"定时操作工具 - {percentComplete}%";
            Text = $"定时操作工具 - {totalSecondsSet - totalSecondsRemaining}s / {totalSecondsSet}s";
        }
        string GetActionDisplayName(string command)
        {
            switch (command)
            {
                case "s":
                    return "关机";
                case "r":
                    return "重启";
                case "l":
                    return "注销";
                default:
                    return "操作";
            }
        }

        private string FormatTimeSpan(TimeSpan timeSpan)
        {
            if (timeSpan.TotalHours >= 1)
            {
                return $"{(int)timeSpan.TotalHours} 小时 {timeSpan.Minutes} 分 {timeSpan.Seconds} 秒";
            }
            else
            {
                return $"{timeSpan.Minutes} 分 {timeSpan.Seconds} 秒";
            }
        }

        private void buttonCancelShutdown_Click(object sender, EventArgs e)
        {
            try
            {
                shutdown("shutdown -a");
                actionTimer.Stop();
                ResetCountdownUI();
                MessageBox.Show("已取消定时操作。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("取消失败：" + ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ResetCountdownUI()
        {
            totalSecondsRemaining = 0;
            totalSecondsSet = 0;

            progressBarShutdown.Value = 0;
            labelRemainingTime.Text = "剩余时间：---";

            Text = "系统定时工具";
        }

        private int totalSecondsRemaining = 0;
        private int totalSecondsSet = 0;
        private Timer actionTimer;
        private string currentAction = "";
    }
}
