namespace Bloque5_Practica
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            string input = inputNumero.Text;
            try
            {
                int numero = int.Parse(input);
                if (numero < 0)
                {
                    MessageBox.Show("El número no puede ser negativo.");
                    return;
                }
                int resultado = numero * 2;
                MessageBox.Show("El resultado es: " + resultado);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"[Error]: {ex.Message}");
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            txt_hora_actual.Text = DateTime.Now.ToString("dd/mm/yyyy HH:mm:ss");
        }

        private void btnAbrirInfo_Click(object sender, EventArgs e)
        {
            using(var i = new info())
            {
                i.ShowDialog();
            }
        }
    }
}
