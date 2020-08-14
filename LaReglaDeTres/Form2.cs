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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            
        }

      

        public void Calculo()
        {

            double cantidad = 0;
            double totaldefinitivo = 0;

            cantidad = Convert.ToDouble(txtDinero.Text);
            

            totaldefinitivo = cantidad * 3 / 60;

            string b = totaldefinitivo.ToString();

            pictureBox1.Visible = true;

           
            txtTotal.Text = b;
            

        }

        internal static void show()
        {
            throw new NotImplementedException();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {

                Calculo();

            }

            catch
            {

                /*VALIDACION PARA CAMPO VACIO*/
                errorProvider1.Clear();
                txtDinero.Text = "";
                txtDinero.Focus();

                if (txtDinero.Text == "")
                {
                    errorProvider1.SetError(txtDinero, "Escribe un número");
                    txtDinero.Focus();
                }
                else
                {
                    Calculo();


                }



            }

        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            txtDinero.Text = " ";
            txtTotal.Text = " ";
            pictureBox1.Visible = false;
            errorProvider1.Clear();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            MessageBoxButtons botones = MessageBoxButtons.YesNo;
            DialogResult dialog = MessageBox.Show("¿Seguro que desea salir?", "Está seguro", botones);

            if (dialog == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtTotal_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDinero_TextChanged(object sender, EventArgs e)
        {

        }

       

        private void btnmenu_Click(object sender, EventArgs e)
        {
            this.Close();
           
           
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
