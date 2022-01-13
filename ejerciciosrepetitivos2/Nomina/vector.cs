/*Realice un algoritmo para la empresa Constructora Tecno vivir Casas
C.A., que le permita calcular e imprimir la nómina para su cancelación a
un total de 50 obreros calificados a quienes debe cancelar por horas
trabajadas. La hora trabajada se pautó en 10.000 Pesos.*/
using System;
namespace Nomina{
    class vector{
        //static void Main(string[] args){
        
        private string [] Nombre;
        private int[] horastrabajadas;
        private int[] sueldoMes;
        private int Length= 3;
        public void cargar(){
            
            Nombre= new string[Length];
            horastrabajadas =new int[Length];

            
            for (int i = 0; i < Length; i++)
            {
                Console.WriteLine("Escriba el nombre del empleado: ");
                Nombre[i]=Console.ReadLine();
               Console.WriteLine("Escriba las horas trabajadas del empleado: ");
               horastrabajadas[i]=int.Parse(Console.ReadLine());

            }


        }
        public void calcularNomina(){
            sueldoMes= new int[Length];
            for (int i = 0; i < Length; i++)

            {
                sueldoMes[i]= 10000*horastrabajadas[i];
            }

        }
        public void ImprimirNomina(){
            Console.WriteLine("====NOMINA MES====");
            for (int i = 0; i <  Length; i++)
            {
                Console.WriteLine("El sueldo de: "+Nombre[i] +" es de "+ sueldoMes[i]);               
            }
        }
        static void Main(string[] args){

            vector vec = new vector();
            vec.cargar ();
            vec.calcularNomina();
            vec.ImprimirNomina();

        }
    }
}

