namespace EspacioTarea;

public class Tarea{
    //ATRIBUTOS
    private int tareaID;
    private string? descripcion;
    private int duracion;
    //ATRIBUTOS
    //PROPIEDADES
    public int TareaID { get => tareaID; set => tareaID = value; }
    public string? Descripcion { get => descripcion; set => descripcion = value; }
    public int Duracion { get => duracion; set => duracion = value; }
    //PROPIEDADES
    //CONSTRUCTOR
    public Tarea(int id, string desc, int dur){
        TareaID = id;
        Descripcion = desc;
        Duracion = dur;
    }
    //CONSTRUCTOR
    //METODOS
    public void MostrarTarea(){
        Console.WriteLine(" ~ ID: "+ TareaID);
        Console.WriteLine(" ~ DESCRIPCION: "+Descripcion);
        Console.WriteLine(" ~ DURACION: "+Duracion);
    }
    //METODOS
}