namespace WinFormFishControl
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
            this.cbFish = new System.Windows.Forms.ComboBox();
            this.tbMax = new System.Windows.Forms.TextBox();
            this.tbTimeMin = new System.Windows.Forms.TextBox();
            this.lbTimeMax = new System.Windows.Forms.TextBox();
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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // cbFish
            // 
            this.cbFish.FormattingEnabled = true;
            this.cbFish.Items.AddRange(new object[] {
            "Минтай",
            "Семга",
            "Горбуша"});
            this.cbFish.Location = new System.Drawing.Point(191, 110);
            this.cbFish.Name = "cbFish";
            this.cbFish.Size = new System.Drawing.Size(126, 24);
            this.cbFish.TabIndex = 0;
            this.cbFish.Text = "Минтай";
            // 
            // tbMax
            // 
            this.tbMax.Location = new System.Drawing.Point(191, 157);
            this.tbMax.Multiline = true;
            this.tbMax.Name = "tbMax";
            this.tbMax.Size = new System.Drawing.Size(100, 22);
            this.tbMax.TabIndex = 1;
            // 
            // tbTimeMin
            // 
            this.tbTimeMin.Location = new System.Drawing.Point(323, 195);
            this.tbTimeMin.Multiline = true;
            this.tbTimeMin.Name = "tbTimeMin";
            this.tbTimeMin.Size = new System.Drawing.Size(100, 22);
            this.tbTimeMin.TabIndex = 2;
            // 
            // lbTimeMax
            // 
            this.lbTimeMax.Location = new System.Drawing.Point(323, 157);
            this.lbTimeMax.Multiline = true;
            this.lbTimeMax.Name = "lbTimeMax";
            this.lbTimeMax.Size = new System.Drawing.Size(100, 22);
            this.lbTimeMax.TabIndex = 3;
            // 
            // tbMin
            // 
            this.tbMin.Location = new System.Drawing.Point(191, 195);
            this.tbMin.Multiline = true;
            this.tbMin.Name = "tbMin";
            this.tbMin.Size = new System.Drawing.Size(100, 22);
            this.tbMin.TabIndex = 4;
            // 
            // tbTemp
            // 
            this.tbTemp.Location = new System.Drawing.Point(183, 267);
            this.tbTemp.Multiline = true;
            this.tbTemp.Name = "tbTemp";
            this.tbTemp.Size = new System.Drawing.Size(316, 22);
            this.tbTemp.TabIndex = 5;
            // 
            // btnDown
            // 
            this.btnDown.BackColor = System.Drawing.Color.IndianRed;
            this.btnDown.Location = new System.Drawing.Point(454, 226);
            this.btnDown.Name = "btnDown";
            this.btnDown.Size = new System.Drawing.Size(183, 34);
            this.btnDown.TabIndex = 7;
            this.btnDown.Text = "Загрузить из файла";
            this.btnDown.UseVisualStyleBackColor = false;
            // 
            // btnOtchet
            // 
            this.btnOtchet.BackColor = System.Drawing.Color.IndianRed;
            this.btnOtchet.Location = new System.Drawing.Point(210, 311);
            this.btnOtchet.Name = "btnOtchet";
            this.btnOtchet.Size = new System.Drawing.Size(213, 39);
            this.btnOtchet.TabIndex = 8;
            this.btnOtchet.Text = "Сформировать отчет";
            this.btnOtchet.UseVisualStyleBackColor = false;
            this.btnOtchet.Click += new System.EventHandler(this.btnOtchet_Click);
            // 
            // lbl_Fish
            // 
            this.lbl_Fish.AutoSize = true;
            this.lbl_Fish.Location = new System.Drawing.Point(76, 99);
            this.lbl_Fish.Name = "lbl_Fish";
            this.lbl_Fish.Size = new System.Drawing.Size(0, 17);
            this.lbl_Fish.TabIndex = 9;
            // 
            // lbTime
            // 
            this.lbTime.AutoSize = true;
            this.lbTime.Location = new System.Drawing.Point(348, 137);
            this.lbTime.Name = "lbTime";
            this.lbTime.Size = new System.Drawing.Size(50, 17);
            this.lbTime.TabIndex = 11;
            this.lbTime.Text = "Время";
            // 
            // lbMMTemp
            // 
            this.lbMMTemp.AutoSize = true;
            this.lbMMTemp.Location = new System.Drawing.Point(195, 137);
            this.lbMMTemp.Name = "lbMMTemp";
            this.lbMMTemp.Size = new System.Drawing.Size(96, 17);
            this.lbMMTemp.TabIndex = 12;
            this.lbMMTemp.Text = "Температура";
            // 
            // lbTemp
            // 
            this.lbTemp.AutoSize = true;
            this.lbTemp.Location = new System.Drawing.Point(89, 272);
            this.lbTemp.Name = "lbTemp";
            this.lbTemp.Size = new System.Drawing.Size(96, 17);
            this.lbTemp.TabIndex = 13;
            this.lbTemp.Text = "Температура";
            // 
            // lbDate
            // 
            this.lbDate.AutoSize = true;
            this.lbDate.Location = new System.Drawing.Point(143, 237);
            this.lbDate.Name = "lbDate";
            this.lbDate.Size = new System.Drawing.Size(42, 17);
            this.lbDate.TabIndex = 14;
            this.lbDate.Text = "Дата";
            // 
            // lbMin
            // 
            this.lbMin.AutoSize = true;
            this.lbMin.Location = new System.Drawing.Point(155, 200);
            this.lbMin.Name = "lbMin";
            this.lbMin.Size = new System.Drawing.Size(30, 17);
            this.lbMin.TabIndex = 15;
            this.lbMin.Text = "min";
            // 
            // lbMax
            // 
            this.lbMax.AutoSize = true;
            this.lbMax.Location = new System.Drawing.Point(152, 162);
            this.lbMax.Name = "lbMax";
            this.lbMax.Size = new System.Drawing.Size(33, 17);
            this.lbMax.TabIndex = 16;
            this.lbMax.Text = "max";
            // 
            // lbFish
            // 
            this.lbFish.AutoSize = true;
            this.lbFish.Location = new System.Drawing.Point(112, 117);
            this.lbFish.Name = "lbFish";
            this.lbFish.Size = new System.Drawing.Size(73, 17);
            this.lbFish.TabIndex = 17;
            this.lbFish.Text = "Вид рыбы";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "dd.MM.yyyy HH:m";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(191, 237);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(232, 22);
            this.dateTimePicker1.TabIndex = 18;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.dateTimePicker1);
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
            this.Controls.Add(this.lbTimeMax);
            this.Controls.Add(this.tbTimeMin);
            this.Controls.Add(this.tbMax);
            this.Controls.Add(this.cbFish);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbFish;
        private System.Windows.Forms.TextBox tbMax;
        private System.Windows.Forms.TextBox tbTimeMin;
        private System.Windows.Forms.TextBox lbTimeMax;
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
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}

