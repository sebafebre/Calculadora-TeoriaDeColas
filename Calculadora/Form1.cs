namespace Calculadora
{
    public partial class Form1 : Form
    {
        private static Button _buttonActivo = null;
        private static Form _formActivo = null;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMM1_Click(object sender, EventArgs e)
        {
            AbrirPanel(new MM1(), (Button)sender);
        }

        private void btnMM1N_Click(object sender, EventArgs e)
        {
            AbrirPanel(new MM1N(), (Button)sender);

        }

        private void btnMM2_Click(object sender, EventArgs e)
        {
            AbrirPanel(new MM2(), (Button)sender);
        }

        private void MMN_Click(object sender, EventArgs e)
        {
            AbrirPanel(new MMN(), (Button)sender);
        }

        private void btnMG1_Click(object sender, EventArgs e)
        {
            AbrirPanel(new MG1(), (Button)sender);
        }

        private void btnMD1_Click(object sender, EventArgs e)
        {
            AbrirPanel(new MD1(), (Button)sender);
        }

        private void AbrirPanel(Form form, Button button)
        {
            if (_buttonActivo != null)
            {
                _buttonActivo.BackColor = Color.Khaki;
            }

            if (_formActivo != null) {
                _formActivo.Close();
            }

            _buttonActivo = button;
            _formActivo = form;

            _buttonActivo.BackColor = Color.DarkKhaki;
            
            
            // Limpiar el panel antes de agregar el nuevo formulario
            panelPantalla.Controls.Clear();

            // Configurar el formulario hijo
            _formActivo.TopLevel = false;
            _formActivo.FormBorderStyle = FormBorderStyle.None;
            _formActivo.Dock = DockStyle.Fill;
            _formActivo.BackColor = Color.PaleGoldenrod;

            // Agregar el formulario al panel y mostrarlo
            panelPantalla.Controls.Add(form);
            form.Show();
        }

        private void panelBotones_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
