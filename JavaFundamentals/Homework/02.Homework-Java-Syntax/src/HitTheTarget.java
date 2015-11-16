import java.util.Scanner;

/**
 * Created by Borislav on 16/10/2015.
 */
public class HitTheTarget {
    public static void main(String[] args) {
        Scanner Console=new Scanner(System.in);
        int n=Integer.parseInt(Console.nextLine());

        for (int i = 1; i <= 20 ; i++) {
            for (int j = 1; j <= 20 ; j++) {
                if (i+j==n){
                    System.out.printf("%1$d + %2$d = %3$d \n",i,j,n);
                }
                else if (i-j==n) {
                    System.out.printf("%1$d - %2$d = %3$d \n",i,j,n);
                }
            }
        }
    }
}
