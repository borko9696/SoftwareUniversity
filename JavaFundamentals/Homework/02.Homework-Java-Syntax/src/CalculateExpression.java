import java.util.Scanner;

/**
 * Created by Borislav on 15/10/2015.
 */
public class CalculateExpression {
    public static void main(String[] args) {
        Scanner Console = new Scanner(System.in);
        double a = Double.parseDouble(Console.nextLine());
        double b = Double.parseDouble(Console.nextLine());
        double c = Double.parseDouble(Console.nextLine());

        double formul1 = Math.pow(((a * a) + (b * b)) / ((a * a) - (b * b)), (a + b + c) / Math.sqrt(c));
        double formul2 = Math.pow(((a * a) + (b * b) - (c * c * c)), (a - b));
        double formul3 = Math.abs(((a + b + c) / 3) - ((formul1 + formul2) / 2));

        System.out.printf("F1 result: %1$.2f; F2 result: %2$.2f; Diff: %3$.2f", formul1, formul2, formul3);
    }
}
