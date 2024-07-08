namespace Calculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMM1_Click(object sender, EventArgs e)
        {
            AbrirPanel(new MM1());
        }

        private void btnMM1N_Click(object sender, EventArgs e)
        {
            AbrirPanel(new MM1N());

        }

        private void btnMM2_Click(object sender, EventArgs e)
        {
            AbrirPanel(new MM2());
        }

        private void MMN_Click(object sender, EventArgs e)
        {
            AbrirPanel(new MMN());
        }

        private void btnMG1_Click(object sender, EventArgs e)
        {
            AbrirPanel(new MG1());
        }

        private void btnMD1_Click(object sender, EventArgs e)
        {
            AbrirPanel(new MD1());
        }

        private void AbrirPanel(Form form)
        {
            // Limpiar el panel antes de agregar el nuevo formulario
            panelPantalla.Controls.Clear();

            // Configurar el formulario hijo
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;

            // Agregar el formulario al panel y mostrarlo
            panelPantalla.Controls.Add(form);
            form.Show();
        }
    }
}
