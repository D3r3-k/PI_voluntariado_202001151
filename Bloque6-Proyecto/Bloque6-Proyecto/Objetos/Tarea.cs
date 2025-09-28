public class Tarea
{
    // Propiedades
    private string titulo;
    private string descripcion;
    private bool completada;

    // Constructor
    public Tarea(string titulo, string descripcion)
    {
        this.titulo = titulo;
        this.descripcion = descripcion;
        this.completada = false;
    }

    // Métodos
    public void toggleCompletada()
    {
        this.completada = !completada;
    }

    // Getters
    public string getTitulo() { return this.titulo; }
    public string getDescripcion() { return this.descripcion; }
    public bool isCompletada() { return this.completada; }
    // Setters
    public void setTitulo(string titulo) { this.titulo = titulo; }
    public void setDescripcion(string descripcion) { this.descripcion = descripcion; }
    public void setCompletada(bool completada) { this.completada = completada; }

}