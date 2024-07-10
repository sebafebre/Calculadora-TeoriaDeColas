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
            if (txtLambda.Text != "" && txtMu.Text != "" && txtN.Text!= "")
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
                    txtP.Text = P.ToString();
                }
                catch
                {
                    txtP.Text = "No existe";
                }

                try
                {
                    P0 = (1 - P)/(1-(Math.Pow(P, N+1)));
                    txtP0.Text = P0.ToString();
                }
                catch
                {
                    txtP0.Text = "No existe";
                }

                try
                {
                    if(txtPn.Text != "")
                    {
                        Pn = ((Math.Pow(P, Convert.ToInt32(txtPn.Text))) * P0);
                    }
                    else
                    {
                        txtPn.Text = "No solicitado";
                    }
                }
                catch
                {
                    txtPnRes.Text = "No existe";
                }

                try
                {
                    lambdaE = lambda * (1 - Pn);
                }
                catch
                {
                    txtLambdaE.Text = "No existe";
                }

                try
                {
                    double Pe = lambdaE / mu;
                }
                catch
                {
                    txtPe.Text = "No existe";
                }

                




                if(P == 1)
                {
                    try
                    {

                        Ls = N / 2;
                        txtLs.Text = Ls.ToString();

                        Lq = ( (N * (N-1)) / (2*(N+1)) );
                        txtLq.Text = Lq.ToString();
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

                        Ls = (P / (1 - P)) - ( ((N+1)*(Math.Pow(P,N+1))) / (1-(Math.Pow(P,N+1))) );
                        txtLs.Text = Ls.ToString();


                        Lq = Ls - ( (P * (1 - Math.Pow(P, N))) / (1 - Math.Pow(P, N+1)) );
                        txtLq.Text = Lq.ToString();
                    }
                    catch
                    {
                        txtLq.Text = "No existe";
                        txtLs.Text = "No existe";
                    }

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
                    Ws = Ls / lambda;
                    txtWs.Text = Ws.ToString();
                }
                catch
                {
                    txtWs.Text = "No existe";
                }


                double Pb = 0;
                double Lb = 0;
                double Wb = 0;

                try
                {
                    Lb = (Lq / (1 - P0));
                    txtLb.Text = Lb.ToString();
                }
                catch
                {
                    txtLb.Text = "No existe";
                }

                try
                {
                    Wb = (Wq / (1 - P0));
                    txtWb.Text = Wb.ToString();
                }
                catch
                {
                    txtWb.Text = "No existe";
                }

                try
                {
                    Pb = ( (Math.Pow(P,N) * (1-P)) / (1 - (Math.Pow(P,(N+1)))) );
                    txtPb.Text = Pb.ToString();
                }
                catch
                {
                    txtPb.Text = "No existe";
                }



               

                
            }
            else
            {
                lblError.Visible = true;
            }


        }
    }
}
