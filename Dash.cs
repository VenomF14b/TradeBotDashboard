using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace TradeBotDashboard
{
    public partial class Dash : Form
    {
        public Dash()
        {
            InitializeComponent();
        }

        private void Button_StartTrading_Click(object sender, EventArgs e)
        {
            string batchFilePath = @"EURUSDmain.bat";

            Process process = new Process();
            process.StartInfo.FileName = "cmd.exe";
            process.StartInfo.Arguments = $"/c \"{batchFilePath}\"";
            process.Start();
        }

        private void Button_StopTrading_Click(object sender, EventArgs e)
        {
            // Find the Python process and kill it
            Process[] runningProcesses = Process.GetProcessesByName("python");
            foreach (Process process in runningProcesses)
            {
                process.Kill();
            }
        }

        private void Button_LoadDefault_Click(object sender, EventArgs e)
        {
            TextBox_TrainingDataRequest.Text ="5";
        }
    }
}
