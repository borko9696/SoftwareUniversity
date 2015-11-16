import java.util.Scanner;
import java.util.regex.Matcher;
import java.util.regex.Pattern;

/**
 * Created by Borislav on 10/11/2015.
 */
public class SumOfAllValues {
    public static void main(String[] args) {
        Scanner scr = new Scanner(System.in);

        String keysString = scr.nextLine();
        String textString = scr.nextLine();


        String startKey = "";
        String endKey = "";

        Pattern keyPat = Pattern.compile("(\\D*)\\d+.*\\d+(\\D*)");
        Matcher keyMatch = keyPat.matcher(keysString);

        while (keyMatch.find()) {
            startKey = keyMatch.group(1);
            endKey = keyMatch.group(2);
        }

        Pattern textPat = Pattern.compile(startKey + "([\\d]*\\.*[\\d]+)" + endKey);
        Matcher textMatch = textPat.matcher(textString);
        double sum = 0d;
        while (textMatch.find()) {
            double number = Double.parseDouble(textMatch.group(1));
            sum += number;
        }

        String result = "";
        if (sum > (int) sum) {
            result = String.format("%.2f", sum);
        } else {
            int sumInt = (int)sum;
            result = String.format("%d",sumInt);
        }

        if (startKey.equals("") || endKey.equals("")) {
            System.out.println("<p>A key is missing</p>");
        } else if (sum == 0) {
            System.out.println("<p>The total value is: <em>nothing</em></p>");
        } else {
            System.out.printf("<p>The total value is: <em>%s</em></p>", result);
        }

    }
}
