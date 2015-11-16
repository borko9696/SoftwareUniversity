import java.util.HashSet;
import java.util.LinkedHashSet;
import java.util.Scanner;
import java.util.Set;
import java.util.regex.Matcher;
import java.util.regex.Pattern;

public class RageQuit {
    public static void main(String[] args) {
        Scanner Console = new Scanner(System.in);

        String input = Console.nextLine().toUpperCase();

        Pattern pat = Pattern.compile("(\\D+)(\\d+)");
        Matcher match = pat.matcher(input);
        StringBuilder sb = new StringBuilder();


        while (match.find()) {
            String words = match.group(1);
            int count =Integer.parseInt(match.group(2));

            for (int i = 0; i < count; i++) {
                sb.append(words);
            }
        }
        String result = sb.toString();

        Set<Character> symbols = new HashSet<>();
        for (int i = 0; i < result.length(); i++) {
            symbols.add(result.charAt(i));
        }
        System.out.println("Unique symbols used: " + symbols.size());
        System.out.println(result);
    }
}
