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
    public partial class MM1 : Form
    {
        public MM1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            panelResultados.Visible = true;

            double lambda = double.Parse(txtLambda.Text);
            double miu = double.Parse(txtMu.Text);

            double P = lambda / miu;
            double P0 = 1 - P;
            double Lq = Math.Pow(P, 2) / (1 - P);
            double Ls = Lq + P;
            double Wq = Lq / lambda;
            double Ws = Wq + 1 / miu;
            double Pn = (1-P) * Math.Pow(P, Convert.ToInt32(txtPn.Text));

            int Pan = Convert.ToInt32(txtPa.Text);
            double PaRes = 0;
            double PnA = 0;
            for (int i = 1; i < Pan; i++) {

                PnA += (1 - P) * Math.Pow(P, i);


                PaRes = 1 - P0 - PnA;
            }
             
            

            

            txtPRes.Text = P.ToString();
            txtP0Res.Text = P0.ToString();
            txtLq.Text = Lq.ToString();
            txtLs.Text = Ls.ToString();
            txtWq.Text = Wq.ToString();
            txtWs.Text = Ws.ToString();
            txtPnRes.Text = Pn.ToString();
            txtPaR.Text = PaRes.ToString();





        }
    }
}
