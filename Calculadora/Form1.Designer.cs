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
            panelPantalla = new Panel();
            SuspendLayout();
            // 
            // panelBotones
            // 
            panelBotones.Dock = DockStyle.Left;
            panelBotones.Location = new Point(0, 0);
            panelBotones.Name = "panelBotones";
            panelBotones.Size = new Size(195, 497);
            panelBotones.TabIndex = 0;
            // 
            // panelPantalla
            // 
            panelPantalla.Dock = DockStyle.Fill;
            panelPantalla.Location = new Point(0, 0);
            panelPantalla.Name = "panelPantalla";
            panelPantalla.Size = new Size(1006, 497);
            panelPantalla.TabIndex = 1;
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
            ResumeLayout(false);
        }

        #endregion

        private Panel panelBotones;
        private Panel panelPantalla;
    }
}
