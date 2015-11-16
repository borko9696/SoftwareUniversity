import java.util.Scanner;

/**
 * Created by Borislav on 15/10/2015.
 */
public class FormattingNumbers {
    public static void main(String[] args) {
        Scanner Console = new Scanner(System.in);
        int a = Integer.parseInt(Console.nextLine());
        double b = Double.parseDouble(Console.nextLine());
        double c = Double.parseDouble(Console.nextLine());

        String hexNum=Integer.toHexString(a);
        String binNum=Integer.toBinaryString(a);
        int binNumber=Integer.parseInt(binNum);

        System.out.printf("|%1$-10s|%2$010d|%3$10.2f|%4$-10.3f|",hexNum,binNumber,b,c);
    }
}
