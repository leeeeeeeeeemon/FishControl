
namespace WinFormFishControl
{
    partial class Form2
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
            this.lbOtchet = new System.Windows.Forms.Label();
            this.tbOtchet = new System.Windows.Forms.TextBox();
            this.tbInfo = new System.Windows.Forms.TextBox();
            this.lbTime = new System.Windows.Forms.Label();
            this.lbFact = new System.Windows.Forms.Label();
            this.lbNorm = new System.Windows.Forms.Label();
            this.lbNotNorm = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbOtchet
            // 
            this.lbOtchet.AutoSize = true;
            this.lbOtchet.Location = new System.Drawing.Point(34, 54);
            this.lbOtchet.Name = "lbOtchet";
            this.lbOtchet.Size = new System.Drawing.Size(49, 17);
            this.lbOtchet.TabIndex = 0;
            this.lbOtchet.Text = "Отчёт";
            // 
            // tbOtchet
            // 
            this.tbOtchet.Location = new System.Drawing.Point(133, 54);
            this.tbOtchet.Name = "tbOtchet";
            this.tbOtchet.Size = new System.Drawing.Size(574, 22);
            this.tbOtchet.TabIndex = 1;
            // 
            // tbInfo
            // 
            this.tbInfo.Location = new System.Drawing.Point(133, 140);
            this.tbInfo.Multiline = true;
            this.tbInfo.Name = "tbInfo";
            this.tbInfo.Size = new System.Drawing.Size(574, 327);
            this.tbInfo.TabIndex = 2;
            // 
            // lbTime
            // 
            this.lbTime.AutoSize = true;
            this.lbTime.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbTime.Location = new System.Drawing.Point(178, 160);
            this.lbTime.Name = "lbTime";
            this.lbTime.Size = new System.Drawing.Size(50, 17);
            this.lbTime.TabIndex = 3;
            this.lbTime.Text = "Время";
            // 
            // lbFact
            // 
            this.lbFact.AutoSize = true;
            this.lbFact.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbFact.Location = new System.Drawing.Point(267, 160);
            this.lbFact.Name = "lbFact";
            this.lbFact.Size = new System.Drawing.Size(43, 17);
            this.lbFact.TabIndex = 10;
            this.lbFact.Text = "Факт";
            this.lbFact.Click += new System.EventHandler(this.label2_Click);
            // 
            // lbNorm
            // 
            this.lbNorm.AutoSize = true;
            this.lbNorm.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbNorm.Location = new System.Drawing.Point(368, 160);
            this.lbNorm.Name = "lbNorm";
            this.lbNorm.Size = new System.Drawing.Size(51, 17);
            this.lbNorm.TabIndex = 11;
            this.lbNorm.Text = "Норма";
            // 
            // lbNotNorm
            // 
            this.lbNotNorm.AutoSize = true;
            this.lbNotNorm.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbNotNorm.Location = new System.Drawing.Point(510, 160);
            this.lbNotNorm.Name = "lbNotNorm";
            this.lbNotNorm.Size = new System.Drawing.Size(155, 17);
            this.lbNotNorm.TabIndex = 12;
            this.lbNotNorm.Text = "Отклонение от нормы";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 490);
            this.Controls.Add(this.lbNotNorm);
            this.Controls.Add(this.lbNorm);
            this.Controls.Add(this.lbFact);
            this.Controls.Add(this.lbTime);
            this.Controls.Add(this.tbInfo);
            this.Controls.Add(this.tbOtchet);
            this.Controls.Add(this.lbOtchet);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbOtchet;
        private System.Windows.Forms.TextBox tbOtchet;
        private System.Windows.Forms.TextBox tbInfo;
        private System.Windows.Forms.Label lbTime;
        private System.Windows.Forms.Label lbFact;
        private System.Windows.Forms.Label lbNorm;
        private System.Windows.Forms.Label lbNotNorm;
    }
}