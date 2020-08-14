using System;
using System.Text;
using System.Windows.Forms;

namespace LaReglaDeTres
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();

            pictureBoxSolucion.Visible = false;
        }


      

        public void operacion(){            //Metodo de la operacion 

            double distancia = 0;
            double distanciaCuadrada = 0;

            double altura = 2500;

            double subtotal = 0;


            distancia = Convert.ToDouble(txtDistancia.Text);
            distanciaCuadrada = distancia * distancia;

            subtotal = distanciaCuadrada + altura;

            double raiz = Math.Sqrt(subtotal);    //Uso de la funcion para Pi

            

            string total = raiz.ToString();

            Decimal intento =  Decimal.Round(Convert.ToDecimal(total),1);


            txtTotal.Text = Convert.ToString(intento);
            


        }


        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void txtTotal_TextChanged(object sender, EventArgs e)
        {
            

        }

        

        private void btnMenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            MessageBoxButtons botones = MessageBoxButtons.YesNo;            
            DialogResult dialog = MessageBox.Show("¿Seguro que desea salir?", "Está seguro", botones,
                MessageBoxIcon.Question);

            if (dialog == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }
       
        private void btnCalcular_Click(object sender, EventArgs e)
        {

          


            try
            {
             operacion();           //Mandar a llamar metodo
                pictureBoxSolucion.Visible = true;
            }
            catch
            {
                MensajeError.Clear();       //Manejo de excepciones
                txtDistancia.Text = "";
                txtDistancia.Focus();

                if (txtDistancia.Text == "")
                {
                    MensajeError.SetError(txtDistancia, "Valor no valido");
                   
                    txtDistancia.Text = " ";
                    txtDistancia.Focus();
                }
                else
                {
                    operacion();


                }
             


            }



          

        }

        private void txtDistancia_KeyPress(object sender, KeyPressEventArgs e)


        {
            if (char.IsNumber(e.KeyChar)|| char.IsControl(e.KeyChar) || (e.KeyChar==46)&& !(txtDistancia.Text.Contains("."))){

                e.Handled = false;


            }
            else
            {
                e.Handled = true;
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {


            txtDistancia.Text = " ";
            txtTotal.Text = " ";
            pictureBoxSolucion.Visible = false;
            MensajeError.Clear();
        }

        private void txtTotal_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
    }
}
