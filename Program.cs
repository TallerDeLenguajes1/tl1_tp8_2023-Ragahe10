// See https://aka.ms/new-console-template for more information

// Console.WriteLine("Ingrese una carpeta o nombre de directorio: ");
// var carpeta = Console.ReadLine();
// Console.WriteLine(carpeta);
// if(Directory.Exists(carpeta)){
//     var archivos = Directory.GetFiles(carpeta);
//     foreach (var archivo in archivos){
//         Console.WriteLine(archivo.ToString());
//     }
// }
Console.Write("Ingrese una ruta valida: ");
var path = Console.ReadLine();

if(!Directory.Exists(path)){
    Console.WriteLine("ERROR. Ruta invalida\n");
} else{
    List<string> listaArchivos = Directory.GetFiles(path).ToList();
    System.Console.WriteLine("**" + path + "**");
    foreach (var archivo in listaArchivos){
        Console.WriteLine(archivo);
    }
    using(StreamWriter indexador = new StreamWriter("index.csv")){
        indexador.WriteLine("n°;Nombre;Extencion");
        for(int i = 0; i < listaArchivos.Count; i++){
            // El método Path.GetFileWithoutExtension() devuelve solo el nombre del archivo
            // El método Path.GetExtension() devuelve la extensión del archivo
            indexador.WriteLine($"{i};{Path.GetFileNameWithoutExtension(listaArchivos[i])};{Path.GetExtension(listaArchivos[i])}");
        }

        indexador.Close();
        indexador.Dispose();
    }
}