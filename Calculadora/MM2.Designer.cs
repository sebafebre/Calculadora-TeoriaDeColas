namespace Calculadora
{
    partial class MM2
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
            lblError = new Label();
            panelResultados = new Panel();
            txtPnRes = new TextBox();
            label12 = new Label();
            lblResultados = new Label();
            txtP0 = new TextBox();
            txtPaR = new TextBox();
            label11 = new Label();
            label5 = new Label();
            txtP = new TextBox();
            txtLq = new TextBox();
            label10 = new Label();
            label6 = new Label();
            txtWq = new TextBox();
            label9 = new Label();
            label7 = new Label();
            txtWs = new TextBox();
            txtLs = new TextBox();
            label8 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtPa = new TextBox();
            txtPn = new TextBox();
            txtMu = new TextBox();
            txtLambda = new TextBox();
            btnCalcular = new Button();
            label13 = new Label();
            txtN = new TextBox();
            panelResultados.SuspendLayout();
            SuspendLayout();
            // 
            // lblError
            // 
            lblError.AutoSize = true;
            lblError.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblError.ForeColor = Color.Red;
            lblError.Location = new Point(230, 110);
            lblError.Name = "lblError";
            lblError.Size = new Size(233, 20);
            lblError.TabIndex = 54;
            lblError.Text = "Debe ingresar el lambda y el mu";
            lblError.Visible = false;
            // 
            // panelResultados
            // 
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
            panelResultados.Location = new Point(0, 196);
            panelResultados.Name = "panelResultados";
            panelResultados.Size = new Size(854, 254);
            panelResultados.TabIndex = 53;
            panelResultados.Visible = false;
            // 
            // txtPnRes
            // 
            txtPnRes.Location = new Point(498, 156);
            txtPnRes.Name = "txtPnRes";
            txtPnRes.Size = new Size(80, 27);
            txtPnRes.TabIndex = 43;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.Location = new Point(459, 156);
            label12.Name = "label12";
            label12.Size = new Size(49, 25);
            label12.TabIndex = 42;
            label12.Text = "Pn:";
            // 
            // lblResultados
            // 
            lblResultados.AutoSize = true;
            lblResultados.Location = new Point(345, 34);
            lblResultados.Name = "lblResultados";
            lblResultados.Size = new Size(84, 20);
            lblResultados.TabIndex = 29;
            lblResultados.Text = "Resultados:";
            // 
            // txtP0
            // 
            txtP0.Location = new Point(352, 158);
            txtP0.Name = "txtP0";
            txtP0.Size = new Size(77, 27);
            txtP0.TabIndex = 41;
            // 
            // txtPaR
            // 
            txtPaR.Location = new Point(498, 103);
            txtPaR.Name = "txtPaR";
            txtPaR.Size = new Size(80, 27);
            txtPaR.TabIndex = 39;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Location = new Point(311, 158);
            label11.Name = "label11";
            label11.Size = new Size(49, 25);
            label11.TabIndex = 40;
            label11.Text = "P0:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(23, 111);
            label5.Name = "label5";
            label5.Size = new Size(47, 25);
            label5.TabIndex = 30;
            label5.Text = "Lq:";
            // 
            // txtP
            // 
            txtP.Location = new Point(352, 109);
            txtP.Name = "txtP";
            txtP.Size = new Size(77, 27);
            txtP.TabIndex = 39;
            // 
            // txtLq
            // 
            txtLq.Location = new Point(78, 111);
            txtLq.Name = "txtLq";
            txtLq.Size = new Size(80, 27);
            txtLq.TabIndex = 31;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(311, 109);
            label10.Name = "label10";
            label10.Size = new Size(35, 25);
            label10.TabIndex = 38;
            label10.Text = "P:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(23, 158);
            label6.Name = "label6";
            label6.Size = new Size(57, 25);
            label6.TabIndex = 32;
            label6.Text = "Wq:";
            // 
            // txtWq
            // 
            txtWq.Location = new Point(78, 158);
            txtWq.Name = "txtWq";
            txtWq.Size = new Size(80, 27);
            txtWq.TabIndex = 33;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(459, 105);
            label9.Name = "label9";
            label9.Size = new Size(48, 25);
            label9.TabIndex = 38;
            label9.Text = "Pa:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(164, 109);
            label7.Name = "label7";
            label7.Size = new Size(45, 25);
            label7.TabIndex = 34;
            label7.Text = "Ls:";
            // 
            // txtWs
            // 
            txtWs.Location = new Point(219, 158);
            txtWs.Name = "txtWs";
            txtWs.Size = new Size(86, 27);
            txtWs.TabIndex = 37;
            // 
            // txtLs
            // 
            txtLs.Location = new Point(219, 109);
            txtLs.Name = "txtLs";
            txtLs.Size = new Size(86, 27);
            txtLs.TabIndex = 35;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(164, 158);
            label8.Name = "label8";
            label8.Size = new Size(55, 25);
            label8.TabIndex = 36;
            label8.Text = "Ws:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(608, 37);
            label4.Name = "label4";
            label4.Size = new Size(27, 20);
            label4.TabIndex = 52;
            label4.Text = "Pa:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(511, 37);
            label3.Name = "label3";
            label3.Size = new Size(28, 20);
            label3.TabIndex = 51;
            label3.Text = "Pn:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(230, 37);
            label2.Name = "label2";
            label2.Size = new Size(56, 20);
            label2.TabIndex = 50;
            label2.Text = "μ (mu):";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(62, 37);
            label1.Name = "label1";
            label1.Size = new Size(84, 20);
            label1.TabIndex = 49;
            label1.Text = "λ (lambda):";
            // 
            // txtPa
            // 
            txtPa.Location = new Point(608, 60);
            txtPa.Name = "txtPa";
            txtPa.Size = new Size(75, 27);
            txtPa.TabIndex = 48;
            // 
            // txtPn
            // 
            txtPn.Location = new Point(483, 60);
            txtPn.Name = "txtPn";
            txtPn.Size = new Size(70, 27);
            txtPn.TabIndex = 47;
            // 
            // txtMu
            // 
            txtMu.Location = new Point(230, 60);
            txtMu.Name = "txtMu";
            txtMu.Size = new Size(75, 27);
            txtMu.TabIndex = 46;
            // 
            // txtLambda
            // 
            txtLambda.Location = new Point(62, 60);
            txtLambda.Name = "txtLambda";
            txtLambda.Size = new Size(84, 27);
            txtLambda.TabIndex = 45;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(315, 156);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(125, 34);
            btnCalcular.TabIndex = 44;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(365, 37);
            label13.Name = "label13";
            label13.Size = new Size(23, 20);
            label13.TabIndex = 56;
            label13.Text = "N:";
            // 
            // txtN
            // 
            txtN.Location = new Point(365, 60);
            txtN.Name = "txtN";
            txtN.Size = new Size(75, 27);
            txtN.TabIndex = 55;
            // 
            // MM2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(854, 450);
            Controls.Add(label13);
            Controls.Add(txtN);
            Controls.Add(lblError);
            Controls.Add(panelResultados);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtPa);
            Controls.Add(txtPn);
            Controls.Add(txtMu);
            Controls.Add(txtLambda);
            Controls.Add(btnCalcular);
            Name = "MM2";
            Text = "MM2";
            panelResultados.ResumeLayout(false);
            panelResultados.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblError;
        private Panel panelResultados;
        private TextBox txtPnRes;
        private Label label12;
        private Label lblResultados;
        private TextBox txtP0;
        private TextBox txtPaR;
        private Label label11;
        private Label label5;
        private TextBox txtP;
        private TextBox txtLq;
        private Label label10;
        private Label label6;
        private TextBox txtWq;
        private Label label9;
        private Label label7;
        private TextBox txtWs;
        private TextBox txtLs;
        private Label label8;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtPa;
        private TextBox txtPn;
        private TextBox txtMu;
        private TextBox txtLambda;
        private Button btnCalcular;
        private Label label13;
        private TextBox txtN;
    }
}