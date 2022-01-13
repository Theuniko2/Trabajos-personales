using System;
namespace Multiplos{

    class Program{
        static void Main(string[] args){


            //imprimir los multiplos de 3 y de 2  den 0 al 100
            for (int i = 1; i < 100; i++)
            {
                if(i % 2 == 0 && i % 3 == 0 ){
                    Console.WriteLine(i + " Es múltiplo de 2 y 3");

                }
                else
                {
                    if( i % 2 == 0){
                        Console.WriteLine(i + " Es múltiplo de 2");
                    }
                    else if(i % 3 == 0){
                        Console.WriteLine(i + " El numero es multiplo de 3");
                    }
                    
                }
            }
        }
    }
    
}
