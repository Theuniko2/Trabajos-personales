using System;
class program{
    static void Main(string[]args){

    int precioE,cantidad;
    precioE = 10000;
    Console.WriteLine("========TICKETS==========");
    Console.WriteLine("Ingresa la cantidad de entradas a comprar (Máximo 4 entradas al tiempo): ");
    cantidad=int.Parse(Console.ReadLine());

    switch (cantidad){
        case 1: 
            Console.WriteLine("Total de precio: "+precioE);
            break;
        case 2:
            Console.WriteLine("El total de su compra es: "+(precioE*2*0.9));
            break;
        case 3:
            Console.WriteLine("El total de su compra es: " + (precioE*3*0.85));
            break;
        case 4:
            Console.WriteLine("El total de su comptra es: "+(precioE*4*0.80));
            break;
        default:
            Console.WriteLine("No selecciono un número válido, por favor repita el proceso.");
            break;

    }

    }
}
