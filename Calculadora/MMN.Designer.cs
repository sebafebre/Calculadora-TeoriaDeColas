namespace Calculadora
{
    partial class MMN
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
            txtWQ1 = new TextBox();
            label15 = new Label();
            lblResultados = new Label();
            txtW1 = new TextBox();
            label9 = new Label();
            btnCalcular = new Button();
            label4 = new Label();
            label13 = new Label();
            txtQ1 = new TextBox();
            txtW0 = new TextBox();
            label14 = new Label();
            txtTs1 = new TextBox();
            panelResultados.SuspendLayout();
            SuspendLayout();
            // 
            // lblError
            // 
            lblError.AutoSize = true;
            lblError.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblError.ForeColor = Color.Red;
            lblError.Location = new Point(347, 204);
            lblError.Name = "lblError";
            lblError.Size = new Size(233, 20);
            lblError.TabIndex = 69;
            lblError.Text = "Debe ingresar el lambda y el mu";
            lblError.Visible = false;
            // 
            // panelResultados
            // 
            panelResultados.Controls.Add(txtWQ1);
            panelResultados.Controls.Add(label15);
            panelResultados.Controls.Add(lblResultados);
            panelResultados.Controls.Add(txtW1);
            panelResultados.Controls.Add(label9);
            panelResultados.Dock = DockStyle.Bottom;
            panelResultados.Location = new Point(0, 352);
            panelResultados.Name = "panelResultados";
            panelResultados.Size = new Size(1013, 214);
            panelResultados.TabIndex = 68;
            panelResultados.Visible = false;
            // 
            // txtWQ1
            // 
            txtWQ1.Location = new Point(557, 106);
            txtWQ1.Name = "txtWQ1";
            txtWQ1.Size = new Size(80, 27);
            txtWQ1.TabIndex = 45;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label15.Location = new Point(480, 108);
            label15.Name = "label15";
            label15.Size = new Size(71, 25);
            label15.TabIndex = 44;
            label15.Text = "Wq1:";
            // 
            // lblResultados
            // 
            lblResultados.AutoSize = true;
            lblResultados.Font = new Font("Segoe UI", 18F);
            lblResultados.Location = new Point(392, 12);
            lblResultados.Name = "lblResultados";
            lblResultados.Size = new Size(169, 41);
            lblResultados.TabIndex = 29;
            lblResultados.Text = "Resultados:";
            // 
            // txtW1
            // 
            txtW1.Location = new Point(331, 106);
            txtW1.Name = "txtW1";
            txtW1.Size = new Size(80, 27);
            txtW1.TabIndex = 39;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(268, 108);
            label9.Name = "label9";
            label9.Size = new Size(57, 25);
            label9.TabIndex = 38;
            label9.Text = "W1:";
            // 
            // btnCalcular
            // 
            btnCalcular.BackColor = Color.FromArgb(64, 83, 76);
            btnCalcular.Location = new Point(375, 236);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(170, 41);
            btnCalcular.TabIndex = 59;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = false;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold | FontStyle.Italic);
            label4.Location = new Point(424, 113);
            label4.Name = "label4";
            label4.Size = new Size(38, 23);
            label4.TabIndex = 73;
            label4.Text = "Q1:";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold | FontStyle.Italic);
            label13.Location = new Point(247, 113);
            label13.Name = "label13";
            label13.Size = new Size(42, 23);
            label13.TabIndex = 72;
            label13.Text = "W0:";
            // 
            // txtQ1
            // 
            txtQ1.Location = new Point(424, 136);
            txtQ1.Name = "txtQ1";
            txtQ1.Size = new Size(75, 27);
            txtQ1.TabIndex = 71;
            // 
            // txtW0
            // 
            txtW0.Location = new Point(247, 136);
            txtW0.Name = "txtW0";
            txtW0.Size = new Size(70, 27);
            txtW0.TabIndex = 70;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold | FontStyle.Italic);
            label14.Location = new Point(587, 113);
            label14.Name = "label14";
            label14.Size = new Size(42, 23);
            label14.TabIndex = 75;
            label14.Text = "Ts1:";
            // 
            // txtTs1
            // 
            txtTs1.Location = new Point(587, 136);
            txtTs1.Name = "txtTs1";
            txtTs1.Size = new Size(70, 27);
            txtTs1.TabIndex = 74;
            // 
            // MMN
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1013, 566);
            Controls.Add(label14);
            Controls.Add(txtTs1);
            Controls.Add(label4);
            Controls.Add(label13);
            Controls.Add(txtQ1);
            Controls.Add(txtW0);
            Controls.Add(lblError);
            Controls.Add(panelResultados);
            Controls.Add(btnCalcular);
            Name = "MMN";
            Text = "MMN";
            panelResultados.ResumeLayout(false);
            panelResultados.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblError;
        private Panel panelResultados;
        private Label lblResultados;
        private TextBox txtW1;
        private Label label9;
        private Button btnCalcular;
        private Label label4;
        private Label label13;
        private TextBox txtQ1;
        private TextBox txtW0;
        private Label label14;
        private TextBox txtTs1;
        private TextBox txtWQ1;
        private Label label15;
    }
}