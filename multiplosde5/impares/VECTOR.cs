using System;

/*. Realice un algoritmo que lea los primeros 300 números enteros y
determine cuántos de ellos son Impares; al final deberá indicar su
sumatoria.*/

namespace impares
{   
    class VECTOR{
    
    private int numero = 300;
    private int impares = 0;
    private int sumatoria=0;

    
    public void enterosimpares(){

        for (int i = 1; i <= 300; i++)
        {
            if (i%2!=0)
            {
            impares=impares+1;

            }     
        sumatoria = impares + sumatoria;
        }
        Console.WriteLine(impares);
        Console.WriteLine("La suma de estos números es de: "+sumatoria);


    }
    static void Main(string [] args){

        VECTOR vec = new VECTOR();
        vec.enterosimpares();
        
    }
    }
    
    }

