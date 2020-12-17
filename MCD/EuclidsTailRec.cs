using System;
class Euclide{
    public static void Main(){

        Console.WriteLine("Dame el primer valor: ");
        int vNum1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Dame el segundo valor: ");
        int vNum2 = Convert.ToInt32(Console.ReadLine());

        //int a = 10, b = 15, g; 
        int g;
        g = gcd(vNum1, vNum2); 
        Console.WriteLine("GCD(" + vNum1 + " , " + vNum2 + ") = " + g); 
        
        
        vNum1 = 35; vNum2 = 10; 
        g = gcd(vNum1, vNum2); 
        Console.WriteLine("GCD(" + vNum1 + " , " + vNum2 + ") = " + g); 
          
        vNum1 = 31; vNum2 = 2; 
        g = gcd(vNum1, vNum2); 
        Console.WriteLine("GCD(" + vNum1 + " , " + vNum2 + ") = " + g); 
    }
    public static int gcd(int vNum1,int vNum2){
        if(vNum1==0)
        return vNum2;

        return gcd(vNum2%vNum1,vNum1);
    }
}