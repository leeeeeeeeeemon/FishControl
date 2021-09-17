using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibrary;

namespace WinFormFishControl
{
    public partial class Form1 : Form
    {
        Fish fish = new Fish();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOtchet_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(Convert.ToString(dtDate)) || String.IsNullOrEmpty(tbTemp.Text))
            {
                MessageBox.Show("Заполните дату и температуры");
            }

            else
            {
                string[] temps = tbTemp.Text.Split(' ');
                if (fish.ComplianceConditions(dtDate.Value, temps, Convert.ToInt32(tbMax.Text), Convert.ToInt32(tbTimeMax.Text), Convert.ToInt32(tbMin.Text), Convert.ToInt32(tbTimeMin.Text)))
                {
                    Form2 newForm = new Form2(fish.result, /*fish.maxTempBelow*/ fish.time, tbFish.Text, dtDate.Value);
                    newForm.Show();
                    newForm.Location = this.Location;
                }

                else
                {
                    MessageBox.Show("Порог не превышен");
                }             
            }
        }

        private void btnDown_Click(object sender, EventArgs e)
        {
            openFD.ShowDialog();
            if (openFD.FileName != "")
            {
                using (System.IO.StreamReader sw = new System.IO.StreamReader(openFD.FileName))
                {
                    string[] tempsDate = sw.ReadLine().ToString().Split(';');
                    string Data = tempsDate[0];
                    string temps = tempsDate[1];

                    string[] dateAndTimeFish = Data.Split(' ');
                    string[] dateNumbers = dateAndTimeFish[0].Split('.');
                    string[] timeNumbers = dateAndTimeFish[1].Split(':');
                    DateTime dateFish = new DateTime(Convert.ToInt32(dateNumbers[2]), Convert.ToInt32(dateNumbers[1]), Convert.ToInt32(dateNumbers[0]), Convert.ToInt32(timeNumbers[0]), Convert.ToInt32(timeNumbers[1]), 0);
                    dtDate.Value = dateFish;
                    tbTemp.Text = temps;
                }
            }
        }

        private void btnLoadFish_Click(object sender, EventArgs e)
        {
            openFD.ShowDialog();
            using (System.IO.StreamReader sw = new System.IO.StreamReader(openFD.FileName))
            {
                string[] nameFishAndTemps = sw.ReadLine().ToString().Split(';');
                string[] maxTempAndTime = nameFishAndTemps[1].Split(' ');
                string[] minTempAndTime = nameFishAndTemps[2].Split(' ');
                tbMax.Text = maxTempAndTime[0];
                tbTimeMax.Text = maxTempAndTime[1];
                tbMin.Text = minTempAndTime[0];
                tbTimeMin.Text = minTempAndTime[1];
                tbFish.Text = nameFishAndTemps[0];
            }
        }
    }
}
