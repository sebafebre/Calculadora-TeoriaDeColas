namespace Calculadora
{
    partial class MG1
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
            btnCalcular = new Button();
            SuspendLayout();
            // 
            // lblResultados
            // 
            lblResultados.AutoSize = true;
            lblResultados.Location = new Point(352, 253);
            lblResultados.Name = "lblResultados";
            lblResultados.Size = new Size(84, 20);
            lblResultados.TabIndex = 29;
            lblResultados.Text = "Resultados:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(539, 41);
            label4.Name = "label4";
            label4.Size = new Size(27, 20);
            label4.TabIndex = 28;
            label4.Text = "Pa:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(442, 41);
            label3.Name = "label3";
            label3.Size = new Size(28, 20);
            label3.TabIndex = 27;
            label3.Text = "Pn:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(271, 41);
            label2.Name = "label2";
            label2.Size = new Size(56, 20);
            label2.TabIndex = 26;
            label2.Text = "μ (mu):";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(103, 41);
            label1.Name = "label1";
            label1.Size = new Size(84, 20);
            label1.TabIndex = 25;
            label1.Text = "λ (lambda):";
            // 
            // txtPa
            // 
            txtPa.Location = new Point(539, 64);
            txtPa.Name = "txtPa";
            txtPa.Size = new Size(75, 27);
            txtPa.TabIndex = 24;
            // 
            // txtPn
            // 
            txtPn.Location = new Point(414, 64);
            txtPn.Name = "txtPn";
            txtPn.Size = new Size(70, 27);
            txtPn.TabIndex = 23;
            // 
            // txtMu
            // 
            txtMu.Location = new Point(271, 64);
            txtMu.Name = "txtMu";
            txtMu.Size = new Size(75, 27);
            txtMu.TabIndex = 22;
            // 
            // txtLambda
            // 
            txtLambda.Location = new Point(103, 64);
            txtLambda.Name = "txtLambda";
            txtLambda.Size = new Size(84, 27);
            txtLambda.TabIndex = 21;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(332, 199);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(125, 34);
            btnCalcular.TabIndex = 20;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            // 
            // MG1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblResultados);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtPa);
            Controls.Add(txtPn);
            Controls.Add(txtMu);
            Controls.Add(txtLambda);
            Controls.Add(btnCalcular);
            Name = "MG1";
            Text = "MG1";
            ResumeLayout(false);
            PerformLayout();
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
        private Button btnCalcular;
    }
}