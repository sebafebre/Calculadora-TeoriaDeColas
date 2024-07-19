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
            txtA = new TextBox();
            label15 = new Label();
            txtN = new TextBox();
            label14 = new Label();
            txtPaR = new TextBox();
            label4 = new Label();
            txtPnRes = new TextBox();
            label12 = new Label();
            lblResultados = new Label();
            txtP0 = new TextBox();
            txtPc = new TextBox();
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
            lblMu2 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtMu2 = new TextBox();
            txtPn = new TextBox();
            txtMu1 = new TextBox();
            txtLambda = new TextBox();
            btnCalcular = new Button();
            rbIguales = new RadioButton();
            rbConSeleccion = new RadioButton();
            rbSinSeleccion = new RadioButton();
            gbVelocidades = new GroupBox();
            label13 = new Label();
            txtPa = new TextBox();
            panelResultados.SuspendLayout();
            gbVelocidades.SuspendLayout();
            SuspendLayout();
            // 
            // lblError
            // 
            lblError.AutoSize = true;
            lblError.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblError.ForeColor = Color.Red;
            lblError.Location = new Point(390, 187);
            lblError.Name = "lblError";
            lblError.Size = new Size(233, 20);
            lblError.TabIndex = 54;
            lblError.Text = "Debe ingresar el lambda y el mu";
            lblError.Visible = false;
            // 
            // panelResultados
            // 
            panelResultados.Controls.Add(txtA);
            panelResultados.Controls.Add(label15);
            panelResultados.Controls.Add(txtN);
            panelResultados.Controls.Add(label14);
            panelResultados.Controls.Add(txtPaR);
            panelResultados.Controls.Add(label4);
            panelResultados.Controls.Add(txtPnRes);
            panelResultados.Controls.Add(label12);
            panelResultados.Controls.Add(lblResultados);
            panelResultados.Controls.Add(txtP0);
            panelResultados.Controls.Add(txtPc);
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
            panelResultados.Location = new Point(0, 312);
            panelResultados.Name = "panelResultados";
            panelResultados.Size = new Size(1013, 254);
            panelResultados.TabIndex = 53;
            panelResultados.Visible = false;
            // 
            // txtA
            // 
            txtA.Location = new Point(838, 59);
            txtA.Name = "txtA";
            txtA.Size = new Size(98, 27);
            txtA.TabIndex = 49;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label15.Location = new Point(795, 61);
            label15.Name = "label15";
            label15.Size = new Size(33, 25);
            label15.TabIndex = 48;
            label15.Text = "a:";
            // 
            // txtN
            // 
            txtN.Location = new Point(838, 158);
            txtN.Name = "txtN";
            txtN.Size = new Size(98, 27);
            txtN.TabIndex = 47;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label14.Location = new Point(795, 162);
            label14.Name = "label14";
            label14.Size = new Size(37, 25);
            label14.TabIndex = 46;
            label14.Text = "N:";
            // 
            // txtPaR
            // 
            txtPaR.Location = new Point(838, 107);
            txtPaR.Name = "txtPaR";
            txtPaR.Size = new Size(98, 27);
            txtPaR.TabIndex = 45;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(784, 111);
            label4.Name = "label4";
            label4.Size = new Size(48, 25);
            label4.TabIndex = 44;
            label4.Text = "Pa:";
            // 
            // txtPnRes
            // 
            txtPnRes.Location = new Point(657, 162);
            txtPnRes.Name = "txtPnRes";
            txtPnRes.Size = new Size(98, 27);
            txtPnRes.TabIndex = 43;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.Location = new Point(602, 164);
            label12.Name = "label12";
            label12.Size = new Size(49, 25);
            label12.TabIndex = 42;
            label12.Text = "Pn:";
            // 
            // lblResultados
            // 
            lblResultados.AutoSize = true;
            lblResultados.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblResultados.Location = new Point(422, 11);
            lblResultados.Name = "lblResultados";
            lblResultados.Size = new Size(169, 41);
            lblResultados.TabIndex = 29;
            lblResultados.Text = "Resultados:";
            // 
            // txtP0
            // 
            txtP0.Location = new Point(459, 164);
            txtP0.Name = "txtP0";
            txtP0.Size = new Size(98, 27);
            txtP0.TabIndex = 41;
            // 
            // txtPc
            // 
            txtPc.Location = new Point(657, 109);
            txtPc.Name = "txtPc";
            txtPc.Size = new Size(98, 27);
            txtPc.TabIndex = 39;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Location = new Point(404, 164);
            label11.Name = "label11";
            label11.Size = new Size(49, 25);
            label11.TabIndex = 40;
            label11.Text = "P0:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(25, 111);
            label5.Name = "label5";
            label5.Size = new Size(47, 25);
            label5.TabIndex = 30;
            label5.Text = "Lq:";
            // 
            // txtP
            // 
            txtP.Location = new Point(459, 115);
            txtP.Name = "txtP";
            txtP.Size = new Size(98, 27);
            txtP.TabIndex = 39;
            // 
            // txtLq
            // 
            txtLq.Location = new Point(78, 113);
            txtLq.Name = "txtLq";
            txtLq.Size = new Size(98, 27);
            txtLq.TabIndex = 31;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(418, 115);
            label10.Name = "label10";
            label10.Size = new Size(35, 25);
            label10.TabIndex = 38;
            label10.Text = "P:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(15, 158);
            label6.Name = "label6";
            label6.Size = new Size(57, 25);
            label6.TabIndex = 32;
            label6.Text = "Wq:";
            // 
            // txtWq
            // 
            txtWq.Location = new Point(78, 160);
            txtWq.Name = "txtWq";
            txtWq.Size = new Size(98, 27);
            txtWq.TabIndex = 33;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(604, 113);
            label9.Name = "label9";
            label9.Size = new Size(47, 25);
            label9.TabIndex = 38;
            label9.Text = "Pc:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(223, 115);
            label7.Name = "label7";
            label7.Size = new Size(45, 25);
            label7.TabIndex = 34;
            label7.Text = "Ls:";
            // 
            // txtWs
            // 
            txtWs.Location = new Point(274, 162);
            txtWs.Name = "txtWs";
            txtWs.Size = new Size(98, 27);
            txtWs.TabIndex = 37;
            // 
            // txtLs
            // 
            txtLs.Location = new Point(274, 113);
            txtLs.Name = "txtLs";
            txtLs.Size = new Size(98, 27);
            txtLs.TabIndex = 35;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(213, 164);
            label8.Name = "label8";
            label8.Size = new Size(55, 25);
            label8.TabIndex = 36;
            label8.Text = "Ws:";
            // 
            // lblMu2
            // 
            lblMu2.AutoSize = true;
            lblMu2.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblMu2.Location = new Point(272, 143);
            lblMu2.Name = "lblMu2";
            lblMu2.Size = new Size(70, 20);
            lblMu2.TabIndex = 52;
            lblMu2.Text = "μ2 (mu):";
            lblMu2.Visible = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold | FontStyle.Italic);
            label3.Location = new Point(390, 76);
            label3.Name = "label3";
            label3.Size = new Size(36, 23);
            label3.TabIndex = 51;
            label3.Text = "Pn:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold | FontStyle.Italic);
            label2.Location = new Point(269, 76);
            label2.Name = "label2";
            label2.Size = new Size(67, 23);
            label2.TabIndex = 50;
            label2.Text = "μ (mu):";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold | FontStyle.Italic);
            label1.Location = new Point(144, 76);
            label1.Name = "label1";
            label1.Size = new Size(101, 23);
            label1.TabIndex = 49;
            label1.Text = "λ (lambda):";
            // 
            // txtMu2
            // 
            txtMu2.Location = new Point(272, 166);
            txtMu2.Name = "txtMu2";
            txtMu2.Size = new Size(75, 27);
            txtMu2.TabIndex = 48;
            txtMu2.Visible = false;
            // 
            // txtPn
            // 
            txtPn.Location = new Point(390, 102);
            txtPn.Name = "txtPn";
            txtPn.Size = new Size(77, 27);
            txtPn.TabIndex = 47;
            // 
            // txtMu1
            // 
            txtMu1.Location = new Point(272, 102);
            txtMu1.Name = "txtMu1";
            txtMu1.Size = new Size(77, 27);
            txtMu1.TabIndex = 46;
            // 
            // txtLambda
            // 
            txtLambda.Location = new Point(154, 102);
            txtLambda.Name = "txtLambda";
            txtLambda.Size = new Size(77, 27);
            txtLambda.TabIndex = 45;
            // 
            // btnCalcular
            // 
            btnCalcular.BackColor = Color.FromArgb(64, 83, 76);
            btnCalcular.Location = new Point(418, 228);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(176, 47);
            btnCalcular.TabIndex = 44;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = false;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // rbIguales
            // 
            rbIguales.AutoSize = true;
            rbIguales.Font = new Font("Segoe UI", 9.2F, FontStyle.Bold | FontStyle.Italic);
            rbIguales.Location = new Point(15, 29);
            rbIguales.Name = "rbIguales";
            rbIguales.Size = new Size(84, 25);
            rbIguales.TabIndex = 55;
            rbIguales.TabStop = true;
            rbIguales.Text = "Iguales";
            rbIguales.UseVisualStyleBackColor = true;
            rbIguales.CheckedChanged += rbIguales_CheckedChanged;
            // 
            // rbConSeleccion
            // 
            rbConSeleccion.AutoSize = true;
            rbConSeleccion.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            rbConSeleccion.Location = new Point(15, 69);
            rbConSeleccion.Name = "rbConSeleccion";
            rbConSeleccion.Size = new Size(128, 24);
            rbConSeleccion.TabIndex = 56;
            rbConSeleccion.TabStop = true;
            rbConSeleccion.Text = "Con Seleccion";
            rbConSeleccion.UseVisualStyleBackColor = true;
            rbConSeleccion.CheckedChanged += rbConSeleccion_CheckedChanged;
            // 
            // rbSinSeleccion
            // 
            rbSinSeleccion.AutoSize = true;
            rbSinSeleccion.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            rbSinSeleccion.Location = new Point(15, 108);
            rbSinSeleccion.Name = "rbSinSeleccion";
            rbSinSeleccion.Size = new Size(122, 24);
            rbSinSeleccion.TabIndex = 57;
            rbSinSeleccion.TabStop = true;
            rbSinSeleccion.Text = "Sin Seleccion";
            rbSinSeleccion.UseVisualStyleBackColor = true;
            rbSinSeleccion.CheckedChanged += rbSinSeleccion_CheckedChanged;
            // 
            // gbVelocidades
            // 
            gbVelocidades.Controls.Add(rbSinSeleccion);
            gbVelocidades.Controls.Add(rbIguales);
            gbVelocidades.Controls.Add(rbConSeleccion);
            gbVelocidades.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            gbVelocidades.ForeColor = Color.FromArgb(214, 189, 152);
            gbVelocidades.Location = new Point(714, 64);
            gbVelocidades.Name = "gbVelocidades";
            gbVelocidades.Size = new Size(149, 153);
            gbVelocidades.TabIndex = 58;
            gbVelocidades.TabStop = false;
            gbVelocidades.Text = "Velocidades:";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold | FontStyle.Italic);
            label13.Location = new Point(512, 76);
            label13.Name = "label13";
            label13.Size = new Size(36, 23);
            label13.TabIndex = 60;
            label13.Text = "Pa:";
            // 
            // txtPa
            // 
            txtPa.Location = new Point(508, 102);
            txtPa.Name = "txtPa";
            txtPa.Size = new Size(77, 27);
            txtPa.TabIndex = 59;
            // 
            // MM2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1013, 566);
            Controls.Add(label13);
            Controls.Add(txtPa);
            Controls.Add(gbVelocidades);
            Controls.Add(lblError);
            Controls.Add(panelResultados);
            Controls.Add(lblMu2);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtMu2);
            Controls.Add(txtPn);
            Controls.Add(txtMu1);
            Controls.Add(txtLambda);
            Controls.Add(btnCalcular);
            Name = "MM2";
            Text = "MM2";
            panelResultados.ResumeLayout(false);
            panelResultados.PerformLayout();
            gbVelocidades.ResumeLayout(false);
            gbVelocidades.PerformLayout();
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
        private TextBox txtPc;
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
        private Label lblMu2;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtMu2;
        private TextBox txtPn;
        private TextBox txtMu1;
        private TextBox txtLambda;
        private Button btnCalcular;
        private RadioButton rbIguales;
        private RadioButton rbConSeleccion;
        private RadioButton rbSinSeleccion;
        private GroupBox gbVelocidades;
        private TextBox txtPaR;
        private Label label4;
        private Label label13;
        private TextBox txtPa;
        private TextBox txtN;
        private Label label14;
        private TextBox txtA;
        private Label label15;
    }
}