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

                double lambda = double.Parse((txtLambda.Text).Replace('.', ','));
                double mu = double.Parse((txtMu.Text).Replace('.', ','));



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
                    P = lambda / mu;
                    //txtP.Text = P.ToString();
                    txtP.Text = (Math.Round(P, 4) * 100).ToString() + " %";


                }
                catch
                {
                    txtP.Text = "No existe";
                }

                try
                {
                    P0 = 1 - P;
                    //txtP0.Text = P0.ToString();
                    txtP0.Text = (Math.Round(P0, 4) * 100).ToString() + " %";
                }
                catch
                {
                    txtP0.Text = "No existe";
                }

                try
                {
                    Lq = Math.Pow(P, 2) / (1 - P);



                    if (Double.IsInfinity(Lq))
                    {
                        txtLq.Text = "no existe";
                    }
                    else
                    {
                        //txtLq.Text = Lq.ToString();

                        txtLq.Text = (Math.Round(Lq, 2)).ToString();
                    }
                }
                catch
                {
                    txtLq.Text = "No existe";
                }



                try
                {
                    Ls = Lq + P;
                    //txtLs.Text = Ls.ToString();
                    if (Double.IsInfinity(Ls))
                    {
                        txtLs.Text = "no existe";
                    }
                    else
                    {
                        txtLs.Text = (Math.Round(Ls, 2)).ToString();
                    }
                }
                catch
                {
                    txtLs.Text = "No existe";
                }

                try
                {
                    Wq = Lq / lambda;
                    //txtWq.Text = Wq.ToString();
                    if (Double.IsInfinity(Wq))
                    {
                        txtWq.Text = "no existe";
                    }
                    else
                    {
                        txtWq.Text = (Math.Round(Wq, 2)).ToString();
                    }
                }
                catch
                {
                    txtWq.Text = "No existe";
                }

                try
                {
                    Ws = Wq + 1 / mu;
                    //txtWs.Text = Ws.ToString();
                    if (Double.IsInfinity(Ws))
                    {
                        txtWs.Text = "no existe";
                    }
                    else
                    {
                        txtWs.Text = (Math.Round(Ws, 2)).ToString();
                    }
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
                        txtPnRes.Text = (Math.Round(Pn, 4) * 100).ToString() + " %";
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
                        txtPaR.Text = (Math.Round(PaRes, 4) * 100).ToString() + " %";
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

                try
                {
                    double N = lambda * Ws;
                    if (Double.IsInfinity(N))
                    {
                        txtN.Text = "No existe";
                    }
                    else
                    {
                        txtN.Text = Math.Round(N, 2).ToString();
                    }
                }
                catch
                {
                    txtN.Text = "No existe";
                }

                try
                {
                    double tLambda = 1 / lambda;
                    if (Double.IsInfinity(tLambda))
                    {
                        txtTazaL.Text = "No existe";
                    }
                    else
                    {
                        txtTazaL.Text = Math.Round(tLambda, 2).ToString();
                    }
                }
                catch
                {
                    txtTazaL.Text = "No existe";
                }

                try
                {
                    double tMu = 1 / mu;
                    if (Double.IsInfinity(tMu))
                    {
                        txtTazaMu.Text = "No existe";
                    }
                    else
                    {
                        txtTazaMu.Text = Math.Round(tMu, 2).ToString();
                    }
                }
                catch
                {
                    txtTazaMu.Text = "No existe";
                }

            }
            else
            {
                lblError.Visible = true;
            }

        }

        private void lblResultados_Click(object sender, EventArgs e)
        {

        }

        private void lblResultados_Click_1(object sender, EventArgs e)
        {

        }
    }
}
