import java.util.Scanner;
import java.util.regex.Matcher;
import java.util.regex.Pattern;

/**
 * Created by Borislav on 16/10/2015.
 */
public class ExtractWords {
    public static void main(String[] args) {

        Scanner Console = new Scanner(System.in);
        String input=Console.nextLine();
        Pattern patern=Pattern.compile("[a-zA-z]+");
        Matcher lineMatch=patern.matcher(input);

        while (lineMatch.find()){
            System.out.print(lineMatch.group() + " ");
        }
    }
}
