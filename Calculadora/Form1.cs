using System.Drawing;

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
                _buttonActivo.BackColor = ColorTranslator.FromHtml("#677D6A");
            }

            if (_formActivo != null) {
                _formActivo.Close();
            }

            _buttonActivo = button;
            _formActivo = form;

            _buttonActivo.BackColor = ColorTranslator.FromHtml("#40534C");
            _buttonActivo.ForeColor = ColorTranslator.FromHtml("#D6BD98");


            // Limpiar el panel antes de agregar el nuevo formulario
            panelPantalla.Controls.Clear();

            // Configurar el formulario hijo
            _formActivo.TopLevel = false;
            _formActivo.FormBorderStyle = FormBorderStyle.None;
            _formActivo.Dock = DockStyle.Fill;
            _formActivo.BackColor = ColorTranslator.FromHtml("#729762");
            _formActivo.ForeColor = ColorTranslator.FromHtml("#D6BD98");

            // Agregar el formulario al panel y mostrarlo
            panelPantalla.Controls.Add(form);
            form.Show();
        }

        private void panelBotones_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
