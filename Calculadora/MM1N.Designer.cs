namespace Calculadora
{
    partial class MM1N
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
            label13 = new Label();
            txtN = new TextBox();
            lblError = new Label();
            panelResultados = new Panel();
            txtLambdaE = new TextBox();
            txtPe = new TextBox();
            label17 = new Label();
            label18 = new Label();
            label15 = new Label();
            txtWb = new TextBox();
            txtLb = new TextBox();
            label16 = new Label();
            txtPb = new TextBox();
            label14 = new Label();
            txtPnRes = new TextBox();
            label12 = new Label();
            lblResultados = new Label();
            txtP0 = new TextBox();
            label11 = new Label();
            label5 = new Label();
            txtP = new TextBox();
            txtLq = new TextBox();
            label10 = new Label();
            label6 = new Label();
            txtWq = new TextBox();
            label7 = new Label();
            txtWs = new TextBox();
            txtLs = new TextBox();
            label8 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtPn = new TextBox();
            txtMu = new TextBox();
            txtLambda = new TextBox();
            btnCalcular = new Button();
            label4 = new Label();
            panelResultados.SuspendLayout();
            SuspendLayout();
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(345, 75);
            label13.Name = "label13";
            label13.Size = new Size(19, 15);
            label13.TabIndex = 69;
            label13.Text = "N:";
            // 
            // txtN
            // 
            txtN.Location = new Point(345, 92);
            txtN.Margin = new Padding(3, 2, 3, 2);
            txtN.Name = "txtN";
            txtN.Size = new Size(93, 23);
            txtN.TabIndex = 68;
            // 
            // lblError
            // 
            lblError.AutoSize = true;
            lblError.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblError.ForeColor = Color.Red;
            lblError.Location = new Point(218, 135);
            lblError.Name = "lblError";
            lblError.Size = new Size(199, 15);
            lblError.TabIndex = 67;
            lblError.Text = "Debe ingresar el lambda, el mu y N";
            lblError.Visible = false;
            // 
            // panelResultados
            // 
            panelResultados.Controls.Add(txtLambdaE);
            panelResultados.Controls.Add(txtPe);
            panelResultados.Controls.Add(label17);
            panelResultados.Controls.Add(label18);
            panelResultados.Controls.Add(label15);
            panelResultados.Controls.Add(txtWb);
            panelResultados.Controls.Add(txtLb);
            panelResultados.Controls.Add(label16);
            panelResultados.Controls.Add(txtPb);
            panelResultados.Controls.Add(label14);
            panelResultados.Controls.Add(txtPnRes);
            panelResultados.Controls.Add(label12);
            panelResultados.Controls.Add(lblResultados);
            panelResultados.Controls.Add(txtP0);
            panelResultados.Controls.Add(label11);
            panelResultados.Controls.Add(label5);
            panelResultados.Controls.Add(txtP);
            panelResultados.Controls.Add(txtLq);
            panelResultados.Controls.Add(label10);
            panelResultados.Controls.Add(label6);
            panelResultados.Controls.Add(txtWq);
            panelResultados.Controls.Add(label7);
            panelResultados.Controls.Add(txtWs);
            panelResultados.Controls.Add(txtLs);
            panelResultados.Controls.Add(label8);
            panelResultados.Dock = DockStyle.Bottom;
            panelResultados.Location = new Point(0, 256);
            panelResultados.Margin = new Padding(3, 2, 3, 2);
            panelResultados.Name = "panelResultados";
            panelResultados.Size = new Size(709, 162);
            panelResultados.TabIndex = 66;
            panelResultados.Visible = false;
            // 
            // txtLambdaE
            // 
            txtLambdaE.Location = new Point(54, 48);
            txtLambdaE.Margin = new Padding(3, 2, 3, 2);
            txtLambdaE.Name = "txtLambdaE";
            txtLambdaE.Size = new Size(70, 23);
            txtLambdaE.TabIndex = 52;
            // 
            // txtPe
            // 
            txtPe.Location = new Point(558, 48);
            txtPe.Margin = new Padding(3, 2, 3, 2);
            txtPe.Name = "txtPe";
            txtPe.Size = new Size(68, 23);
            txtPe.TabIndex = 53;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label17.Location = new Point(522, 50);
            label17.Name = "label17";
            label17.Size = new Size(37, 18);
            label17.TabIndex = 50;
            label17.Text = "Pe:";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label18.Location = new Point(20, 49);
            label18.Name = "label18";
            label18.Size = new Size(35, 18);
            label18.TabIndex = 51;
            label18.Text = "λe:";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label15.Location = new Point(254, 83);
            label15.Name = "label15";
            label15.Size = new Size(35, 18);
            label15.TabIndex = 46;
            label15.Text = "Lb:";
            // 
            // txtWb
            // 
            txtWb.Location = new Point(302, 120);
            txtWb.Margin = new Padding(3, 2, 3, 2);
            txtWb.Name = "txtWb";
            txtWb.Size = new Size(76, 23);
            txtWb.TabIndex = 49;
            // 
            // txtLb
            // 
            txtLb.Location = new Point(302, 82);
            txtLb.Margin = new Padding(3, 2, 3, 2);
            txtLb.Name = "txtLb";
            txtLb.Size = new Size(76, 23);
            txtLb.TabIndex = 47;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label16.Location = new Point(254, 121);
            label16.Name = "label16";
            label16.Size = new Size(43, 18);
            label16.TabIndex = 48;
            label16.Text = "Wb:";
            // 
            // txtPb
            // 
            txtPb.Location = new Point(556, 84);
            txtPb.Margin = new Padding(3, 2, 3, 2);
            txtPb.Name = "txtPb";
            txtPb.Size = new Size(70, 23);
            txtPb.TabIndex = 45;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label14.Location = new Point(522, 85);
            label14.Name = "label14";
            label14.Size = new Size(37, 18);
            label14.TabIndex = 44;
            label14.Text = "Pb:";
            // 
            // txtPnRes
            // 
            txtPnRes.Location = new Point(556, 120);
            txtPnRes.Margin = new Padding(3, 2, 3, 2);
            txtPnRes.Name = "txtPnRes";
            txtPnRes.Size = new Size(70, 23);
            txtPnRes.TabIndex = 43;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.Location = new Point(522, 121);
            label12.Name = "label12";
            label12.Size = new Size(37, 18);
            label12.TabIndex = 42;
            label12.Text = "Pn:";
            // 
            // lblResultados
            // 
            lblResultados.AutoSize = true;
            lblResultados.Location = new Point(302, 26);
            lblResultados.Name = "lblResultados";
            lblResultados.Size = new Size(67, 15);
            lblResultados.TabIndex = 29;
            lblResultados.Text = "Resultados:";
            // 
            // txtP0
            // 
            txtP0.Location = new Point(441, 120);
            txtP0.Margin = new Padding(3, 2, 3, 2);
            txtP0.Name = "txtP0";
            txtP0.Size = new Size(68, 23);
            txtP0.TabIndex = 41;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Location = new Point(405, 121);
            label11.Name = "label11";
            label11.Size = new Size(37, 18);
            label11.TabIndex = 40;
            label11.Text = "P0:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(19, 83);
            label5.Name = "label5";
            label5.Size = new Size(35, 18);
            label5.TabIndex = 30;
            label5.Text = "Lq:";
            // 
            // txtP
            // 
            txtP.Location = new Point(441, 82);
            txtP.Margin = new Padding(3, 2, 3, 2);
            txtP.Name = "txtP";
            txtP.Size = new Size(68, 23);
            txtP.TabIndex = 39;
            // 
            // txtLq
            // 
            txtLq.Location = new Point(54, 82);
            txtLq.Margin = new Padding(3, 2, 3, 2);
            txtLq.Name = "txtLq";
            txtLq.Size = new Size(70, 23);
            txtLq.TabIndex = 31;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(405, 84);
            label10.Name = "label10";
            label10.Size = new Size(26, 18);
            label10.TabIndex = 38;
            label10.Text = "P:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(10, 121);
            label6.Name = "label6";
            label6.Size = new Size(43, 18);
            label6.TabIndex = 32;
            label6.Text = "Wq:";
            // 
            // txtWq
            // 
            txtWq.Location = new Point(54, 120);
            txtWq.Margin = new Padding(3, 2, 3, 2);
            txtWq.Name = "txtWq";
            txtWq.Size = new Size(70, 23);
            txtWq.TabIndex = 33;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(127, 83);
            label7.Name = "label7";
            label7.Size = new Size(33, 18);
            label7.TabIndex = 34;
            label7.Text = "Ls:";
            // 
            // txtWs
            // 
            txtWs.Location = new Point(175, 120);
            txtWs.Margin = new Padding(3, 2, 3, 2);
            txtWs.Name = "txtWs";
            txtWs.Size = new Size(76, 23);
            txtWs.TabIndex = 37;
            // 
            // txtLs
            // 
            txtLs.Location = new Point(175, 82);
            txtLs.Margin = new Padding(3, 2, 3, 2);
            txtLs.Name = "txtLs";
            txtLs.Size = new Size(76, 23);
            txtLs.TabIndex = 35;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(127, 121);
            label8.Name = "label8";
            label8.Size = new Size(41, 18);
            label8.TabIndex = 36;
            label8.Text = "Ws:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(468, 75);
            label3.Name = "label3";
            label3.Size = new Size(24, 15);
            label3.TabIndex = 64;
            label3.Text = "Pn:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(223, 75);
            label2.Name = "label2";
            label2.Size = new Size(46, 15);
            label2.TabIndex = 63;
            label2.Text = "μ (mu):";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(100, 75);
            label1.Name = "label1";
            label1.Size = new Size(67, 15);
            label1.TabIndex = 62;
            label1.Text = "λ (lambda):";
            // 
            // txtPn
            // 
            txtPn.Location = new Point(468, 92);
            txtPn.Margin = new Padding(3, 2, 3, 2);
            txtPn.Name = "txtPn";
            txtPn.Size = new Size(93, 23);
            txtPn.TabIndex = 60;
            // 
            // txtMu
            // 
            txtMu.Location = new Point(223, 92);
            txtMu.Margin = new Padding(3, 2, 3, 2);
            txtMu.Name = "txtMu";
            txtMu.Size = new Size(93, 23);
            txtMu.TabIndex = 59;
            // 
            // txtLambda
            // 
            txtLambda.Location = new Point(100, 92);
            txtLambda.Margin = new Padding(3, 2, 3, 2);
            txtLambda.Name = "txtLambda";
            txtLambda.Size = new Size(93, 23);
            txtLambda.TabIndex = 58;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(258, 172);
            btnCalcular.Margin = new Padding(3, 2, 3, 2);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(109, 26);
            btnCalcular.TabIndex = 57;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // label4
            // 
            label4.Dock = DockStyle.Top;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(0, 0);
            label4.Name = "label4";
            label4.Size = new Size(709, 50);
            label4.TabIndex = 70;
            label4.Text = "M/M/1/N";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // MM1N
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(709, 418);
            Controls.Add(label4);
            Controls.Add(label13);
            Controls.Add(txtN);
            Controls.Add(lblError);
            Controls.Add(panelResultados);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtPn);
            Controls.Add(txtMu);
            Controls.Add(txtLambda);
            Controls.Add(btnCalcular);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "MM1N";
            Text = "MM1N";
            panelResultados.ResumeLayout(false);
            panelResultados.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label13;
        private TextBox txtN;
        private Label lblError;
        private Panel panelResultados;
        private TextBox txtPnRes;
        private Label label12;
        private Label lblResultados;
        private TextBox txtP0;
        private Label label11;
        private Label label5;
        private TextBox txtP;
        private TextBox txtLq;
        private Label label10;
        private Label label6;
        private TextBox txtWq;
        private Label label7;
        private TextBox txtWs;
        private TextBox txtLs;
        private Label label8;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtPn;
        private TextBox txtMu;
        private TextBox txtLambda;
        private Button btnCalcular;
        private Label label15;
        private TextBox txtWb;
        private TextBox txtLb;
        private Label label16;
        private TextBox txtPb;
        private Label label14;
        private TextBox txtLambdaE;
        private TextBox txtPe;
        private Label label17;
        private Label label18;
        private Label label4;
    }
}