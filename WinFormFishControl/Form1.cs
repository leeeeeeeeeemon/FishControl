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
        public Semga semga = new Semga();
        PinkSalmon pinkSalmon = new PinkSalmon();
        Pollock pollock = new Pollock();

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
                if (cbFish.SelectedItem == "Семга")
                {
                    if (semga.ComplianceConditions(dtDate.Value, temps))
                    {
                        Form2 newForm = new Form2(semga.result, semga.maxTempBelow, semga.time);
                      
                        newForm.Show();
                    }
                    else
                    {
                        MessageBox.Show("Порог не превышен");
                    }
                }

                if (cbFish.SelectedItem == "Горбуша")
                {
                    if (pinkSalmon.ComplianceConditions(dtDate.Value, temps))
                    {
                        Form2 newForm = new Form2(pinkSalmon.result, pinkSalmon.maxTempBelow, pinkSalmon.time);
                       
                        newForm.Show();
                    }
                    else
                    {
                        MessageBox.Show("Порог не превышен");
                    }
                }

                if (cbFish.SelectedItem == "Минтай")
                {
                    if (pollock.ComplianceConditions(dtDate.Value, temps))
                    {
                        Form2 newForm = new Form2(pollock.result, pollock.maxTempBelow, pollock.time);
                       
                        newForm.Show();
                    }
                    else
                    {
                        MessageBox.Show("Порог не превышен");
                    }
                }
            }
        }

        private void cbFish_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbFish.SelectedItem == "Семга")
            {
                tbMax.Text = Convert.ToString(semga.maxTemp);
                tbMin.Text = Convert.ToString(semga.minTemp);
                tbTimeMax.Text = Convert.ToString(semga.maxTempTime);
                tbTimeMin.Text = Convert.ToString(semga.minTempTime);
            }

            else if (cbFish.SelectedItem == "Горбуша")
            {
                tbMax.Text = Convert.ToString(pinkSalmon.maxTemp);
                tbMin.Text = Convert.ToString(pinkSalmon.minTemp);
                tbTimeMax.Text = Convert.ToString(pinkSalmon.maxTempTime);
                tbTimeMin.Text = Convert.ToString(pinkSalmon.minTempTime);
            }

            else if (cbFish.SelectedItem == "Минтай")
            {
                tbMax.Text = Convert.ToString(pollock.maxTemp);
                tbTimeMax.Text = Convert.ToString(pollock.maxTempTime);
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

      
    }
}
