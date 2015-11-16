import java.util.Scanner;

/**
 * Created by Borislav on 22/10/2015.
 */
public class CountSpecifiedWord {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);
        String[] input = scan.nextLine().toLowerCase().split("\\W+");
        String isEqual = scan.nextLine().toLowerCase();
        int counter = 0;

        for (int i = 0; i < input.length - 1; i++) {
            if (input[i].equals(isEqual)) {
                counter++;
            }
        }
        System.out.println(counter);
    }
}
