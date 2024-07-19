namespace Calculadora
{
    partial class MM1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblResultados = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtPa = new TextBox();
            txtPn = new TextBox();
            txtMu = new TextBox();
            txtLambda = new TextBox();
            label5 = new Label();
            txtLq = new TextBox();
            txtWq = new TextBox();
            label6 = new Label();
            txtLs = new TextBox();
            label7 = new Label();
            txtWs = new TextBox();
            label8 = new Label();
            txtPaR = new TextBox();
            label9 = new Label();
            label10 = new Label();
            txtP = new TextBox();
            txtP0 = new TextBox();
            label11 = new Label();
            panelResultados = new Panel();
            label15 = new Label();
            txtN = new TextBox();
            t = new Label();
            txtTazaL = new TextBox();
            label14 = new Label();
            txtTazaMu = new TextBox();
            txtPnRes = new TextBox();
            label12 = new Label();
            lblError = new Label();
            panelDatos = new Panel();
            btnCalcular = new Button();
            panelResultados.SuspendLayout();
            panelDatos.SuspendLayout();
            SuspendLayout();
            // 
            // lblResultados
            // 
            lblResultados.Dock = DockStyle.Top;
            lblResultados.Font = new Font("Segoe UI", 18F);
            lblResultados.Location = new Point(0, 0);
            lblResultados.Name = "lblResultados";
            lblResultados.Size = new Size(1031, 55);
            lblResultados.TabIndex = 29;
            lblResultados.Text = "Resultados:";
            lblResultados.TextAlign = ContentAlignment.MiddleCenter;
            lblResultados.Click += lblResultados_Click_1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold | FontStyle.Italic);
            label4.Location = new Point(729, 74);
            label4.Name = "label4";
            label4.Size = new Size(36, 23);
            label4.TabIndex = 28;
            label4.Text = "Pa:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold | FontStyle.Italic);
            label3.Location = new Point(543, 74);
            label3.Name = "label3";
            label3.Size = new Size(36, 23);
            label3.TabIndex = 27;
            label3.Text = "Pn:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold | FontStyle.Italic);
            label2.Location = new Point(359, 74);
            label2.Name = "label2";
            label2.Size = new Size(67, 23);
            label2.TabIndex = 26;
            label2.Text = "μ (mu):";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold | FontStyle.Italic);
            label1.Location = new Point(174, 74);
            label1.Name = "label1";
            label1.Size = new Size(101, 23);
            label1.TabIndex = 25;
            label1.Text = "λ (lambda):";
            // 
            // txtPa
            // 
            txtPa.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtPa.Location = new Point(729, 97);
            txtPa.Name = "txtPa";
            txtPa.Size = new Size(106, 27);
            txtPa.TabIndex = 24;
            // 
            // txtPn
            // 
            txtPn.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtPn.Location = new Point(544, 97);
            txtPn.Name = "txtPn";
            txtPn.Size = new Size(106, 27);
            txtPn.TabIndex = 23;
            // 
            // txtMu
            // 
            txtMu.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtMu.Location = new Point(359, 97);
            txtMu.Name = "txtMu";
            txtMu.Size = new Size(106, 27);
            txtMu.TabIndex = 22;
            // 
            // txtLambda
            // 
            txtLambda.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtLambda.Location = new Point(174, 97);
            txtLambda.Name = "txtLambda";
            txtLambda.Size = new Size(106, 27);
            txtLambda.TabIndex = 21;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(300, 80);
            label5.Name = "label5";
            label5.Size = new Size(47, 25);
            label5.TabIndex = 30;
            label5.Text = "Lq:";
            // 
            // txtLq
            // 
            txtLq.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtLq.Location = new Point(353, 79);
            txtLq.Name = "txtLq";
            txtLq.Size = new Size(88, 27);
            txtLq.TabIndex = 31;
            // 
            // txtWq
            // 
            txtWq.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtWq.Location = new Point(353, 156);
            txtWq.Name = "txtWq";
            txtWq.Size = new Size(88, 27);
            txtWq.TabIndex = 33;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(290, 157);
            label6.Name = "label6";
            label6.Size = new Size(57, 25);
            label6.TabIndex = 32;
            label6.Text = "Wq:";
            // 
            // txtLs
            // 
            txtLs.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtLs.Location = new Point(538, 79);
            txtLs.Name = "txtLs";
            txtLs.Size = new Size(88, 27);
            txtLs.TabIndex = 35;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(487, 80);
            label7.Name = "label7";
            label7.Size = new Size(45, 25);
            label7.TabIndex = 34;
            label7.Text = "Ls:";
            // 
            // txtWs
            // 
            txtWs.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtWs.Location = new Point(538, 156);
            txtWs.Name = "txtWs";
            txtWs.Size = new Size(88, 27);
            txtWs.TabIndex = 37;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(477, 157);
            label8.Name = "label8";
            label8.Size = new Size(55, 25);
            label8.TabIndex = 36;
            label8.Text = "Ws:";
            // 
            // txtPaR
            // 
            txtPaR.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtPaR.Location = new Point(897, 79);
            txtPaR.Name = "txtPaR";
            txtPaR.Size = new Size(88, 27);
            txtPaR.TabIndex = 39;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(843, 80);
            label9.Name = "label9";
            label9.Size = new Size(48, 25);
            label9.TabIndex = 38;
            label9.Text = "Pa:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(681, 80);
            label10.Name = "label10";
            label10.Size = new Size(35, 25);
            label10.TabIndex = 38;
            label10.Text = "P:";
            // 
            // txtP
            // 
            txtP.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtP.Location = new Point(722, 79);
            txtP.Name = "txtP";
            txtP.Size = new Size(88, 27);
            txtP.TabIndex = 39;
            // 
            // txtP0
            // 
            txtP0.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtP0.Location = new Point(722, 156);
            txtP0.Name = "txtP0";
            txtP0.Size = new Size(88, 27);
            txtP0.TabIndex = 41;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Location = new Point(667, 157);
            label11.Name = "label11";
            label11.Size = new Size(49, 25);
            label11.TabIndex = 40;
            label11.Text = "P0:";
            // 
            // panelResultados
            // 
            panelResultados.Controls.Add(label15);
            panelResultados.Controls.Add(txtN);
            panelResultados.Controls.Add(t);
            panelResultados.Controls.Add(txtTazaL);
            panelResultados.Controls.Add(label14);
            panelResultados.Controls.Add(txtTazaMu);
            panelResultados.Controls.Add(txtPnRes);
            panelResultados.Controls.Add(label12);
            panelResultados.Controls.Add(lblResultados);
            panelResultados.Controls.Add(txtP0);
            panelResultados.Controls.Add(txtPaR);
            panelResultados.Controls.Add(label11);
            panelResultados.Controls.Add(label5);
            panelResultados.Controls.Add(txtP);
            panelResultados.Controls.Add(txtLq);
            panelResultados.Controls.Add(label10);
            panelResultados.Controls.Add(label6);
            panelResultados.Controls.Add(txtWq);
            panelResultados.Controls.Add(label9);
            panelResultados.Controls.Add(label7);
            panelResultados.Controls.Add(txtWs);
            panelResultados.Controls.Add(txtLs);
            panelResultados.Controls.Add(label8);
            panelResultados.Dock = DockStyle.Bottom;
            panelResultados.Location = new Point(0, 343);
            panelResultados.Name = "panelResultados";
            panelResultados.Size = new Size(1031, 270);
            panelResultados.TabIndex = 42;
            panelResultados.Visible = false;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label15.Location = new Point(49, 94);
            label15.Name = "label15";
            label15.Size = new Size(37, 25);
            label15.TabIndex = 48;
            label15.Text = "N:";
            // 
            // txtN
            // 
            txtN.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtN.Location = new Point(22, 124);
            txtN.Name = "txtN";
            txtN.Size = new Size(88, 27);
            txtN.TabIndex = 49;
            // 
            // t
            // 
            t.AutoSize = true;
            t.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            t.Location = new Point(139, 80);
            t.Name = "t";
            t.Size = new Size(49, 25);
            t.TabIndex = 44;
            t.Text = "tλ :";
            // 
            // txtTazaL
            // 
            txtTazaL.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtTazaL.Location = new Point(192, 79);
            txtTazaL.Name = "txtTazaL";
            txtTazaL.Size = new Size(88, 27);
            txtTazaL.TabIndex = 45;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label14.Location = new Point(129, 157);
            label14.Name = "label14";
            label14.Size = new Size(43, 25);
            label14.TabIndex = 46;
            label14.Text = "tμ:";
            // 
            // txtTazaMu
            // 
            txtTazaMu.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtTazaMu.Location = new Point(192, 156);
            txtTazaMu.Name = "txtTazaMu";
            txtTazaMu.Size = new Size(88, 27);
            txtTazaMu.TabIndex = 47;
            // 
            // txtPnRes
            // 
            txtPnRes.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtPnRes.Location = new Point(897, 156);
            txtPnRes.Name = "txtPnRes";
            txtPnRes.Size = new Size(88, 27);
            txtPnRes.TabIndex = 43;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.Location = new Point(842, 157);
            label12.Name = "label12";
            label12.Size = new Size(49, 25);
            label12.TabIndex = 42;
            label12.Text = "Pn:";
            // 
            // lblError
            // 
            lblError.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblError.ForeColor = Color.Red;
            lblError.Location = new Point(88, 205);
            lblError.Name = "lblError";
            lblError.Size = new Size(810, 20);
            lblError.TabIndex = 43;
            lblError.Text = "Debe ingresar el lambda y el mu";
            lblError.TextAlign = ContentAlignment.TopCenter;
            lblError.Visible = false;
            // 
            // panelDatos
            // 
            panelDatos.Controls.Add(btnCalcular);
            panelDatos.Controls.Add(label4);
            panelDatos.Controls.Add(lblError);
            panelDatos.Controls.Add(txtPa);
            panelDatos.Controls.Add(label3);
            panelDatos.Controls.Add(txtPn);
            panelDatos.Controls.Add(label2);
            panelDatos.Controls.Add(txtMu);
            panelDatos.Controls.Add(label1);
            panelDatos.Controls.Add(txtLambda);
            panelDatos.Dock = DockStyle.Fill;
            panelDatos.Location = new Point(0, 0);
            panelDatos.Margin = new Padding(3, 4, 3, 4);
            panelDatos.Name = "panelDatos";
            panelDatos.Size = new Size(1031, 343);
            panelDatos.TabIndex = 44;
            // 
            // btnCalcular
            // 
            btnCalcular.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCalcular.BackColor = Color.FromArgb(64, 83, 76);
            btnCalcular.Location = new Point(382, 255);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(229, 44);
            btnCalcular.TabIndex = 20;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = false;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // MM1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1031, 613);
            Controls.Add(panelDatos);
            Controls.Add(panelResultados);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MM1";
            Text = "MM1";
            panelResultados.ResumeLayout(false);
            panelResultados.PerformLayout();
            panelDatos.ResumeLayout(false);
            panelDatos.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label lblResultados;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtPa;
        private TextBox txtPn;
        private TextBox txtMu;
        private TextBox txtLambda;
        private Label label5;
        private TextBox txtLq;
        private TextBox txtWq;
        private Label label6;
        private TextBox txtLs;
        private Label label7;
        private TextBox txtWs;
        private Label label8;
        private TextBox txtPaR;
        private Label label9;
        private Label label10;
        private TextBox txtP;
        private TextBox txtP0;
        private Label label11;
        private Panel panelResultados;
        private TextBox txtPnRes;
        private Label label12;
        private Label lblError;
        private Panel panelDatos;
        private Button btnCalcular;
        private Label label15;
        private TextBox txtN;
        private Label t;
        private TextBox txtTazaL;
        private Label label14;
        private TextBox txtTazaMu;
    }
}