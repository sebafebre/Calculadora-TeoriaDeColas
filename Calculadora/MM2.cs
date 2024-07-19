using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class MM2 : Form
    {
        public MM2()
        {
            InitializeComponent();
            rbIguales.Checked = true;
        }



       

        double P = 0;
        double P0 = 0;
        double Lq = 0;
        double Ls = 0;
        double Wq = 0;
        double Ws = 0;

        double Pn = 0;

        double N = 0;
        double PaRes = 0;
        double PnA = 0;

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (txtLambda.Text != "" && txtMu1.Text != "")
            {
                double lambda = double.Parse((txtLambda.Text).Replace('.', ','));
                double mu1 = double.Parse((txtMu1.Text).Replace('.', ','));
                
                

                panelResultados.Visible = true;
                lblError.Visible = false;




                if (rbIguales.Checked == true)
                {
                    calculoIgualVelocidades(lambda, mu1);
                }
                else if (rbConSeleccion.Checked == true)
                {
                    if(txtMu2.Text != "")
                    {
                        double mu2 = double.Parse((txtMu2.Text).Replace('.', ','));
                        calculoConSeleccion(lambda, mu1, mu2);
                    }
                    else
                    {
                        lblError.Visible = true;
                        lblError.Text = "Ingrese el valor de mu2";
                    }
                    
                }
                else if (rbSinSeleccion.Checked == true)
                {
                    if (txtMu2.Text != "")
                    {
                        double mu2 = double.Parse((txtMu2.Text).Replace('.', ','));
                        calculoSinSeleccion(lambda, mu1, mu2);
                    }
                    else
                    {
                        lblError.Visible = true;
                        lblError.Text = "Ingrese el valor de mu2";
                    }
                    
                }
                else
                {
                    lblError.Visible = true;
                    lblError.Text = "Seleccione una opción de las velocidades (Iguales/Con Seleccion/Sin Seleccion)";
                }
            }
            else
            {
                lblError.Visible = true;
                lblError.Text = "Ingrese los valores de Lambda y Mu1";
            }

        }


        private void calculoMM2(double lambda, double mu1)
        {

            try
            {
                Lq = Math.Pow(P, 2) / (1 - P);


                if (Double.IsInfinity(Lq) || Double.IsNaN(Lq))
                {
                    txtLq.Text = "no existe";
                }
                else
                {
                    txtLq.Text = (Math.Round(Lq, 2)).ToString();
                }
            }
            catch
            {
                txtLq.Text = "No existe";
            }

            try
            {
                Wq = Lq / lambda;

                if (Double.IsInfinity(Wq) || Double.IsNaN(Wq))
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
                Ws = Ls / lambda;

                if (Double.IsInfinity(Ws) || Double.IsNaN(Ws))
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
                    Pn = (1 - Convert.ToInt32(txtPn.Text)) * Math.Pow(P, Convert.ToInt32(txtPn.Text));

                    if (Double.IsInfinity(Pn) || Double.IsNaN(Pn))
                    {
                        txtPnRes.Text = "no existe";
                    }
                    else
                    {
                        txtPnRes.Text = (Math.Round(Pn, 2) * 100).ToString() + " %";
                    }
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
                    PnA = 0;

                    for (int i = 1; i <= Pan; i++)
                    {
                        //PnA += (1 - P) * Math.Pow(P, i);

                        PnA += (1 - i) * Math.Pow(P, i);
                    }

                    PaRes = 1 - P0 - PnA;

                    if (Double.IsInfinity(PaRes) || Double.IsNaN(PaRes))
                    {
                        txtPaR.Text = "no existe";
                    }
                    else
                    {
                        txtPaR.Text = (Math.Round(PaRes, 2) * 100).ToString() + " %";
                    }
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
                N = lambda * Ws;

                if (Double.IsInfinity(N) || Double.IsNaN(N))
                {
                    txtN.Text = "no existe";
                }
                else
                {
                    txtN.Text = (Math.Round(N, 2)).ToString();
                }
            }
            catch
            {
                txtN.Text = "No existe";
            }
        }


        private void calculoIgualVelocidades(double lambda, double mu1)
        {
            try
            {
                P = lambda / (mu1 * 2);

                if (Double.IsInfinity(P) || Double.IsNaN(P))
                {
                    txtP.Text = "no existe";
                }
                else
                {
                    //txtP.Text = (Math.Round(P * 100, 2)).ToString() + "%";
                    txtP.Text = (Math.Round(P, 2) * 100).ToString() + "%";
                }         
            }
            catch
            {
                txtP.Text = "No existe";
            }

            try
            {
                P0 = 1 - P;

                if (Double.IsInfinity(P0) || Double.IsNaN(P0))
                {
                    txtP0.Text = "no existe";
                }
                else
                {
                    txtP0.Text = (Math.Round(P0, 2) * 100).ToString() + " %";
                }
            }
            catch
            {
                txtP0.Text = "No existe";
            }

            try
            {
                Ls = P / (1 - P);
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

            calculoMM2(lambda, mu1);
        }


        private void calculoConSeleccion(double lambda, double mu1, double mu2)
        {
            double muS = mu1 + mu2;
            double r = mu2 / mu1;
            double aPrima = 0;


            try
            {
                aPrima = ((2 * lambda + muS) * (mu1 * mu2)) / (muS * (lambda + mu2));

                if(Double.IsInfinity(aPrima) || Double.IsNaN(aPrima))
                {
                    txtA.Text = "no existe";
                }
                else
                {
                    txtA.Text = (Math.Round(aPrima, 2)).ToString();
                }

            }
            catch
            {
                txtA.Text = "No existe";
            }
            try
            {
                P = lambda / (mu1 + mu2);

                if (Double.IsInfinity(P) || Double.IsNaN(P))
                {
                    txtP.Text = "no existe";

                }
                else
                {
                    txtP.Text = (Math.Round(P, 2) * 100).ToString() + " %";
                }
            }
            catch
            {
                txtP.Text = "No existe";
            }

            

            try
            {
                double a = (1 + Math.Pow(r, 2));
                double b = (-1) * (2 + Math.Pow(r, 2));
                double c = ((-1) * (2 * r - 1)) * (1 + r);

                double x1 = (-b + Math.Sqrt(Math.Pow(b, 2) - 4 * a * c)) / (2 * a);
                double x2 = (-b - Math.Sqrt(Math.Pow(b, 2) - 4 * a * c)) / (2 * a);

                //txtPc.Text = x1.ToString() + " or " + x2.ToString();
                

                if(x1 >= x2)
                {
                    txtPc.Text = (Math.Round(x1, 2)).ToString();
                }
                else if(x2 > x1)
                {
                    txtPc.Text = (Math.Round(x2, 2)).ToString();
                }
                else if(Double.IsInfinity(x1) && Double.IsInfinity(x2))
                {
                    txtPc.Text = "No existe";
                }
                else
                {
                    txtPc.Text = (Math.Round(x1, 2)).ToString() + " o " + (Math.Round(x2, 2)).ToString();
                }
            }
            catch
            {
                txtPc.Text = "No existe";
            }

            try
            {
                P0 = (1-P) / ((1-P) + (lambda / aPrima));

                if (Double.IsInfinity(P0) || Double.IsNaN(P0))
                {
                    txtP0.Text = "no existe";
                }
                else
                {
                    txtP0.Text = (Math.Round(P0, 2) * 100).ToString() + " %";
                }

            }
            catch
            {
                txtP0.Text = "No existe";
            }

            try
            {
                Ls = lambda / ((1-P) * (lambda + (1-P) * aPrima));
                if (Double.IsInfinity(Ls) || Double.IsNaN(Ls))
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

            calculoMM2(lambda, mu1);

        }

        private void calculoSinSeleccion(double lambda, double mu1, double mu2)
        {
            double muS = mu1 + mu2;
            double r = mu2 / mu1;
            double A = 0;


            try
            {
                A = (2 * mu1 * mu2) / (mu1 + mu2); 

                if (Double.IsInfinity(A) || Double.IsNaN(A))
                {
                    txtA.Text = "no existe";
                }
                else
                {
                    txtA.Text = (Math.Round(A, 2)).ToString();
                }
            }
            catch
            {
                txtA.Text = "No existe";
            }


            try
            {
                P = lambda / (mu1 + mu2);

                if (Double.IsInfinity(P) || Double.IsNaN(P))
                {
                    txtP.Text = "no existe";
                }
                else
                {
                    txtP.Text = (Math.Round((P * 100))).ToString() + " %";
                }
            }
            catch
            {
                txtP.Text = "No existe";
            }



            try
            {
                double Pc = 1 - ( (r * (1 + r) ) / (1 + Math.Pow(r, 2)) );
                
                if (Double.IsInfinity(Pc) || Double.IsNaN(Pc))
                {
                    txtPc.Text = "no existe";
                }
                else
                {
                    txtPc.Text = (Math.Round(Pc, 3) ).ToString();
                }
            }
            catch
            {
                txtPc.Text = "No existe";
            }

            try
            {
                P0 = (1 - P) / ((1 - P) + (lambda / A));
                if (Double.IsInfinity(P0) || Double.IsNaN(P0))
                {
                    txtP0.Text = "no existe";
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
                Ls = lambda / ((1 - P) * (lambda + (1 - P) * A));

                if (Double.IsInfinity(Ls) || Double.IsNaN(Ls))
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

            calculoMM2(lambda , mu1);

        }


        /*
        private void cuatraticaPc(double r)
        {
            double a = (1 + Math.Pow(r, 2));
            double b = (-1) * (2 + Math.Pow(r, 2));
            double c = ((-1) * (2 * r - 1)) * (1 + r);

            double x1 = (-b + Math.Sqrt(Math.Pow(b, 2) - 4 * a * c)) / (2 * a);
            double x2 = (-b - Math.Sqrt(Math.Pow(b, 2) - 4 * a * c)) / (2 * a);

            txtPc.Text = x1.ToString() + " or " + x2.ToString();
        }

        */














        private void rbConSeleccion_CheckedChanged(object sender, EventArgs e)
        {
            if (rbConSeleccion.Checked == true)
            {
                txtMu2.Visible = true;
                lblMu2.Visible = true;
            }
            else
            {
                txtMu2.Visible = false;
                lblMu2.Visible = false;
            }
        }

        private void rbSinSeleccion_CheckedChanged(object sender, EventArgs e)
        {
            if (rbSinSeleccion.Checked == true)
            {
                txtMu2.Visible = true;
                lblMu2.Visible = true;
            }
            else
            {
                txtMu2.Visible = false;
                lblMu2.Visible = false;
            }
        }

        private void rbIguales_CheckedChanged(object sender, EventArgs e)
        {
            if (rbIguales.Checked == true)
            {
                txtMu2.Visible = false;
                lblMu2.Visible = false;
            }
            else
            {
                txtMu2.Visible = true;
                lblMu2.Visible = true;
            }
        }
    }

}
    

