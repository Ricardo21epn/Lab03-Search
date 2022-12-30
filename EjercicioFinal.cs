namespace Lab3_1;
class EjercicioFinal
{
    static void Main(string[] args)
    {
        //Inicializo
        double porcentajeAciertos, porcentajeError;
        int aciertos = 0, errores = 0, total = 0;
        Random aleatorio = new Random();
        int [] arreglo = new int [100];
        int [] busqueda = new int [50];
        for (int i = 0; i < arreglo.Length; i++)
        {
            arreglo[i] = aleatorio.Next(1,200);
        }
        for (int j = 0; j < busqueda.Length; j++)
        {
            busqueda[j] = aleatorio.Next(1,200);
        }

        //Busqueda
        for (int i = 0; i < busqueda.Length; i++)
        {
            int aux = BusquedaLineal(arreglo, arreglo.Length, busqueda[i]);
            if (aux != -1){
                aciertos++;
            }else{
                errores++;
            }
        }

        //Despliegue
        total = aciertos+errores;
        Console.WriteLine("Busquedas con exito: "+aciertos+" \nBusquedas fallida: "+errores);
        porcentajeAciertos = (double)aciertos/total;
        porcentajeError = (double) errores/total;
        Console.WriteLine("Porcentaje de exito: "+porcentajeAciertos*100+"% \nPorcentaje de fallo: "+porcentajeError*100+"%");
        Array.Sort(arreglo);
        for (int i = 0; i < arreglo.Length; i++)
        {
            Console.Write(arreglo[i]+ ", ");
        }
    }

    static int BusquedaLineal(int[] A, int n, int clave)
    {
        for (int i = 0; i < n; i++)
            if (A[i] == clave)
                return i;
        return -1;
    }
}


