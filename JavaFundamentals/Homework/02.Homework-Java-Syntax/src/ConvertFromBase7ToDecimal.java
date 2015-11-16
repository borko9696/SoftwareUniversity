import java.util.Scanner;

/**
 * Created by Borislav on 19/10/2015.
 */
public class ConvertFromBase7ToDecimal {
    public static void main(String[] args) {
        Scanner Console = new Scanner(System.in);
        String num = Console.nextLine();
        int result = 0;


        for (int i = 0; i < num.length(); i++) {
            int curentNum = Character.getNumericValue(num.charAt(i));
            int multiplier = (int) Math.pow(7,(num.length()-1)-i );
            result += curentNum * multiplier;

        }
        System.out.println(result);

    }
}
