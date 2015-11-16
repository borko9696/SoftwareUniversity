import java.util.Scanner;

/**
 * Created by Borislav on 22/10/2015.
 */

public class SequencesOfEqualStrings {
    public static void main(String[] args) {
        Scanner getInput = new Scanner(System.in);
        String[] inputLine = getInput.nextLine().split(" ");


        System.out.print(inputLine[0]+ " ");
        for (int i = 1; i < inputLine.length; i++) {
            if (inputLine[i].equals(inputLine[i - 1])) {
                System.out.print(inputLine[i] + " ");
            } else {
                System.out.println();
                System.out.print(inputLine[i] + " ");
            }
        }
        System.out.println();
    }
}