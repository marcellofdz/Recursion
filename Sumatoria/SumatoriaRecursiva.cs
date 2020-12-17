using System;

class Program{
    static void Main(string[] args){
        int vNum1 = Convert.ToInt32(args[0]);

    //Console.Write("Ingresar la cantidad de terminos naturales: ");
    //     vNum1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("La suma de los primeros numeros naturales es: "+sumaRecursiva(vNum1));
         //Console.ReadLine();
    }

    //Llamada al metodo de suma recursiva con tail recursion
    static int sumaRecursiva(int vNum1){
        if(vNum1 != 1)
        return vNum1 +sumaRecursiva(vNum1-1); //-1 hace el tail recursion para repetir lo ultimo
        
        else
        
        {            
        return 1;
        }
    }
}