namespace Summul3
{
    class Programa
    {
        static void Main(string[] args)
        {
            //contar los multiplos de 3 desde la unidad hasta un numero que ingresamos
            Console.WriteLine("ingreso número: ");
            int vnumero;
            vnumero = int.Parse(Console.ReadLine());
            int vcuenta;
            vcuenta = 0;

            for (int i = 1; i <= vnumero; i++){
                if(vnumero % 3 == 0){
                    vcuenta++;

                    
                }
            }
            Console.WriteLine(" En total de multiplos de 3 hay " + vcuenta);
            //comentario random
        }
            
    }
}
