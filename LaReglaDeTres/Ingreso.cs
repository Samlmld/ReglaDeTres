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
    public partial class Ingreso : Form
    {
        public Ingreso()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (txtContrasenia.Text == "samircito21")
            {
                Form1 principal = new Form1();
                this.Hide();
                principal.Show();
            }
            else
            {
                MessageBox.Show("Contraseña incorrecta", "Contraseña", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }


        }
    }
}
