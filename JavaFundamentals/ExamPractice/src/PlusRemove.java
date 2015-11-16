import java.util.ArrayList;
import java.util.List;
import java.util.Scanner;

/**
 * Created by Borislav on 28/10/2015.
 */
public class PlusRemove {
    public static void main(String[] args) {
        Scanner Console = new Scanner(System.in);
        List<char[]> list = new ArrayList<>();
        List<char[]> clone = new ArrayList<>();
        String line = Console.nextLine();

        while (!line.equals("END")) {
            char[] charLine = line.toCharArray();
            list.add(charLine);

            line = Console.nextLine();
        }


        for (int i = 0; i < list.size(); i++) {
            char[] temp = new char[list.get(i).length];
            for (int j = 0; j < list.get(i).length; j++) {
                temp[j] = list.get(i)[j];
            }
            clone.add(temp);
        }

        for (int row = 1; row < list.size() - 1; row++) {
            for (int col = 1; col < list.get(row).length - 1; col++) {
                if (col < list.get(row - 1).length && col < list.get(row + 1).length) {
                    if (Character.toLowerCase(list.get(row)[col]) == Character.toLowerCase(list.get(row - 1)[col]) &&
                            Character.toLowerCase(list.get(row)[col]) == Character.toLowerCase(list.get(row + 1)[col]) &&
                            Character.toLowerCase(list.get(row)[col]) == Character.toLowerCase(list.get(row)[col - 1]) &&
                            Character.toLowerCase(list.get(row)[col]) == Character.toLowerCase(list.get(row)[col + 1])) {

                        clone.get(row)[col] = clone.get(row - 1)[col] = clone.get(row + 1)[col] = clone.get(row)[col - 1]
                                = clone.get(row)[col + 1] = '\0';
                    }
                }
            }
        }
        List<String> result = new ArrayList<>();
        for (int i = 0; i < clone.size(); i++) {
            String array = String.copyValueOf(clone.get(i));
            String replace = array.replaceAll("\0", "");
            result.add(replace);
        }
        for (String s : result) {
            System.out.println(s);
        }
    }
}
