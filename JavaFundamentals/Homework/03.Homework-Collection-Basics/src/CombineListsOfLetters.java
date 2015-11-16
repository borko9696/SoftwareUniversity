import java.util.ArrayList;
import java.util.List;
import java.util.Scanner;

/**
 * Created by Borislav on 22/10/2015.
 */
public class CombineListsOfLetters {
    public static void main(String[] args) {
        Scanner Console = new Scanner(System.in);
        String[] firsLine = Console.nextLine().split(" ");
        String[] secondLine = Console.nextLine().split(" ");


        List<String> list = new ArrayList<>();

        for (int i = 0; i < firsLine.length; i++) {
            list.add(firsLine[i]);
        }

        for (int i = 0; i < secondLine.length; i++) {
            boolean bool = false;
            for (int j = 0; j < firsLine.length; j++) {
                if (secondLine[i].contains(firsLine[j])) {
                    bool = true;
                } else {

                }
            }
            if (bool == false) {
                list.add(secondLine[i]);
            }
        }

        for (int i = 0; i < list.size(); i++) {
            System.out.print(list.get(i) + " ");
        }
    }
}
