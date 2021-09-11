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

             
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
