using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Calculadora
{
    public partial class MM1N : Form
    {
        public MM1N()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (txtLambda.Text != "" && txtMu.Text != "" && txtN.Text != "")
            {

                panelResultados.Visible = true;
                lblError.Visible = false;

                double lambda = double.Parse(txtLambda.Text);
                double mu = double.Parse(txtMu.Text);
                int N = int.Parse(txtN.Text);




                double P = 0;
                double P0 = 0;
                double Lq = 0;
                double Ls = 0;
                double Wq = 0;
                double Ws = 0;

                double Pn = 0;

                double PaRes = 0;
                double PnA = 0;

                double PN = 0;
                double lambdaE = 0;

                try
                {
                    P = lambda / mu;
                    //txtP.Text = P.ToString();

                    if(Double.IsInfinity(P) || Double.IsNaN(P) )
                    {
                        txtP.Text = "No existe";
                    }
                    else
                    {
                        txtP.Text = (Math.Round(P, 4) * 100).ToString() + " %";
                    }
                }
                catch
                {
                    txtP.Text = "No existe";
                }

                try
                {
                    P0 = (1 - P) / (1 - (Math.Pow(P, N + 1)));
                    
                    if (Double.IsInfinity(P0) || Double.IsNaN(P0))
                    {
                        txtP0.Text = "No existe";
                    }
                    else
                    {
                        txtP0.Text = (Math.Round(P0, 4) * 100).ToString() + " %";
                    }
                }
                catch
                {
                    txtP0.Text = "No existe";
                }

                try
                {
                    
                     Pn = ((Math.Pow(P, N) * P0));

                    if (Double.IsInfinity(Pn) || Double.IsNaN(Pn))
                    {
                        txtPnRes.Text = "No existe";
                    }
                    else
                    {
                        txtPnRes.Text = (Math.Round(Pn, 4) * 100).ToString() + " %";
                    }
                }
                catch
                {
                    txtPnRes.Text = "No existe";
                }

                try
                {
                    lambdaE = lambda * (1 - Pn);
                    if (Double.IsInfinity(lambdaE) || Double.IsNaN(lambdaE))
                    {
                        txtLambdaE.Text = "No existe";
                    }
                    else
                    {
                        txtLambdaE.Text = Math.Round(lambdaE, 2).ToString();
                    }
                    
                }
                catch
                {
                    txtLambdaE.Text = "No existe";
                }

                try
                {
                    double Pe = lambdaE / mu;
                    if (Double.IsInfinity(Pe) || Double.IsNaN(Pe))
                    {
                        txtPe.Text = "No existe";
                    }
                    else
                    {
                        txtPe.Text = (Math.Round(Pe, 4) * 100).ToString() + " %";
                    }
                }
                catch
                {
                    txtPe.Text = "No existe";
                }



                if (P == 1)
                {
                    try
                    {

                        Ls = N / 2;
                        if (Double.IsInfinity(Ls))
                        {
                            txtLs.Text = "No existe";
                        }
                        else
                        {
                            txtLs.Text = Math.Round(Ls, 2).ToString();
                        }
                            

                        Lq = ((N * (N - 1)) / (2 * (N + 1)));
                        if (Double.IsInfinity(Lq))
                        {
                            txtLq.Text = "No existe";
                        }
                        else
                        {
                            txtLq.Text = Math.Round(Lq, 2).ToString();
                        }
                        
                    }

                    catch
                    {
                        txtLq.Text = "No existe";
                        txtLs.Text = "No existe";
                    }
                }
                else
                {
                    try
                    {

                        Ls = (P / (1 - P)) - (((N + 1) * (Math.Pow(P, N + 1))) / (1 - (Math.Pow(P, N + 1))));

                        if (Double.IsInfinity(Ls))
                        {
                            txtLs.Text = "No existe";
                        }
                        else
                        {
                            txtLs.Text = Math.Round(Ls, 2).ToString();

                        }


                        Lq = Ls - ((P * (1 - Math.Pow(P, N))) / (1 - Math.Pow(P, N + 1)));
                        if (Double.IsInfinity(Lq))
                        {
                            txtLq.Text = "No existe";
                        }
                        else
                        {
                            txtLq.Text = Math.Round(Lq, 2).ToString();
                        }
                        
                    }
                    catch
                    {
                        txtLq.Text = "No existe";
                        txtLs.Text = "No existe";
                    }
                }

                try
                {
                    Ws = Ls / lambdaE;

                    Wq = Ws - (1 / mu);

                    if (Double.IsInfinity(Wq) || Double.IsNaN(Wq))
                    {
                        Wq = Lq / lambdaE;
                    }
                    else
                    {
                        txtWq.Text = Math.Round(Wq, 2).ToString();
                    }

                    if (Double.IsInfinity(Ws))
                    {
                        Ws = Wq + (1 / mu);
                    }
                    else
                    {
                        txtWs.Text = Math.Round(Ws, 2).ToString();
                    }
                }
                catch
                {
                    txtWs.Text = "No existe";
                    txtWq.Text = "No existe";
                }

                /*
                try
                {
                    //Wq = Lq / lambda;
                    Wq = Ws - (1 / mu);



                    txtWq.Text = Math.Round(Wq, 2).ToString();
                }
                catch
                {
                    txtWq.Text = "No existe";
                }
                */


                double Pb = 0;
                double Lb = 0;
                double Wb = 0;

                try
                {
                    Lb = (Lq / (1 - P0));

                    if (Double.IsInfinity(Lb) || Double.IsNaN(Lb))
                    {
                        txtLb.Text = "No existe";
                    }
                    else
                    {
                        txtLb.Text = Math.Round(Lb, 2).ToString();
                    }
                }
                catch
                {
                    txtLb.Text = "No existe";
                }

                try
                {
                    Wb = (Wq / (1 - P0));
                    if (Double.IsInfinity(Wb) || Double.IsNaN(Wb))
                    {
                        txtWb.Text = "No existe";
                    }
                    else
                    {
                        txtWb.Text = Math.Round(Wb, 2).ToString();
                    }
                }
                catch
                {
                    txtWb.Text = "No existe";
                }

                try
                {
                    Pb = ((Math.Pow(P, N) * (1 - P)) / (1 - (Math.Pow(P, (N + 1)))));
                    
                    if (Double.IsInfinity(Pb) || Double.IsNaN(Pb))
                    {
                        txtPb.Text = "No existe";
                    }
                    else
                    {
                        txtPb.Text = (Math.Round(Pb, 4) * 100).ToString();
                    }
                }
                catch
                {
                    txtPb.Text = "No existe";
                }

                double Z = 0;
                double Yi;
                double Yo;

                try
                {
                    Z = lambda * Pb;

                    if (Double.IsInfinity(Pb) || Double.IsNaN(Pb))
                    {
                        txtZ.Text = "No existe";
                    }
                    else
                    {
                        txtZ.Text = Math.Round(Z, 2).ToString();
                    }
                }
                catch
                {
                    txtZ.Text = "No existe";
                }

                try
                {
                    Yi = lambda - Z;

                    if (Double.IsInfinity(Yi) || Double.IsNaN(Yi))
                    {
                        txtYi.Text = "No existe";
                    }
                    else
                    {
                        txtYi.Text = Math.Round(Yi, 2).ToString();
                    }
                }
                catch
                {
                    txtYi.Text = "No existe";

                }

                try
                {
                    Yo = mu * (1-P0);
                    if (Double.IsInfinity(Yo) || Double.IsNaN(Yo))
                    {
                        txtYo.Text = "No existe";
                    }
                    else
                    {
                        txtYo.Text = Math.Round(Yo, 2).ToString();
                    }
                }
                catch
                {
                    txtYo.Text = "No existe";
                }
            }
            else
            {
                lblError.Visible = true;
            }


        }
    }
}
