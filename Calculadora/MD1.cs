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
    public partial class MD1 : Form
    {
        public MD1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (txtLambda.Text == "")
            {
                lblError.Visible = true;
                lblError.Text = "Debe completar el Lambda";
            }
            else if (txtMu.Text == "")
            {
                lblError.Visible = true;
                lblError.Text = "Debe completar el Mu";
            }
            else
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
                    Lq = (Math.Pow(P,2)) / (2* (1-P));



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
                    if (Double.IsInfinity(Ls) || Double.IsNaN(Lq))
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


               
            }

        }
    }
}
