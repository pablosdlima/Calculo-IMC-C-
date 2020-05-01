using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculo_IMC
{
    public partial class lblPeso : Form
    {
        double peso, altura, imc;

        private void btnLimp_Click(object sender, EventArgs e)
        {
            txtAltura.Clear();
            txtPeso.Clear();
            lblImc.Text = "";




        }

        private void lblPeso_Load(object sender, EventArgs e)
        {

        }

        private void lblImc_Click(object sender, EventArgs e)
        {

        }

        public lblPeso()
        {
            InitializeComponent();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            peso = double.Parse(txtPeso.Text);
            altura = double.Parse(txtAltura.Text);

            imc = peso / altura;
            lblImc.Text = "O IMC calculado é " + imc;
        }
    }
}
