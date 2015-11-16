import java.util.ArrayList;
import java.util.List;
import java.util.Scanner;
import java.util.regex.Matcher;
import java.util.regex.Pattern;

/**
 * Created by Borislav on 11/11/2015.
 */
public class PhoneNumbers {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        StringBuilder sb = new StringBuilder();
        String input = sc.nextLine();

        while (!input.equals("END")) {
            sb.append(input);
            input = sc.nextLine();
        }
        String inputStr = sb.toString();

        String nonTrash = inputStr.replaceAll("[^0-9a-zA-Z+\\s]+", "");
        System.out.println(nonTrash);
        Pattern pat = Pattern.compile("([A-Z][a-z]*)([+\\d]{2,})");
        Matcher match = pat.matcher(nonTrash);

        List<String> names = new ArrayList<>();
        List<String> numbers = new ArrayList<>();

        while (match.find()) {
            names.add(match.group(1));
            numbers.add(match.group(2));
        }


        if (names.isEmpty()) {
            System.out.println("<p>No matches!</p>");
        } else {
            System.out.print("<ol>");
            for (int i = 0; i < names.size(); i++) {
                if (i < names.size() - 1) {
                    System.out.printf("<li><b>%s:</b> %s</li>", names.get(i), numbers.get(i));
                } else {
                    System.out.printf("<li><b>%s:</b> %s</li></ol>", names.get(i), numbers.get(i));
                }
            }
        }

    }
}
