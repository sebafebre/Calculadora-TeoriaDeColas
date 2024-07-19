using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class MMN : Form
    {
        public MMN()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if(txtW0.Text == "")
            {
                lblError.Visible = true;
                lblError.Text = "Debe completar el W0";
            }
            else if(txtQ1.Text == "")
            {
                lblError.Visible = true;
                lblError.Text = "Debe completar el Q1";
            }
            else if(txtTs1.Text == "")
            {
                lblError.Visible = true;
                lblError.Text = "Debe completar el Ts1";
            }
            else
            {
                lblError.Visible = false;
                panelResultados.Visible = true;
                double W0 = double.Parse(txtW0.Text);
                double Q1 = double.Parse(txtQ1.Text);
                double Ts1 = double.Parse(txtTs1.Text);

                try
                {
                    double W1 = W0 + Q1 * Ts1 + Ts1;
                    txtW1.Text = Math.Round(W1, 2).ToString();
                }
                catch
                {
                    txtW1.Text = "No existe";
                }

                try
                {
                    double WQ1 = W0 + Q1 * Ts1;
                    txtWQ1.Text = Math.Round(WQ1, 2).ToString();
                }
                catch
                {
                    txtWQ1.Text = "No existe";
                }
            }

        }
    }
}
