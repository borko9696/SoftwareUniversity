import java.util.Scanner;
import java.util.regex.Matcher;
import java.util.regex.Pattern;

/**
 * Created by Borislav on 16/10/2015.
 */
public class StartsAndEndsWithCapitalLetter {
    public static void main(String[] args) {
        Scanner Console=new Scanner(System.in);
        String input=Console.nextLine();
        Pattern patern=Pattern.compile("\\b([A-Z][a-zA-Z]*[A-Z])\\b");
        Matcher matcher=patern.matcher(input);

        while (matcher.find()){
            System.out.print(matcher.group()+ " ");
        }
    }
}
