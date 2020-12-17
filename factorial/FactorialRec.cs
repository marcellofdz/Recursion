using System;
public class FactorialRec{
    public static void Main(String[] args){
        int vNum = Convert.ToInt32(args[0]);
        Console.WriteLine("Su Factorial es: " + factorial(vNum));
    }
    public static long factorial(int n){
        if(n==1){
            return n;
        }
        return n*factorial(n-1);
    }
}