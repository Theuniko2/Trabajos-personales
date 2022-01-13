import java.util.Scanner;

class Main {
    public static void main(String[] args){
        
         int x ;
         Scanner sc = new Scanner(System.in);

         x=sc.nextInt();
        
        //System.out.println(x);
        
         switch (x) {
            case 0: {
                System.out.println("Esta es el caso 0");
            break;
          }
          
            case 1: {
                 System.out.println("Esta es el caso 1");
            break;
         
          }
             default: {
                System.out.println("esta es la opción por defecto");
            break;
          }
          }
        

    }
}