using System;

class FactorialRec{
    static public void Main(String[] args){
        int vNum = Convert.ToInt32(args[0]);
       Console.WriteLine("Tu factorial es: "+ fact(vNum));
    }

    static int fact(int y){
        return factR(y,1);
    }
    static int factR(int y, int x){
        if(y==0)
        return x;
        return factR(y-1,y*x);
    }
}