using System.Diagnostics;
namespace Lab3;
class LinealSearch
{
    static void Main(string[] args)
    {
        Stopwatch reloj = new Stopwatch();
        Console.WriteLine("\t\tAlgoritmo de busqueda lineal");
        int[] A = {79, 21, 15, 99, 88, 65, 75, 85, 76, 46, 84, 24,
        15, 17, 19, 17, 13, 10, 5, 8};
        Console.WriteLine("Arreglo desordenado: ");
        for (int i = 0; i < A.Length; i++)
        {
            Console.Write($"A[{i}]={A[i]}, ");
        }
        Console.Write("\nIngresa un numero a buscar: ");
        int buscar = Convert.ToInt32(Console.ReadLine());
        string time = DateTime.Now.ToString("h:mm:ss tt");
        Console.WriteLine("La hora de inicio: {0}", time);
        reloj.Start();
        int posicionEncontrada = BusquedaLinealID(A, A.Length, buscar);
        if(posicionEncontrada != 1){
            Console.WriteLine($"Elemento encontrado en A[{posicionEncontrada}]={A[posicionEncontrada]}");
        }else{
            Console.WriteLine($"Elemento no encontrado");
        }
        time = DateTime.Now.ToString("h:mm:ss tt");
        Console.WriteLine("La hora final: {0}", time);
        reloj.Stop();
        Console.WriteLine($"Tiempo de ejecución:{reloj.Elapsed.TotalMilliseconds} ms");

    }

    static int BusquedaLinealID(int[] A, int n, int clave)
    {
        for (int i = 0; i < n; i++)
            if (A[i] == clave)
                return i;
        return -1;
    }

}
