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
            TextBox_TrainingDataRequest.Text = "5";
            TextBox_TrainingDataSelect.Text = "5040";
            TextBox_TrainingEpochs.Text = "5";
            TextBox_TrainingBatchSize.Text = "1";
            TextBox_RunningDataRequest.Text = "1";
            TextBox_RunningWinLossDataRequest.Text = "1";
            TextBox_RunningDataSelect.Text = "4";
            TextBox_RunningWinLossDataSelect.Text = "5";
            TextBox_RunningDataSplit.Text = "0.9968";
            TextBox_RunningEpochs.Text = "5";
            TextBox_RunningBatchSize.Text = "1";
            TextBox_BuyVolume.Text = "0.01";
            TextBox_BuyStopLoss.Text = "0.0001";
            TextBox_BuyTakeProfit.Text = "0.0001";
            TextBox_BuyIdentity.Text = "123456";
            TextBox_SellVolume.Text = "0.01";
            TextBox_SellStopLoss.Text = "0.0001";
            TextBox_SellTakeProfit.Text = "0.0001";
            TextBox_SellIdentity.Text = "123456";
        }
    }
}
