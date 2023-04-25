
namespace TradeBotDashboard
{
    partial class Dash
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
            this.Button_StartTrading = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Button_StartTrading
            // 
            this.Button_StartTrading.AutoSize = true;
            this.Button_StartTrading.Location = new System.Drawing.Point(452, 236);
            this.Button_StartTrading.Name = "Button_StartTrading";
            this.Button_StartTrading.Size = new System.Drawing.Size(86, 23);
            this.Button_StartTrading.TabIndex = 0;
            this.Button_StartTrading.Text = "Start Trading";
            this.Button_StartTrading.UseVisualStyleBackColor = true;
            this.Button_StartTrading.Click += new System.EventHandler(this.Button_StartTrading_Click);
            // 
            // Dash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Button_StartTrading);
            this.Name = "Dash";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Button_StartTrading;
    }
}

