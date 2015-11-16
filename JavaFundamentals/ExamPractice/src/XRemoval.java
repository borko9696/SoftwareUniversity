import java.util.ArrayList;
import java.util.List;
import java.util.Scanner;

/**
 * Created by Borislav on 29/10/2015.
 */
public class XRemoval {
    public static void main(String[] args) {
        Scanner Console = new Scanner(System.in);
        List<char[]> list = new ArrayList<>();
        List<char[]> result = new ArrayList<>();

        String line = Console.nextLine();
        while (!line.equals("END")) {
            char[] arr = line.toCharArray();
            list.add(arr);
            line = Console.nextLine();
        }

        for (int i = 0; i < list.size(); i++) {
            char[] temp = new char[list.get(i).length];
            for (int j = 0; j < list.get(i).length; j++) {
                temp[j] = list.get(i)[j];
            }
            result.add(temp);
        }

        for (int i = 1; i < list.size()-1; i++) {
            for (int j = 1; j < list.get(i).length ; j++) {
                if (i - 1 >= 0 && j - 1 >= 0
                        && i + 1 < list.size()
                        && j + 1 < list.get(i - 1).length
                        && j + 1 < list.get(i + 1).length) {
                    if (Character.toLowerCase(list.get(i)[j]) == Character.toLowerCase(list.get(i - 1)[j - 1]) &&
                            Character.toLowerCase(list.get(i)[j]) == Character.toLowerCase(list.get(i - 1)[j + 1]) &&
                            Character.toLowerCase(list.get(i)[j]) == Character.toLowerCase(list.get(i + 1)[j - 1]) &&
                            Character.toLowerCase(list.get(i)[j]) == Character.toLowerCase(list.get(i + 1)[j + 1])) {

                        result.get(i)[j] = result.get(i - 1)[j - 1] = result.get(i - 1)[j + 1]
                                = result.get(i + 1)[j - 1] = result.get(i + 1)[j + 1] = '\0';


                    }
                }
            }
        }

        List<String> done = new ArrayList<>();
        for (int i = 0; i < result.size(); i++) {
            String array = String.copyValueOf(result.get(i));
            String replace = array.replaceAll("\0","");
            done.add(replace);
        }
        for (String s : done) {
            System.out.println(s);
        }


    }
}
