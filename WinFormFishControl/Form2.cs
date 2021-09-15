using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormFishControl
{
    public partial class Form2 : Form
    {
        List<string> results;
        bool belowMax;
        string fishName;
        DateTime date;
        public Form2(List<string> r, bool maxTempBelow, int timeBelow, string fishName, DateTime date)
        {
            InitializeComponent();
            results = r;
            belowMax = maxTempBelow;
            this.fishName = fishName;
            this.date = date;
            if (maxTempBelow)
            {
                tbOtchet.Text = "Порог превышен на " + TimeSpan.FromMinutes(timeBelow * 10);
            }
            else
            {
                tbOtchet.Text = "Порог превышен на " + TimeSpan.FromMinutes(timeBelow * 10);
            }

            for (int i = 0; i < results.Count; i++) 
            {
                tbInfo.Text += results[i].ToString() + Environment.NewLine; 
            }
           
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            saveFD.ShowDialog();
            if (saveFD.FileName != "")
            {
                using (System.IO.StreamWriter sw = new System.IO.StreamWriter(saveFD.FileName))
                {
                    sw.WriteLine($"  {fishName}  {date}");
                    sw.WriteLine($"  Дата                    Норма       Факт                Отклонение");
                    sw.WriteLine(tbInfo.Text);                
                }
            }
        }
    }
}
