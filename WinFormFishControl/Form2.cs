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
        public Form2(List<string> r, bool maxTempBelow, int timeBelow )
        {
            InitializeComponent();
            results = r;
            belowMax = maxTempBelow;
            if (maxTempBelow)
            {
                tbOtchet.Text = "Порог максимально допустимой температуры превышен на " + TimeSpan.FromMinutes(timeBelow * 10) + " минут";
            }
            else
            {
                tbOtchet.Text = "Порог минимально допустимой температуры превышен на " + TimeSpan.FromMinutes(timeBelow * 10) + " минут";
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
                    sw.WriteLine(tbInfo.Text);
                }
            }
        }
    }
}
