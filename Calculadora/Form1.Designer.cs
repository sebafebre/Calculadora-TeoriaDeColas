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
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            iconMenuItem1 = new FontAwesome.Sharp.IconMenuItem();
            iconMenuItem2 = new FontAwesome.Sharp.IconMenuItem();
            panelBotones.SuspendLayout();
            panelPantalla.SuspendLayout();
            SuspendLayout();
            // 
            // panelBotones
            // 
            panelBotones.BackColor = Color.Khaki;
            panelBotones.Controls.Add(btnMD1);
            panelBotones.Controls.Add(btnMG1);
            panelBotones.Controls.Add(MMN);
            panelBotones.Controls.Add(btnMM2);
            panelBotones.Controls.Add(btnMM1N);
            panelBotones.Controls.Add(btnMM1);
            panelBotones.Dock = DockStyle.Left;
            panelBotones.Location = new Point(0, 0);
            panelBotones.Margin = new Padding(3, 2, 3, 2);
            panelBotones.Name = "panelBotones";
            panelBotones.Size = new Size(171, 418);
            panelBotones.TabIndex = 0;
            panelBotones.Paint += panelBotones_Paint;
            // 
            // btnMD1
            // 
            btnMD1.BackColor = Color.Khaki;
            btnMD1.Dock = DockStyle.Top;
            btnMD1.FlatAppearance.BorderColor = Color.Black;
            btnMD1.FlatAppearance.BorderSize = 0;
            btnMD1.FlatStyle = FlatStyle.Flat;
            btnMD1.Font = new Font("Segoe UI", 14.25F);
            btnMD1.Location = new Point(0, 250);
            btnMD1.Margin = new Padding(5);
            btnMD1.Name = "btnMD1";
            btnMD1.Padding = new Padding(5);
            btnMD1.Size = new Size(171, 50);
            btnMD1.TabIndex = 11;
            btnMD1.Text = "M/D/1";
            btnMD1.UseVisualStyleBackColor = false;
            btnMD1.Click += btnMD1_Click;
            // 
            // btnMG1
            // 
            btnMG1.BackColor = Color.Khaki;
            btnMG1.Dock = DockStyle.Top;
            btnMG1.FlatAppearance.BorderColor = Color.Black;
            btnMG1.FlatAppearance.BorderSize = 0;
            btnMG1.FlatStyle = FlatStyle.Flat;
            btnMG1.Font = new Font("Segoe UI", 14.25F);
            btnMG1.Location = new Point(0, 200);
            btnMG1.Margin = new Padding(5);
            btnMG1.Name = "btnMG1";
            btnMG1.Padding = new Padding(5);
            btnMG1.Size = new Size(171, 50);
            btnMG1.TabIndex = 10;
            btnMG1.Text = "M/G/1";
            btnMG1.UseVisualStyleBackColor = false;
            btnMG1.Click += btnMG1_Click;
            // 
            // MMN
            // 
            MMN.BackColor = Color.Khaki;
            MMN.Dock = DockStyle.Top;
            MMN.FlatAppearance.BorderColor = Color.Black;
            MMN.FlatAppearance.BorderSize = 0;
            MMN.FlatStyle = FlatStyle.Flat;
            MMN.Font = new Font("Segoe UI", 14.25F);
            MMN.Location = new Point(0, 150);
            MMN.Margin = new Padding(5);
            MMN.Name = "MMN";
            MMN.Padding = new Padding(5);
            MMN.Size = new Size(171, 50);
            MMN.TabIndex = 9;
            MMN.Text = "M/M/N";
            MMN.UseVisualStyleBackColor = false;
            MMN.Click += MMN_Click;
            // 
            // btnMM2
            // 
            btnMM2.BackColor = Color.Khaki;
            btnMM2.Dock = DockStyle.Top;
            btnMM2.FlatAppearance.BorderColor = Color.Black;
            btnMM2.FlatAppearance.BorderSize = 0;
            btnMM2.FlatStyle = FlatStyle.Flat;
            btnMM2.Font = new Font("Segoe UI", 14.25F);
            btnMM2.Location = new Point(0, 100);
            btnMM2.Margin = new Padding(5);
            btnMM2.Name = "btnMM2";
            btnMM2.Padding = new Padding(5);
            btnMM2.Size = new Size(171, 50);
            btnMM2.TabIndex = 8;
            btnMM2.Text = "M/M/2";
            btnMM2.UseVisualStyleBackColor = false;
            btnMM2.Click += btnMM2_Click;
            // 
            // btnMM1N
            // 
            btnMM1N.BackColor = Color.Khaki;
            btnMM1N.Dock = DockStyle.Top;
            btnMM1N.FlatAppearance.BorderColor = Color.Black;
            btnMM1N.FlatAppearance.BorderSize = 0;
            btnMM1N.FlatStyle = FlatStyle.Flat;
            btnMM1N.Font = new Font("Segoe UI", 14.25F);
            btnMM1N.Location = new Point(0, 50);
            btnMM1N.Margin = new Padding(5);
            btnMM1N.Name = "btnMM1N";
            btnMM1N.Padding = new Padding(5);
            btnMM1N.Size = new Size(171, 50);
            btnMM1N.TabIndex = 7;
            btnMM1N.Text = "M/M/1/N";
            btnMM1N.UseVisualStyleBackColor = false;
            btnMM1N.Click += btnMM1N_Click;
            // 
            // btnMM1
            // 
            btnMM1.BackColor = Color.Khaki;
            btnMM1.Dock = DockStyle.Top;
            btnMM1.FlatAppearance.BorderColor = Color.Black;
            btnMM1.FlatAppearance.BorderSize = 0;
            btnMM1.FlatStyle = FlatStyle.Flat;
            btnMM1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnMM1.Location = new Point(0, 0);
            btnMM1.Margin = new Padding(5);
            btnMM1.Name = "btnMM1";
            btnMM1.Padding = new Padding(5);
            btnMM1.Size = new Size(171, 50);
            btnMM1.TabIndex = 6;
            btnMM1.Text = "M/M/1";
            btnMM1.UseVisualStyleBackColor = false;
            btnMM1.Click += btnMM1_Click;
            // 
            // panelPantalla
            // 
            panelPantalla.Controls.Add(label4);
            panelPantalla.Controls.Add(label3);
            panelPantalla.Controls.Add(label2);
            panelPantalla.Controls.Add(label1);
            panelPantalla.Dock = DockStyle.Fill;
            panelPantalla.Location = new Point(171, 0);
            panelPantalla.Margin = new Padding(3, 2, 3, 2);
            panelPantalla.Name = "panelPantalla";
            panelPantalla.Size = new Size(709, 418);
            panelPantalla.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(76, 167);
            label4.Name = "label4";
            label4.Size = new Size(0, 15);
            label4.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(76, 130);
            label3.Name = "label3";
            label3.Size = new Size(0, 15);
            label3.TabIndex = 2;
            // 
            // label2
            // 
            label2.Dock = DockStyle.Top;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(0, 50);
            label2.Name = "label2";
            label2.Padding = new Padding(5);
            label2.Size = new Size(709, 150);
            label2.TabIndex = 1;
            label2.Text = "1) Elija el modelo que dese acalcular\r\n\r\n2) Complete las variables necesarias para el calculo (lambda, mu , N, sigma)\r\n\r\n3) Dele al boton \"Calcular\" y apareceran los resultados debajo del boton";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(709, 50);
            label1.TabIndex = 0;
            label1.Text = "Calculadora teoria de colas";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // iconMenuItem1
            // 
            iconMenuItem1.IconChar = FontAwesome.Sharp.IconChar.None;
            iconMenuItem1.IconColor = Color.Black;
            iconMenuItem1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconMenuItem1.Name = "iconMenuItem1";
            iconMenuItem1.Size = new Size(32, 19);
            iconMenuItem1.Text = "iconMenuItem1";
            // 
            // iconMenuItem2
            // 
            iconMenuItem2.IconChar = FontAwesome.Sharp.IconChar.None;
            iconMenuItem2.IconColor = Color.Black;
            iconMenuItem2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconMenuItem2.Name = "iconMenuItem2";
            iconMenuItem2.Size = new Size(32, 19);
            iconMenuItem2.Text = "iconMenuItem2";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(880, 418);
            Controls.Add(panelPantalla);
            Controls.Add(panelBotones);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            Name = "Form1";
            Text = "Calculadora Teoría de Colas";
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
        private FontAwesome.Sharp.IconMenuItem iconMenuItem1;
        private FontAwesome.Sharp.IconMenuItem iconMenuItem2;
    }
}
