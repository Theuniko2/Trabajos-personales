using System;
namespace cobroestacionamiento{

class program {
    static void Main(string[] args){

        /*Realice un algoritmo que calcule el monto a pagar por el servicio de
estacionamiento, teniendo en cuenta que por la primera hora de estadía
se tiene una tarifa de 1000 pesos y las restantes tienen un costo de 600 
pesos. Se tiene como datos: hora de entrada, hora de salida (formato
militar), iniciada una hora se contabiliza como hora total.*/

    Console.WriteLine("==========ESTACIONAMIENTO==========");
    int valorhoraextra, valorhora, total,hora;
    valorhora = 1000;
    valorhoraextra = 600;
    int horaE, horaS;
    Console.WriteLine("Ingrese hora de entrada: ");
    horaE= int.Parse(Console.ReadLine().Split(':')[0]);

    Console.WriteLine("Ingrese hora de salida: ");
    horaS= int.Parse(Console.ReadLine().Split(':')[0]);
    hora= horaS-horaE;


    if (hora == 0 )
    {
        Console.WriteLine("El monto a pagar es: ");
        Console.WriteLine(valorhora);
    }
    else
    {
        total=1000 +(hora)* valorhoraextra;
        Console.WriteLine("El monto a pagar es: "+ total);
    }
        Console.ReadKey();
    }
    } 
}