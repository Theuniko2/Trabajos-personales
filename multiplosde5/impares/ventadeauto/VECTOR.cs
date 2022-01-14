using System;
/* El sueldo que perciben los vendedores de una empresa automotriz, está
integrado por de la manera siguiente: el salario mínimo, mas $100.000 por
cada auto vendido, más el 2% del valor de los autos vendidos.
Se tiene varios vendedores, por cada vendedor se tiene el nombre y el
precio de cada auto que vendió en la quincena; es posible que algunos
vendedores no hayan realizado venta alguna, en tal caso solo se tendrá
el nombre */
class VECTOR
{   
    private double[] sueldo;
    private string[] nombre;
    private int[] valorAutosVendidos;
    private int[] cantidadAutosVendidos;
    private int numeroVendedor= 5; 

    public  void cargarVendedores() 
    {
        nombre = new string[numeroVendedor];
        valorAutosVendidos = new int [numeroVendedor];
        cantidadAutosVendidos = new int [numeroVendedor];
       for (int i = 0; i < numeroVendedor; i++)
       {
           Console.WriteLine("ESCRIBA EL NOMBRE DEL VENDEDOR");
           nombre[i]= Console.ReadLine();
           Console.WriteLine("¿CUÁNTOS AUTOS VENDIO ESTE VENDEDOR?");
           cantidadAutosVendidos[i]=int.Parse(Console.ReadLine());
           Console.WriteLine("INGRESE EL VALOR DE LOS AUTO VENDIDO");
           valorAutosVendidos[i]= int.Parse(Console.ReadLine());
        

       }
    }
    public void nomina(){
        sueldo = new double[numeroVendedor];

        for (int i = 0; i < numeroVendedor; i++)
        {
            sueldo[i] = 1000000 + (100000*cantidadAutosVendidos[i]) + (0.02 * valorAutosVendidos[i]);
        }
    }
    public void imprimir(){


        Console.WriteLine("======NOMINA DE VENDEDORES=====");
        for (int i = 0; i < numeroVendedor; i++)
        {
   
        Console.WriteLine(nombre[i]+" "+sueldo[i]);
        }
        

    }
    static void Main(string[]args){
        VECTOR vec = new VECTOR();
        vec.cargarVendedores();
        vec.nomina();
        vec.imprimir();


    }
}
