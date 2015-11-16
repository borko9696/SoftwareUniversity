import java.util.Scanner;

/**
 * Created by Borislav on 22/10/2015.
 */
public class CountSubstringOccurrences {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);
        String text = scan.nextLine().toLowerCase();
        String word = scan.nextLine().toLowerCase();
        int counter = 0;

        for (int i = 0; i <= text.length() - word.length(); i++) {

            if (text.substring(i, word.length() + i).contains(word)) {
                counter++;
            }
        }

        System.out.println(counter);
    }
}
