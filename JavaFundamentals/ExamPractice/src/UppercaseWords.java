import java.util.Scanner;
import java.util.regex.Matcher;
import java.util.regex.Pattern;

/**
 * Created by Borislav on 11/11/2015.
 */
public class UppercaseWords {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        String input = sc.nextLine();

        while (!input.equals("END")) {
            input = input.replaceAll("<", "&lt;");
            input = input.replaceAll(">", "glt;");
            Pattern pat = Pattern.compile("\\b([A-Z]+)\\b");
            Matcher match = pat.matcher(input);
            while (match.find()) {
                String word = match.group(1);
                String reversed = new StringBuilder(word).reverse().toString();

                if (word.equals(reversed)) {
                    reversed = new String();
                    for (int i = 0; i < word.length(); i++) {
                        reversed = reversed.concat("" +word.charAt(i)+word.charAt(i));
                    }
                    word = String.format("\\b%s\\b",word);
                    input =  input.replaceAll(word, reversed);
                }else{

                    input = input.replaceAll(word, reversed);
                }
            }
            System.out.println(input);
            input = sc.nextLine();
        }
    }
}
