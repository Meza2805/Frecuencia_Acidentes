using Frecuencia_Acidentes;
public class Program
{
    private static void Main(string[] args)
    {
        int anio,cantidad,respuesta=0;
        string ciudad="VALOR";
        frecuencia objeto = new frecuencia();
        bool bandera = false;
        Console.WriteLine("PROGRAMA PARA INGRESAR LOS REPORTE DE ACCIDENTES");
        Console.WriteLine("PRESIONE CUALQUIER TECLA PARA INCIAR....");
        Console.ReadKey();
        Console.Clear();
        do{
        bandera =false;
        Console.Clear();
        Console.WriteLine("A CONTINUACION SE SOLICITARA LOS DATOS DEL REPORTE");
        Console.WriteLine("PRESIONE CUALQUIER TECLA PARA INICIAR....");
        Console.WriteLine("==================");
        Console.WriteLine("INGRESE EL AÑO : ");
        Console.WriteLine("==================");
        anio = Convert.ToInt32(Console.ReadLine());  
        Console.Clear();
        Console.WriteLine("==================");
        Console.WriteLine("INGRESE EL NOMBRE DE LA CIUDAD: ");
        Console.WriteLine("==================");
        ciudad= Console.ReadLine(); 
        Console.Clear();
        Console.WriteLine("==================");
        Console.WriteLine("INGRESE EL NUMERO DE ACCIDENTES: ");
        Console.WriteLine("==================");
        cantidad = Convert.ToInt32(Console.ReadLine());   
        objeto.agregar_reporte(anio,ciudad,cantidad);    
        Console.Clear();
        Console.WriteLine("¿DESEA INGRESAR OTRO REPORTE?");
        Console.WriteLine("0. NO");
        Console.WriteLine("1. SI");
        respuesta = Convert.ToInt32(Console.ReadLine());
        if (respuesta == 1)
        {
            bandera=true;
        }
        }while (bandera == true);
  
        objeto.imprimir_reportes(); 
        Console.ReadKey();
        Console.Clear();
    }
}