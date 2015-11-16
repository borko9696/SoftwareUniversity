import java.util.Scanner;

/**
 * Created by Borislav on 27/10/2015.
 */
public class CalculateFactorial {
    public static void main(String[] args) {
        Scanner Console = new Scanner(System.in);
        int number = Integer.parseInt(Console.nextLine());
        int factorial = 1;
        for (int i = 1; i <= number; i++) {
            factorial*=i;
        }
        System.out.println(factorial);
    }
}
