using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LaReglaDeTres
{
    public partial class Splash : Form
    {

       
        public Splash()
        {
            InitializeComponent();

            progressBar1.ForeColor = Color.Red;

        }

        private void Splash_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer1.Interval = 1;
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)

            
        {
            progressBar1.Increment(1);


            if(progressBar1.Value == 400)
            {
                timer1.Stop();
                

                Ingreso ing = new Ingreso();
               this.Hide();
                ing.Show();

            }
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
