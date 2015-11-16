import java.util.*;

/**
 * Created by Borislav on 27/10/2015.
 */
public class SortArrayWithStreamAPI {
    public static void main(String[] args) {
        Scanner Console = new Scanner(System.in);
        String[] line = Console.nextLine().split(" ");
        String comand = Console.nextLine();
        Integer[] firstLineArray = new Integer[line.length];

        for (int i = 0; i < line.length; i++) {
            firstLineArray[i] = Integer.parseInt(line[i]);
        }

        if (comand.equals("Ascending")) {
            Arrays.sort(firstLineArray);
            for (int i = 0; i < firstLineArray.length; i++) {
                System.out.print(firstLineArray[i] + " ");
            }
        } else if (comand.equals("Descending")) {
            Arrays.sort(firstLineArray, Collections.reverseOrder());
            for (int i = 0; i < firstLineArray.length; i++) {
                System.out.print(firstLineArray[i] + " ");
            }
        }

    }
}
