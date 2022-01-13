using System;
namespace Sumatoria{

class program {
    static void Main(string[] args){

        Console.WriteLine("Por favor ingrese un número");
        int vnumero;
        vnumero= int.Parse(Console.ReadLine());
        
        int sumatoria;
        sumatoria=0;
        for (int i = vnumero; i > 0; i--){
            sumatoria= sumatoria + i;
        }
        Console.WriteLine("La sumatoria es: ");
        Console.WriteLine(sumatoria );    
    }
    } 
}