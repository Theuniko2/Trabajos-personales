 namespace Ejercicios{

        class vector{

          //  static void Main(string[] args){

                //  DESARROLLAR UN PROGRAMA QUE ME PERMITAR CARGAR 5 NOMBRES DE PERSONAS Y QUE ME INDIQUE SUS EDADES(DATOS DE ENTRADA, IMPRIMA DATO)
                private  string[] nombre;

                private int[] edad;

            public void cargar  ()
            {
                nombre = new string[5];
                edad = new int[5];
                for (int f = 0; f < nombre.Length; f++){
                    Console.WriteLine("Por favor digite su nombre");
                    nombre[f]= Convert.ToString(Console.ReadLine));
                    Console.WriteLine("Escribe tu edad")
                    edad[f] = int32.Parse(Console.ReadLine());
                }

            public void mayoredad() 
                      


            }

            }

        }    

    }