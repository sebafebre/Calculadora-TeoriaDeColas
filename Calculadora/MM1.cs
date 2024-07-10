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
            if (txtLambda.Text != "" && txtMu.Text != "")
            {

                panelResultados.Visible = true;
                lblError.Visible = false;

                double lambda = double.Parse(txtLambda.Text);
                double miu = double.Parse(txtMu.Text);

                double P = 0;
                double P0 = 0;
                double Lq = 0;
                double Ls = 0;
                double Wq = 0;
                double Ws = 0;

                double Pn = 0;


                double PaRes = 0;
                double PnA = 0;

                try
                {
                    P = lambda / miu;
                    txtP.Text = P.ToString();
                }
                catch
                {
                    txtP.Text = "No existe";
                }

                try
                {
                    P0 = 1 - P;
                    txtP0.Text = P0.ToString();
                }
                catch
                {
                    txtP0.Text = "No existe";
                }

                try
                {
                    Lq = Math.Pow(P, 2) / (1 - P);
                    txtLq.Text = Lq.ToString();
                }
                catch
                {
                    txtLq.Text = "No existe";
                }

                try
                {
                    Ls = Lq + P;
                    txtLs.Text = Ls.ToString();
                }
                catch
                {
                    txtLs.Text = "No existe";
                }

                try
                {
                    Wq = Lq / lambda;
                    txtWq.Text = Wq.ToString();
                }
                catch
                {
                    txtWq.Text = "No existe";
                }

                try
                {
                    Ws = Wq + 1 / miu;
                    txtWs.Text = Ws.ToString();
                }
                catch
                {
                    txtWs.Text = "No existe";
                }

                try
                {
                    if (txtPn.Text != "")
                    {
                        Pn = (1 - P) * Math.Pow(P, Convert.ToInt32(txtPn.Text));
                        txtPnRes.Text = Pn.ToString();
                    }
                    else
                    {
                        txtPnRes.Text = "...";
                    }
                }
                catch
                {
                    txtPnRes.Text = "No existe";
                }

                try
                {
                    if (txtPa.Text != "")
                    {
                        int Pan = Convert.ToInt32(txtPa.Text);

                        PaRes = 0;
                        Pn = 0;

                        for (int i = 1; i < Pan; i++)
                        {
                            PnA += (1 - P) * Math.Pow(P, i);
                        }

                        PaRes = 1 - P0 - PnA;
                        txtPaR.Text = PaRes.ToString();
                    }
                    else
                    {
                        txtPaR.Text = "...";
                    }
                }
                catch
                {
                    txtPaR.Text = "No existe";
                }
            }
            else
            {
                lblError.Visible = true;
            }



        }
    }
}
