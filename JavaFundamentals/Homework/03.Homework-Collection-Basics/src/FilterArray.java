import java.util.ArrayList;
import java.util.Collections;
import java.util.List;
import java.util.Scanner;

/**
 * Created by Borislav on 27/10/2015.
 */
public class FilterArray {
    public static void main(String[] args) {
        Scanner Console = new Scanner(System.in);
        String[] line = Console.nextLine().split(" ");
        List<String> listWords = new ArrayList<>();

        boolean empty = true;
        for (int i = 0; i < line.length; i++) {
            if (line[i].length() > 3) {
                listWords.add(line[i]);
                empty = false;
            }
        }
        if (empty == false) {
            for (int i = 0; i < listWords.size(); i++) {
                System.out.print(listWords.get(i) + " ");
            }
        }else {
            System.out.println("(empty)");
        }

    }
}
