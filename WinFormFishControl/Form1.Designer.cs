﻿namespace WinFormFishControl
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbMax = new System.Windows.Forms.TextBox();
            this.tbTimeMin = new System.Windows.Forms.TextBox();
            this.tbTimeMax = new System.Windows.Forms.TextBox();
            this.tbMin = new System.Windows.Forms.TextBox();
            this.tbTemp = new System.Windows.Forms.TextBox();
            this.btnDown = new System.Windows.Forms.Button();
            this.btnOtchet = new System.Windows.Forms.Button();
            this.lbl_Fish = new System.Windows.Forms.Label();
            this.lbTime = new System.Windows.Forms.Label();
            this.lbMMTemp = new System.Windows.Forms.Label();
            this.lbTemp = new System.Windows.Forms.Label();
            this.lbDate = new System.Windows.Forms.Label();
            this.lbMin = new System.Windows.Forms.Label();
            this.lbMax = new System.Windows.Forms.Label();
            this.lbFish = new System.Windows.Forms.Label();
            this.dtDate = new System.Windows.Forms.DateTimePicker();
            this.openFD = new System.Windows.Forms.OpenFileDialog();
            this.tbFish = new System.Windows.Forms.TextBox();
            this.btnLoadFish = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbMax
            // 
            this.tbMax.Enabled = false;
            this.tbMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbMax.Location = new System.Drawing.Point(89, 105);
            this.tbMax.Margin = new System.Windows.Forms.Padding(2);
            this.tbMax.Multiline = true;
            this.tbMax.Name = "tbMax";
            this.tbMax.Size = new System.Drawing.Size(139, 29);
            this.tbMax.TabIndex = 1;
            // 
            // tbTimeMin
            // 
            this.tbTimeMin.Enabled = false;
            this.tbTimeMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbTimeMin.Location = new System.Drawing.Point(244, 157);
            this.tbTimeMin.Margin = new System.Windows.Forms.Padding(2);
            this.tbTimeMin.Multiline = true;
            this.tbTimeMin.Name = "tbTimeMin";
            this.tbTimeMin.Size = new System.Drawing.Size(135, 34);
            this.tbTimeMin.TabIndex = 2;
            // 
            // tbTimeMax
            // 
            this.tbTimeMax.Enabled = false;
            this.tbTimeMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbTimeMax.Location = new System.Drawing.Point(244, 105);
            this.tbTimeMax.Margin = new System.Windows.Forms.Padding(2);
            this.tbTimeMax.Multiline = true;
            this.tbTimeMax.Name = "tbTimeMax";
            this.tbTimeMax.Size = new System.Drawing.Size(135, 31);
            this.tbTimeMax.TabIndex = 3;
            // 
            // tbMin
            // 
            this.tbMin.Enabled = false;
            this.tbMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbMin.Location = new System.Drawing.Point(88, 157);
            this.tbMin.Margin = new System.Windows.Forms.Padding(2);
            this.tbMin.Multiline = true;
            this.tbMin.Name = "tbMin";
            this.tbMin.Size = new System.Drawing.Size(140, 34);
            this.tbMin.TabIndex = 4;
            // 
            // tbTemp
            // 
            this.tbTemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbTemp.Location = new System.Drawing.Point(154, 309);
            this.tbTemp.Margin = new System.Windows.Forms.Padding(2);
            this.tbTemp.Multiline = true;
            this.tbTemp.Name = "tbTemp";
            this.tbTemp.Size = new System.Drawing.Size(468, 33);
            this.tbTemp.TabIndex = 5;
            // 
            // btnDown
            // 
            this.btnDown.BackColor = System.Drawing.Color.IndianRed;
            this.btnDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDown.Location = new System.Drawing.Point(395, 251);
            this.btnDown.Margin = new System.Windows.Forms.Padding(2);
            this.btnDown.Name = "btnDown";
            this.btnDown.Size = new System.Drawing.Size(213, 49);
            this.btnDown.TabIndex = 7;
            this.btnDown.Text = "Загрузить из файла";
            this.btnDown.UseVisualStyleBackColor = false;
            this.btnDown.Click += new System.EventHandler(this.btnDown_Click);
            // 
            // btnOtchet
            // 
            this.btnOtchet.BackColor = System.Drawing.Color.IndianRed;
            this.btnOtchet.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnOtchet.Location = new System.Drawing.Point(221, 374);
            this.btnOtchet.Margin = new System.Windows.Forms.Padding(2);
            this.btnOtchet.Name = "btnOtchet";
            this.btnOtchet.Size = new System.Drawing.Size(230, 52);
            this.btnOtchet.TabIndex = 8;
            this.btnOtchet.Text = "Сформировать отчет";
            this.btnOtchet.UseVisualStyleBackColor = false;
            this.btnOtchet.Click += new System.EventHandler(this.btnOtchet_Click);
            // 
            // lbl_Fish
            // 
            this.lbl_Fish.AutoSize = true;
            this.lbl_Fish.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_Fish.Location = new System.Drawing.Point(57, 80);
            this.lbl_Fish.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Fish.Name = "lbl_Fish";
            this.lbl_Fish.Size = new System.Drawing.Size(0, 24);
            this.lbl_Fish.TabIndex = 9;
            // 
            // lbTime
            // 
            this.lbTime.AutoSize = true;
            this.lbTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbTime.Location = new System.Drawing.Point(286, 77);
            this.lbTime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbTime.Name = "lbTime";
            this.lbTime.Size = new System.Drawing.Size(67, 24);
            this.lbTime.TabIndex = 11;
            this.lbTime.Text = "Время";
            // 
            // lbMMTemp
            // 
            this.lbMMTemp.AutoSize = true;
            this.lbMMTemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbMMTemp.Location = new System.Drawing.Point(99, 77);
            this.lbMMTemp.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbMMTemp.Name = "lbMMTemp";
            this.lbMMTemp.Size = new System.Drawing.Size(129, 24);
            this.lbMMTemp.TabIndex = 12;
            this.lbMMTemp.Text = "Температура";
            // 
            // lbTemp
            // 
            this.lbTemp.AutoSize = true;
            this.lbTemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbTemp.Location = new System.Drawing.Point(20, 309);
            this.lbTemp.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbTemp.Name = "lbTemp";
            this.lbTemp.Size = new System.Drawing.Size(129, 24);
            this.lbTemp.TabIndex = 13;
            this.lbTemp.Text = "Температура";
            // 
            // lbDate
            // 
            this.lbDate.AutoSize = true;
            this.lbDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbDate.Location = new System.Drawing.Point(23, 271);
            this.lbDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbDate.Name = "lbDate";
            this.lbDate.Size = new System.Drawing.Size(54, 24);
            this.lbDate.TabIndex = 14;
            this.lbDate.Text = "Дата";
            // 
            // lbMin
            // 
            this.lbMin.AutoSize = true;
            this.lbMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbMin.Location = new System.Drawing.Point(31, 157);
            this.lbMin.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbMin.Name = "lbMin";
            this.lbMin.Size = new System.Drawing.Size(41, 24);
            this.lbMin.TabIndex = 15;
            this.lbMin.Text = "Min";
            // 
            // lbMax
            // 
            this.lbMax.AutoSize = true;
            this.lbMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbMax.Location = new System.Drawing.Point(31, 105);
            this.lbMax.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbMax.Name = "lbMax";
            this.lbMax.Size = new System.Drawing.Size(46, 24);
            this.lbMax.TabIndex = 16;
            this.lbMax.Text = "Max";
            // 
            // lbFish
            // 
            this.lbFish.AutoSize = true;
            this.lbFish.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbFish.Location = new System.Drawing.Point(19, 41);
            this.lbFish.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbFish.Name = "lbFish";
            this.lbFish.Size = new System.Drawing.Size(98, 24);
            this.lbFish.TabIndex = 17;
            this.lbFish.Text = "Вид рыбы";
            // 
            // dtDate
            // 
            this.dtDate.CustomFormat = "dd.MM.yyyy HH:m";
            this.dtDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dtDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtDate.Location = new System.Drawing.Point(154, 271);
            this.dtDate.Margin = new System.Windows.Forms.Padding(2);
            this.dtDate.Name = "dtDate";
            this.dtDate.Size = new System.Drawing.Size(188, 29);
            this.dtDate.TabIndex = 18;
            // 
            // openFD
            // 
            this.openFD.FileName = "openFD";
            // 
            // tbFish
            // 
            this.tbFish.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbFish.Location = new System.Drawing.Point(128, 41);
            this.tbFish.Name = "tbFish";
            this.tbFish.Size = new System.Drawing.Size(164, 29);
            this.tbFish.TabIndex = 19;
            // 
            // btnLoadFish
            // 
            this.btnLoadFish.BackColor = System.Drawing.Color.IndianRed;
            this.btnLoadFish.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnLoadFish.Location = new System.Drawing.Point(430, 41);
            this.btnLoadFish.Margin = new System.Windows.Forms.Padding(2);
            this.btnLoadFish.Name = "btnLoadFish";
            this.btnLoadFish.Size = new System.Drawing.Size(213, 49);
            this.btnLoadFish.TabIndex = 20;
            this.btnLoadFish.Text = "Загрузить рыбу";
            this.btnLoadFish.UseVisualStyleBackColor = false;
            this.btnLoadFish.Click += new System.EventHandler(this.btnLoadFish_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(661, 450);
            this.Controls.Add(this.btnLoadFish);
            this.Controls.Add(this.tbFish);
            this.Controls.Add(this.dtDate);
            this.Controls.Add(this.lbFish);
            this.Controls.Add(this.lbMax);
            this.Controls.Add(this.lbMin);
            this.Controls.Add(this.lbDate);
            this.Controls.Add(this.lbTemp);
            this.Controls.Add(this.lbMMTemp);
            this.Controls.Add(this.lbTime);
            this.Controls.Add(this.lbl_Fish);
            this.Controls.Add(this.btnOtchet);
            this.Controls.Add(this.btnDown);
            this.Controls.Add(this.tbTemp);
            this.Controls.Add(this.tbMin);
            this.Controls.Add(this.tbTimeMax);
            this.Controls.Add(this.tbTimeMin);
            this.Controls.Add(this.tbMax);
            this.Name = "Form1";
            this.Text = "Мониторинг температуры";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tbMax;
        private System.Windows.Forms.TextBox tbTimeMin;
        private System.Windows.Forms.TextBox tbTimeMax;
        private System.Windows.Forms.TextBox tbMin;
        private System.Windows.Forms.TextBox tbTemp;
        private System.Windows.Forms.Button btnDown;
        private System.Windows.Forms.Button btnOtchet;
        private System.Windows.Forms.Label lbl_Fish;
        private System.Windows.Forms.Label lbTime;
        private System.Windows.Forms.Label lbMMTemp;
        private System.Windows.Forms.Label lbTemp;
        private System.Windows.Forms.Label lbDate;
        private System.Windows.Forms.Label lbMin;
        private System.Windows.Forms.Label lbMax;
        private System.Windows.Forms.Label lbFish;
        private System.Windows.Forms.DateTimePicker dtDate;
        private System.Windows.Forms.OpenFileDialog openFD;
        private System.Windows.Forms.TextBox tbFish;
        private System.Windows.Forms.Button btnLoadFish;
    }
}

