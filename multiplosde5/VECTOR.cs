using System;
namespace multiplos5{
    /*Realice un algoritmo que halle la sumatoria de los números enteros
múltiplos de 5, comprendidos entre el 1 y el 100, es decir, 5 + 10 + 15 +….
+ 100. El programa deberá imprimir los números en cuestión y finalmente
su sumatoria*/
    class VECTOR{         
    private int numero = 100;
    private int sumatoria = 0;

    public void sumar (){

    for (int i =1; i <= 100; i++)
    {
        if (i%5==0)
        {
        sumatoria = i + sumatoria;
        }
        
    }
    Console.WriteLine("la sumatoria de estos números es: "+ sumatoria);
    }
    public void imprimir(){

        Console.WriteLine("Los multiplos comprendidos entre el 1 y el 100");
        for (int i = 1; i <= 100; i++)
        {
            if (i%5==0)
            {
                Console.WriteLine(i);
            }
        }
    } 
    static void Main(string[] argrs){
        VECTOR vec = new VECTOR();
        vec.imprimir();
        vec.sumar();

    }
    }
}    
