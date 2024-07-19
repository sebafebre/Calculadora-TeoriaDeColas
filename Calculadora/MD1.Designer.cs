namespace Calculadora
{
    partial class MD1
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
            label2 = new Label();
            label1 = new Label();
            txtMu = new TextBox();
            txtLambda = new TextBox();
            btnCalcular = new Button();
            panelResultados.SuspendLayout();
            SuspendLayout();
            // 
            // lblError
            // 
            lblError.AutoSize = true;
            lblError.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblError.ForeColor = Color.Red;
            lblError.Location = new Point(401, 193);
            lblError.Name = "lblError";
            lblError.Size = new Size(233, 20);
            lblError.TabIndex = 86;
            lblError.Text = "Debe ingresar el lambda y el mu";
            lblError.Visible = false;
            // 
            // panelResultados
            // 
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
            panelResultados.Location = new Point(0, 315);
            panelResultados.Name = "panelResultados";
            panelResultados.Size = new Size(1013, 251);
            panelResultados.TabIndex = 85;
            panelResultados.Visible = false;
            // 
            // lblResultados
            // 
            lblResultados.AutoSize = true;
            lblResultados.Font = new Font("Segoe UI", 18F);
            lblResultados.Location = new Point(421, 31);
            lblResultados.Name = "lblResultados";
            lblResultados.Size = new Size(169, 41);
            lblResultados.TabIndex = 29;
            lblResultados.Text = "Resultados:";
            // 
            // txtP0
            // 
            txtP0.Location = new Point(677, 172);
            txtP0.Name = "txtP0";
            txtP0.Size = new Size(89, 27);
            txtP0.TabIndex = 41;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Location = new Point(626, 174);
            label11.Name = "label11";
            label11.Size = new Size(49, 25);
            label11.TabIndex = 40;
            label11.Text = "P0:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(230, 123);
            label5.Name = "label5";
            label5.Size = new Size(47, 25);
            label5.TabIndex = 30;
            label5.Text = "Lq:";
            // 
            // txtP
            // 
            txtP.Location = new Point(677, 123);
            txtP.Name = "txtP";
            txtP.Size = new Size(89, 27);
            txtP.TabIndex = 39;
            // 
            // txtLq
            // 
            txtLq.Location = new Point(285, 123);
            txtLq.Name = "txtLq";
            txtLq.Size = new Size(89, 27);
            txtLq.TabIndex = 31;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(640, 125);
            label10.Name = "label10";
            label10.Size = new Size(35, 25);
            label10.TabIndex = 38;
            label10.Text = "P:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(220, 170);
            label6.Name = "label6";
            label6.Size = new Size(57, 25);
            label6.TabIndex = 32;
            label6.Text = "Wq:";
            // 
            // txtWq
            // 
            txtWq.Location = new Point(285, 170);
            txtWq.Name = "txtWq";
            txtWq.Size = new Size(89, 27);
            txtWq.TabIndex = 33;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(421, 125);
            label7.Name = "label7";
            label7.Size = new Size(45, 25);
            label7.TabIndex = 34;
            label7.Text = "Ls:";
            // 
            // txtWs
            // 
            txtWs.Location = new Point(472, 170);
            txtWs.Name = "txtWs";
            txtWs.Size = new Size(89, 27);
            txtWs.TabIndex = 37;
            // 
            // txtLs
            // 
            txtLs.Location = new Point(472, 121);
            txtLs.Name = "txtLs";
            txtLs.Size = new Size(89, 27);
            txtLs.TabIndex = 35;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(411, 174);
            label8.Name = "label8";
            label8.Size = new Size(55, 25);
            label8.TabIndex = 36;
            label8.Text = "Ws:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold | FontStyle.Italic);
            label2.Location = new Point(526, 78);
            label2.Name = "label2";
            label2.Size = new Size(67, 23);
            label2.TabIndex = 82;
            label2.Text = "μ (mu):";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold | FontStyle.Italic);
            label1.Location = new Point(363, 78);
            label1.Name = "label1";
            label1.Size = new Size(101, 23);
            label1.TabIndex = 81;
            label1.Text = "λ (lambda):";
            // 
            // txtMu
            // 
            txtMu.Location = new Point(526, 101);
            txtMu.Name = "txtMu";
            txtMu.Size = new Size(97, 27);
            txtMu.TabIndex = 78;
            // 
            // txtLambda
            // 
            txtLambda.Location = new Point(363, 101);
            txtLambda.Name = "txtLambda";
            txtLambda.Size = new Size(97, 27);
            txtLambda.TabIndex = 77;
            // 
            // btnCalcular
            // 
            btnCalcular.BackColor = Color.FromArgb(64, 83, 76);
            btnCalcular.Location = new Point(421, 242);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(169, 47);
            btnCalcular.TabIndex = 76;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = false;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // MD1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1013, 566);
            Controls.Add(lblError);
            Controls.Add(panelResultados);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtMu);
            Controls.Add(txtLambda);
            Controls.Add(btnCalcular);
            Name = "MD1";
            Text = "MD1";
            panelResultados.ResumeLayout(false);
            panelResultados.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblError;
        private Panel panelResultados;
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
        private Label label2;
        private Label label1;
        private TextBox txtMu;
        private TextBox txtLambda;
        private Button btnCalcular;
    }
}