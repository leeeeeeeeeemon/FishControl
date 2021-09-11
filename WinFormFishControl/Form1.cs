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
        public Object fish;
        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnOtchet_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(Convert.ToString(dateTimePicker1))|| String.IsNullOrEmpty(tbTemp.Text))
            {
                MessageBox.Show("Заполните дату и температуры");
            }
            else
            {
                
                Form2 newForm = new Form2();
                newForm.Show();
            }
           
        }

        private void cbFish_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbFish.SelectedItem == "Семга")
            {
                Semga f = new Semga();
                tbMax.Text = Convert.ToString(f.maxTemp);
                tbMin.Text = Convert.ToString(f.minTemp);
                tbTimeMax.Text = Convert.ToString(f.maxTempTime);
                tbTimeMin.Text = Convert.ToString(f.minTempTime);
            }
            else if (cbFish.SelectedItem == "Горбуша")
            {
                PinkSalmon f = new PinkSalmon();
                tbMax.Text = Convert.ToString(f.maxTemp);
                tbMin.Text = Convert.ToString(f.minTemp);
                tbTimeMax.Text = Convert.ToString(f.maxTempTime);
                tbTimeMin.Text = Convert.ToString(f.minTempTime);
            }
            else if (cbFish.SelectedItem == "Минтай")
            {
                Pollock f = new Pollock();
                tbMax.Text = Convert.ToString(f.maxTemp);
                tbTimeMax.Text = Convert.ToString(f.maxTempTime);
            }
        }
    }
}
