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


    //IMPORTANTE*****************
    //CONTRASEÑA PARA INGRESAR: samircito21
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

          
           
        }

   

        
       

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)  
        {
            Form2 ReglaDeTres = new Form2();

            ReglaDeTres.Show();




        }

      


        private void lbBienvenida_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBoxButtons botones = MessageBoxButtons.YesNo;
            DialogResult dialog = MessageBox.Show("¿Seguro que desea salir?", "Está seguro", botones,
                MessageBoxIcon.Question);

            if (dialog == DialogResult.Yes)
            {

             
                this.Close();
               

            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Form3 pitagoras = new Form3();
            pitagoras.Show();
        }
    }
}
