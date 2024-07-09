namespace Calculadora
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panelBotones = new Panel();
            btnMD1 = new Button();
            btnMG1 = new Button();
            MMN = new Button();
            btnMM2 = new Button();
            btnMM1N = new Button();
            btnMM1 = new Button();
            panelPantalla = new Panel();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            panelBotones.SuspendLayout();
            panelPantalla.SuspendLayout();
            SuspendLayout();
            // 
            // panelBotones
            // 
            panelBotones.Controls.Add(btnMD1);
            panelBotones.Controls.Add(btnMG1);
            panelBotones.Controls.Add(MMN);
            panelBotones.Controls.Add(btnMM2);
            panelBotones.Controls.Add(btnMM1N);
            panelBotones.Controls.Add(btnMM1);
            panelBotones.Dock = DockStyle.Left;
            panelBotones.Location = new Point(0, 0);
            panelBotones.Name = "panelBotones";
            panelBotones.Size = new Size(195, 497);
            panelBotones.TabIndex = 0;
            // 
            // btnMD1
            // 
            btnMD1.Location = new Point(50, 432);
            btnMD1.Name = "btnMD1";
            btnMD1.Size = new Size(94, 29);
            btnMD1.TabIndex = 11;
            btnMD1.Text = "MD1";
            btnMD1.UseVisualStyleBackColor = true;
            btnMD1.Click += btnMD1_Click;
            // 
            // btnMG1
            // 
            btnMG1.Location = new Point(50, 352);
            btnMG1.Name = "btnMG1";
            btnMG1.Size = new Size(94, 29);
            btnMG1.TabIndex = 10;
            btnMG1.Text = "MG1";
            btnMG1.UseVisualStyleBackColor = true;
            btnMG1.Click += btnMG1_Click;
            // 
            // MMN
            // 
            MMN.Location = new Point(50, 272);
            MMN.Name = "MMN";
            MMN.Size = new Size(94, 29);
            MMN.TabIndex = 9;
            MMN.Text = "MMN";
            MMN.UseVisualStyleBackColor = true;
            MMN.Click += MMN_Click;
            // 
            // btnMM2
            // 
            btnMM2.Location = new Point(50, 192);
            btnMM2.Name = "btnMM2";
            btnMM2.Size = new Size(94, 29);
            btnMM2.TabIndex = 8;
            btnMM2.Text = "MM2";
            btnMM2.UseVisualStyleBackColor = true;
            btnMM2.Click += btnMM2_Click;
            // 
            // btnMM1N
            // 
            btnMM1N.Location = new Point(50, 112);
            btnMM1N.Name = "btnMM1N";
            btnMM1N.Size = new Size(94, 29);
            btnMM1N.TabIndex = 7;
            btnMM1N.Text = "MM1N";
            btnMM1N.UseVisualStyleBackColor = true;
            btnMM1N.Click += btnMM1N_Click;
            // 
            // btnMM1
            // 
            btnMM1.Location = new Point(50, 32);
            btnMM1.Name = "btnMM1";
            btnMM1.Size = new Size(94, 29);
            btnMM1.TabIndex = 6;
            btnMM1.Text = "MM1";
            btnMM1.UseVisualStyleBackColor = true;
            btnMM1.Click += btnMM1_Click;
            // 
            // panelPantalla
            // 
            panelPantalla.Controls.Add(label4);
            panelPantalla.Controls.Add(label3);
            panelPantalla.Controls.Add(label2);
            panelPantalla.Controls.Add(label1);
            panelPantalla.Dock = DockStyle.Right;
            panelPantalla.Location = new Point(201, 0);
            panelPantalla.Name = "panelPantalla";
            panelPantalla.Size = new Size(805, 497);
            panelPantalla.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(299, 53);
            label1.Name = "label1";
            label1.Size = new Size(190, 20);
            label1.TabIndex = 0;
            label1.Text = "Calculadora teoria de colas";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(87, 127);
            label2.Name = "label2";
            label2.Size = new Size(253, 20);
            label2.TabIndex = 1;
            label2.Text = "1) Elija el modelo que dese acalcular";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(87, 174);
            label3.Name = "label3";
            label3.Size = new Size(511, 20);
            label3.TabIndex = 2;
            label3.Text = "2) Complete las variables necesarias para el calculo (lambda, mu , N, sigma)";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(87, 223);
            label4.Name = "label4";
            label4.Size = new Size(493, 20);
            label4.TabIndex = 3;
            label4.Text = "3) Dele al boton \"Calcular\" y apareceran los resultados debajo del boton.";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1006, 497);
            Controls.Add(panelBotones);
            Controls.Add(panelPantalla);
            Name = "Form1";
            Text = "Form1";
            panelBotones.ResumeLayout(false);
            panelPantalla.ResumeLayout(false);
            panelPantalla.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelBotones;
        private Panel panelPantalla;
        private Button btnMD1;
        private Button btnMG1;
        private Button MMN;
        private Button btnMM2;
        private Button btnMM1N;
        private Button btnMM1;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}
