using System;
class SumTail{
    public static void Main(string[] args){
        int []array={7,86,4,90}; //arreglo con mis valores a sumar
        int tamaño=array.Length; //definiendo el tamaño de mi arreglo

        //Print el resultado de la sumatoria de los valores de mi arreglo
        Console.WriteLine(SumaArr(array,tamaño,0));
    }
            //definiendo mi metodo   
    static int SumaArr(int []array,int tamaño,int sum){
        if(tamaño !=0){
        return SumaArr(array,tamaño-1,sum+array[tamaño-1]);
        }
        return sum;
    }
}
