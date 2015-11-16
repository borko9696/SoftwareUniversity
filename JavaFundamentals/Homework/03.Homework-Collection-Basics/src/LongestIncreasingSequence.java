import java.util.ArrayList;
import java.util.List;
import java.util.Scanner;

/**
 * Created by Borislav on 22/10/2015.
 */
public class LongestIncreasingSequence {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);
        String input = scan.nextLine();
        String[] arrayStr = input.split(" ");

        int[] numbers = new int[arrayStr.length];
        int counter = 1;
        int maxCounter = 1;
        int positionOfInt = 0;

        for (int i = 0; i < arrayStr.length; i++) {
            numbers[i] = Integer.parseInt(arrayStr[i]);
        }

        System.out.print(numbers[0]);
        for (int i = 1; i < numbers.length; i++) {

            if (numbers[i] > numbers[i - 1]) {
                System.out.print(" " + numbers[i]);
                counter++;
            } else {
                counter = 1;
                System.out.println();
                System.out.print(numbers[i]);
            }

            if (maxCounter < counter) {
                maxCounter = counter;
                positionOfInt = i;
            }
        }

        System.out.println();
        System.out.print("Longest: ");

        for (int i = 0; i < maxCounter - 1; i++) {
            System.out.print(numbers[positionOfInt - maxCounter + 1 + i] + " ");
        }
        System.out.print(numbers[positionOfInt]);
    }
}
