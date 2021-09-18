
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
            this.btnSave = new System.Windows.Forms.Button();
            this.saveFD = new System.Windows.Forms.SaveFileDialog();
            this.btnRefresh2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbOtchet
            // 
            this.lbOtchet.AutoSize = true;
            this.lbOtchet.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbOtchet.Location = new System.Drawing.Point(25, 29);
            this.lbOtchet.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbOtchet.Name = "lbOtchet";
            this.lbOtchet.Size = new System.Drawing.Size(66, 24);
            this.lbOtchet.TabIndex = 0;
            this.lbOtchet.Text = "Отчёт";
            // 
            // tbOtchet
            // 
            this.tbOtchet.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbOtchet.Location = new System.Drawing.Point(95, 29);
            this.tbOtchet.Margin = new System.Windows.Forms.Padding(2);
            this.tbOtchet.Name = "tbOtchet";
            this.tbOtchet.Size = new System.Drawing.Size(432, 29);
            this.tbOtchet.TabIndex = 1;
            this.tbOtchet.TabStop = false;
            // 
            // tbInfo
            // 
            this.tbInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbInfo.Location = new System.Drawing.Point(57, 96);
            this.tbInfo.Margin = new System.Windows.Forms.Padding(2);
            this.tbInfo.Multiline = true;
            this.tbInfo.Name = "tbInfo";
            this.tbInfo.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbInfo.Size = new System.Drawing.Size(539, 290);
            this.tbInfo.TabIndex = 2;
            this.tbInfo.TabStop = false;
            // 
            // lbTime
            // 
            this.lbTime.AutoSize = true;
            this.lbTime.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbTime.Location = new System.Drawing.Point(117, 70);
            this.lbTime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbTime.Name = "lbTime";
            this.lbTime.Size = new System.Drawing.Size(67, 24);
            this.lbTime.TabIndex = 3;
            this.lbTime.Text = "Время";
            // 
            // lbFact
            // 
            this.lbFact.AutoSize = true;
            this.lbFact.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbFact.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbFact.Location = new System.Drawing.Point(238, 70);
            this.lbFact.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbFact.Name = "lbFact";
            this.lbFact.Size = new System.Drawing.Size(55, 24);
            this.lbFact.TabIndex = 10;
            this.lbFact.Text = "Факт";
            // 
            // lbNorm
            // 
            this.lbNorm.AutoSize = true;
            this.lbNorm.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbNorm.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbNorm.Location = new System.Drawing.Point(297, 70);
            this.lbNorm.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbNorm.Name = "lbNorm";
            this.lbNorm.Size = new System.Drawing.Size(68, 24);
            this.lbNorm.TabIndex = 11;
            this.lbNorm.Text = "Норма";
            // 
            // lbNotNorm
            // 
            this.lbNotNorm.AutoSize = true;
            this.lbNotNorm.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbNotNorm.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbNotNorm.Location = new System.Drawing.Point(386, 70);
            this.lbNotNorm.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbNotNorm.Name = "lbNotNorm";
            this.lbNotNorm.Size = new System.Drawing.Size(210, 24);
            this.lbNotNorm.TabIndex = 12;
            this.lbNotNorm.Text = "Отклонение от нормы";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.IndianRed;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSave.Location = new System.Drawing.Point(223, 390);
            this.btnSave.Margin = new System.Windows.Forms.Padding(2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(213, 49);
            this.btnSave.TabIndex = 13;
            this.btnSave.Text = "Сохранить";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // saveFD
            // 
            this.saveFD.DefaultExt = "txt";
            // 
            // btnRefresh2
            // 
            this.btnRefresh2.BackColor = System.Drawing.Color.IndianRed;
            this.btnRefresh2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnRefresh2.Location = new System.Drawing.Point(472, 390);
            this.btnRefresh2.Margin = new System.Windows.Forms.Padding(2);
            this.btnRefresh2.Name = "btnRefresh2";
            this.btnRefresh2.Size = new System.Drawing.Size(159, 49);
            this.btnRefresh2.TabIndex = 14;
            this.btnRefresh2.Text = "Очистить";
            this.btnRefresh2.UseVisualStyleBackColor = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(661, 450);
            this.Controls.Add(this.btnRefresh2);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lbNotNorm);
            this.Controls.Add(this.lbNorm);
            this.Controls.Add(this.lbFact);
            this.Controls.Add(this.lbTime);
            this.Controls.Add(this.tbInfo);
            this.Controls.Add(this.tbOtchet);
            this.Controls.Add(this.lbOtchet);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Отчет";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form2_FormClosing);
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
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.SaveFileDialog saveFD;
        private System.Windows.Forms.Button btnRefresh2;
    }
}