using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimerKronometre
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        int sayac = 0; //her defasında sayac 0 dan başlamasın diye global yaptık 
        private void timer1_Tick(object sender, EventArgs e)
        {

            sayac++;
            label1.Text = sayac.ToString();
            if (sayac == 10)
            {
                this.BackColor = Color.Green;
            }
            if (sayac == 15)
            {
               
                this.BackColor = Color.Red;
            }
            if (sayac==30)
            {
                this.BackColor = Color.Yellow;
                sayac  =0; //sayac başa dönecek
            } 
        }
    }
}
