// See https://aka.ms/new-console-template for more information
using EspacioTarea;
int ID = 0;
List<string> Ltarea = new List<string>();
Ltarea.Add("Lavar");
Ltarea.Add("Limpiar");
Ltarea.Add("Ordenar");
Ltarea.Add("Reponer");
Ltarea.Add("Contabilizar");

Tarea CrearTarea(){
    Random Dur = new Random();
    ID++;
    Tarea T = new Tarea(ID,Ltarea[Dur.Next(0,5)],Dur.Next(10,100));
    return(T);
}

int cantidad;
Console.WriteLine("Ingrese cantidad de tareas: ");
if(!(int.TryParse(Console.ReadLine(), out cantidad))){
    cantidad = 0;
}
List<Tarea> Pendientes = new List<Tarea>();
for (int i = 0; i < cantidad; i++){
    Pendientes.Add(CrearTarea());
}
List<Tarea> Realizadas = new List<Tarea>();
for (int i = 0; i < (Pendientes.Count());){
    Pendientes[i].MostrarTarea();
    Console.WriteLine("Realizo la tarea? (si/no)");
    string? resp = Console.ReadLine();
    if(resp != null){
        if(resp.ToLower() == "si"){
            Realizadas.Add(Pendientes[i]);
            if(Pendientes.Remove(Pendientes[i])){
                Console.WriteLine("Se movió la tarea a 'Realizdas'");
            }
        }else{
            i++;
        }
    }
}

