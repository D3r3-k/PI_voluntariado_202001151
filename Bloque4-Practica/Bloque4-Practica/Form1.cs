namespace Bloque4_Practica
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void btnSaludar_Click(object sender, EventArgs e)
        {
            string nombre = inputNombre.Text;
            MessageBox.Show($"Hola, {nombre}!");
        }
    }
}
