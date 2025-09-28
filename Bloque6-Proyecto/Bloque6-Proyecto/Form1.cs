namespace Bloque6_Proyecto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string tarea = inputTarea.Text;
            string descripcion = inputDescripcion.Text;
            if (!string.IsNullOrWhiteSpace(tarea) && !string.IsNullOrWhiteSpace(descripcion))
            {
                Tarea nuevaTarea = new Tarea(tarea, descripcion);
                Globales.listaTareas.Add(nuevaTarea);
                ActualizarLista();
            }
            else
            {
                MessageBox.Show("Por favor, ingrese una tarea y una descripción válidas.", "Entrada inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label_hora.Text = DateTime.Now.ToString("dd/mm/yyyy HH:mm:ss");
        }
        public void ActualizarLista()
        {
            listaTareasbox.Items.Clear();
            foreach (var tarea in Globales.listaTareas)
            {
                listaTareasbox.Items.Add(tarea.getTitulo() +" | "+tarea.isCompletada());
            }
        }

        private void btnCompletar_Click(object sender, EventArgs e)
        {
            int indice = listaTareasbox.SelectedIndex;
            if (indice < 0)
            {
                MessageBox.Show("Por favor, seleccione una tarea para completar.", "Selección inválida");
                return;
            }
            Globales.listaTareas[indice].setCompletada(true);
            ActualizarLista();
        }
    }
}
